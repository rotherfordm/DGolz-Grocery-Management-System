using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thesis
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        private void ClearTextbox()
        {
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtEmployeeAddress.Clear();
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleInitial.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            DisableUpdateButton();

        }

        #region Disable Update Button Function

        private void DisableUpdateButton()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void EnableUpdateButton()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }
        #endregion

        #region Button Fuctions

        private void btnEmployee_Exit_Click(object sender, EventArgs e)
        {
            FrmMain logout = new FrmMain();
            logout.Show();
            this.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text != "" && txtMiddleInitial.Text != "" && txtLastName.Text != ""
              && (txtContactNumber.Text == "" || isValidContactNumber(txtContactNumber.Text)))
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this?", "Confirmation",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int admin;
                    if (chkAdmin.Checked == true)
                    {
                        admin = 1;
                    }
                    else
                    {
                        admin = 0;
                    }

                    con.Open();
                    cmd = new SqlCommand(@"INSERT INTO Employee
                      (FirstName, MiddleName, LastName, Address, ContactNumber, Email, UserName, Password, IsAdmin) 
                       VALUES
                       ('" + txtFirstName.Text + "','" + txtMiddleInitial.Text + "','" + txtLastName.Text + "'," +
                    "'" + txtContactNumber.Text + "','" + txtEmail.Text + "', '" + txtEmployeeAddress.Text + "'" +
                    ",'" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + admin + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Congrats, Added!", "Congrats");

                }

                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Adding Cancelled", "Cancelled");
                }
            }

            else
            {
                MessageBox.Show("Invalid Input", "Warning");
            }

            dataEmployee.Rows.Clear();
            LoadEmployee();
            ClearTextbox();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtFirstName.Text != "" && txtMiddleInitial.Text != "" && txtLastName.Text != "")
                {
                    con.Open();
                    cmd = new SqlCommand(@" DELETE FROM Employee
                where EmployeeID = '" + txtEmployeeID.Text + "' ", con);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Delete Sucessful", "Success");
                }
                else
                {
                    MessageBox.Show("Invalid Input", "Invalid");

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled", "Cancelled");
            }

            dataEmployee.Rows.Clear();
            LoadEmployee();
            ClearTextbox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtMiddleInitial.Text != "" && txtLastName.Text != "" && (txtContactNumber.Text == "" || isValidContactNumber(txtContactNumber.Text)))
            {
                DialogResult DialogResult = MessageBox.Show("Are you sure you want to Update this?", "Confirmation", MessageBoxButtons.YesNo);
                if (dataEmployee.SelectedRows.Count != 0 && DialogResult == DialogResult.Yes)
                {

                    int admin;
                    if (chkAdmin.Checked == true)
                    {
                        admin = 1;
                    }
                    else
                    {
                        admin = 0;
                    }


                    con.Open();
                    cmd = new SqlCommand(@"update Employee
                    set FirstName = '" + txtFirstName.Text + "',MiddleInitial = '" + txtMiddleInitial.Text
                    + "',LastName='" + txtLastName.Text + "',ContactNumber = '" + txtContactNumber.Text + "'"
                    + ",Email = '" + txtEmail.Text + "',Address = '" + txtEmployeeAddress.Text + "', Username = '" + txtUsername.Text
                    + "', Password = '" + txtPassword.Text + "', IsAdmin = '" + admin + "' where EmployeeID = '" + txtEmployeeID.Text + "' ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Update Sucessful", "Success");

                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Update Cancelled", "Cancelled");
                }

            }

            else
            {
                MessageBox.Show("Invalid Input", "Invalid");

            }
            dataEmployee.Rows.Clear();
            LoadEmployee();
            ClearTextbox();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        #endregion

        #region Check Digit

        private bool isDigit(char c)
        {
            string numbers = "0123456789";
            return numbers.Contains(c);
        }

        private bool isNumber(string sequence)
        {
            foreach (char c in sequence)
            {
                if (!isDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool isValidContactNumber(string sequence)
        {
            return (isNumber(sequence) && sequence.Length >= 11//cellphone numbers
                || sequence.Length == 7 || sequence.Length == 10); //telephone numbers
        }

        #endregion

        #region LoadFunctions

        private void LoadEmployee()
        {
            con.Open();
            cmd = new SqlCommand(@"SELECT EmployeeID,LastName,FirstName, MiddleInitial, ContactNumber, Email, Address,Username,Password,IsAdmin FROM Employee", con);
            rdr = cmd.ExecuteReader();

            int check;
            string scheck = "";


            while (rdr.Read())
            {

                if (rdr[9].ToString() != null)
                {
                    check = Convert.ToInt32(rdr[9].ToString());
                    if (check == 1)
                    {
                        scheck = "Yes";
                    }
                    else
                    {
                        scheck = "No";
                    }
                }

                dataEmployee.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(),
                    rdr[7].ToString(), rdr[8].ToString(), scheck);
            }

            con.Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            DisableUpdateButton();
        }
        #endregion

        #region Selection Changed Functions

        private void dataEmployee_SelectionChanged(object sender, EventArgs e)
        {
            EnableUpdateButton();
            if (dataEmployee.SelectedRows.Count != 0)
            {
                txtEmployeeID.Text =
                     dataEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text =
                     dataEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text =
                     dataEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtMiddleInitial.Text =
                     dataEmployee.SelectedRows[0].Cells[3].Value.ToString();
                txtContactNumber.Text =
                      dataEmployee.SelectedRows[0].Cells[4].Value.ToString();
                txtEmail.Text =
                     dataEmployee.SelectedRows[0].Cells[5].Value.ToString();
                txtEmployeeAddress.Text =
                     dataEmployee.SelectedRows[0].Cells[6].Value.ToString();
                txtUsername.Text =
                  dataEmployee.SelectedRows[0].Cells[7].Value.ToString();
                txtPassword.Text =
                     dataEmployee.SelectedRows[0].Cells[8].Value.ToString();

                if (dataEmployee.SelectedRows[0].Cells[9].Value.ToString() == "Yes")
                {
                    chkAdmin.Checked = true;
                }
                else
                {
                    chkAdmin.Checked = false;
                }
            }
        }
        #endregion
       
    }
}

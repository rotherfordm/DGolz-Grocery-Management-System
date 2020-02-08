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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void ClearTextbox()
        {
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSupplierName.Clear();
            txtSupplierID.Clear();
            DisableUpdateButton();

        }

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        #region Disable Update Buttons Function

        private void DisableUpdateButton()
        {
            btnADD.Enabled = true;
            btn_Update.Enabled = false;
        }

        private void EnableUpdateButton()
        {
            btnADD.Enabled = false;
            btn_Update.Enabled = true;
        }

        #endregion

        #region Checkdigit

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

        #region Load Functions

        private void Supplier_Load(object sender, EventArgs e)
        {
            DisableUpdateButton();
            LoadSupplier();
        }

        private void LoadSupplier()
        {

            con.Open();
            cmd = new SqlCommand(@"select SupplierID, CompanyName , ContactNumber,
            SupplierAddress, Email from Supplier", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataSupplier.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }

            con.Close();
        }

        #endregion

        #region Button Functions

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            FrmMain back = new FrmMain();
            back.Show();
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && txtSupplierID.Text != "")
            { 
                DialogResult DialogResult = MessageBox.Show("Are you sure you want to remove this?","Confrmation",MessageBoxButtons.YesNo);

                if (dataSupplier.SelectedRows.Count != 0 && DialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand(@" DELETE FROM Supplier
                where SupplierID = '" + txtSupplierID.Text + "' " +
                    "AND CompanyName = '" + txtSupplierName.Text + "' ", con);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Delete Sucessful", "Success");
                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("Removing Cancelled","Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input", "Invalid");

            }
            dataSupplier.Rows.Clear();
            LoadSupplier();
            ClearTextbox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && (txtContactNumber.Text == "" || isValidContactNumber(txtContactNumber.Text)))
            {
                DialogResult DialogResult = MessageBox.Show("Are you sure you want to update this?", "Confirmation", MessageBoxButtons.YesNo);
                if (dataSupplier.SelectedRows.Count != 0 && DialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand(@"update Supplier
                    set CompanyName = '" + txtSupplierName.Text + "', ContactNumber = '" + txtContactNumber.Text
                    + "',SupplierAddress ='" + txtAddress.Text + "',Email = '" + txtEmail.Text
                    + "' where SupplierID = '" + txtSupplierID.Text + "' ", con);

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
                MessageBox.Show("Invalid Input(s)", "Warning");
            }
            dataSupplier.Rows.Clear();
            LoadSupplier();
            ClearTextbox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && (txtContactNumber.Text == "" || isValidContactNumber(txtContactNumber.Text)))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this?", "Confirmation",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand(@"INSERT INTO Supplier
                (CompanyName, ContactNumber, SupplierAddress, Email)
                Values
                ('" + txtSupplierName.Text + "', '" + txtContactNumber.Text + "', '" + txtAddress.Text + "', '" + txtEmail.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Congrats, Addded!", "Congrats");
                    ClearTextbox();
                }

                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Adding Cancelled", "Cancelled");
                    ClearTextbox();
                }

            }
            else
            {
                ClearTextbox();
                MessageBox.Show("Invalid Input(s)", "Warning");
            }

            dataSupplier.Rows.Clear();
            LoadSupplier();
        }
        #endregion

        #region Selection Changed

        private void dataSupplier_SelectionChanged(object sender, EventArgs e)
        {

            if (dataSupplier.SelectedRows.Count != 0)
            {
                txtSupplierID.Text =
                     dataSupplier.SelectedRows[0].Cells[0].Value.ToString();
                txtSupplierName.Text =
                     dataSupplier.SelectedRows[0].Cells[1].Value.ToString();
                txtContactNumber.Text =
                     dataSupplier.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text =
                     dataSupplier.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text =
                      dataSupplier.SelectedRows[0].Cells[4].Value.ToString();
                EnableUpdateButton();
            }

        }


        #endregion


    }
}

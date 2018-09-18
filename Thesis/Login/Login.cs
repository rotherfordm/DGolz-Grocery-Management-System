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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region  Sql Connection Initialization

        //starts connection to sql server
        SqlConnection con = new SqlConnection
        (@"server =HEATZ\SQLEXPRESS; Initial Catalog =DGOLZMART2; Integrated Security = true;");
        SqlCommand cmd;
        SqlDataReader rdr;

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {

            #region Check If User Exist
            string SLogCheck = "";
            con.Open();
            cmd = new SqlCommand(@"(
            SELECT CASE WHEN EXISTS (
            SELECT * FROM Employee
            WHERE Username = '"+txtUsername.Text+"'  AND Password = '"+txtPassword.Text+"') " +
            " THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)", con);
            rdr = cmd.ExecuteReader();
            

            while (rdr.Read())
            {
                SLogCheck = rdr[0].ToString();
            }
            con.Close();

            #endregion

            if (SLogCheck == "True")
            {

                #region Check If Admin
                string IsAdmin = "";
                con.Open();
                cmd = new SqlCommand(@"(
                SELECT CASE WHEN EXISTS 
                (
                SELECT * FROM Employee
                Where Username = '"+txtUsername.Text+"' AND Password = '"+txtPassword.Text
                +"' AND IsAdmin = 1)  THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)", con);
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    IsAdmin = rdr[0].ToString();
                }
                con.Close();

                #endregion

                #region Return Name
                string Name = "";
                con.Open();
                cmd = new SqlCommand(@" 
                SELECT FirstName FROM Employee
                Where Username = '"+txtUsername.Text+"' AND Password = '"+txtPassword.Text+"' ", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Name = rdr[0].ToString();
                }
                con.Close();
                #endregion

                if (IsAdmin == "True")
                {
                    FrmMain main = new FrmMain();
                    this.Visible = false;
                    main.Show();
                    MessageBox.Show("Welcome, " + Name);
                }

                if (IsAdmin == "False")
                {
                    FrmCashier cashier = new FrmCashier();
                    this.Visible = false;
                    cashier.Show();
                    MessageBox.Show("Welcome, " + Name);
                }
            }

            if (SLogCheck != "True")
            {
                MessageBox.Show("Invalid Credentials", "Error");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}

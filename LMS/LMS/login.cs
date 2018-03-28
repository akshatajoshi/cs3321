using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace LMS
{
    public partial class login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonir\Desktop\LMS\LMS\lms.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
            passwordtextbox.UseSystemPasswordChar = true;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernametextbox.Text == string.Empty || passwordtextbox.Text == string.Empty || (usernametextbox.Text == string.Empty && passwordtextbox.Text == string.Empty))
            {
                errormessagelabel.Text = "Feilds cannot be left blank.";
                usernametextbox.Text = string.Empty;
                passwordtextbox.Text = string.Empty;
            } else
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student WHERE username ='" + usernametextbox.Text.Trim() + "' AND password ='" + passwordtextbox.Text + "'", connection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                if (datatable.Rows.Count == 0)
                {
                    errormessagelabel.Text = "Username or password is incorrect.";
                    usernametextbox.Text = string.Empty;
                    passwordtextbox.Text = string.Empty;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void passwordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordcheckbox.Checked)
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = true; 
            }
        }

        private void resetpasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new changepassword().Show();
        }
    }
}

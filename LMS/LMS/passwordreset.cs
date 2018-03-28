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
    public partial class changepassword : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonir\Desktop\LMS\LMS\lms.mdf;Integrated Security=True");
        public changepassword()
        {
            InitializeComponent();
            newpasswordtextbox.UseSystemPasswordChar = true;
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            //Check if usernametextbox.Text is a number*
            int n = 0;
            if (idtextbox.Text == string.Empty || newpasswordtextbox.Text == string.Empty || (idtextbox.Text == string.Empty && newpasswordtextbox.Text == string.Empty))
            {
                errormessagelabel.Text = "Feilds cannot be left blank.";
                idtextbox.Text = string.Empty;
                newpasswordtextbox.Text = string.Empty;
            }
            else if (int.TryParse(idtextbox.Text, out n))
            {
                errormessagelabel.Text = "Feilds cannot be left blank.";
                idtextbox.Text = string.Empty;
                newpasswordtextbox.Text = string.Empty;
            }
            else
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student WHERE sID ='" + idtextbox.Text.Trim() + "'", connection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                if (datatable.Rows.Count == 1)
                {
                    SqlCommand searchID = new SqlCommand("UPDATE student SET password = @p WHERE sID = @i", connection);
                    searchID.Parameters.Add("p", newpasswordtextbox.Text);
                    searchID.Parameters.Add("i", idtextbox.Text);
                    searchID.ExecuteNonQuery();
                    errormessagelabel.Text = "Password has been reset.";
                    Console.ReadLine();
                }
                else
                {
                    errormessagelabel.Text = "Username is incorrect.";
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void passwordcheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (passwordcheckbox.Checked)
            {
                newpasswordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                newpasswordtextbox.UseSystemPasswordChar = true;
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

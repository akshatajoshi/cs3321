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
    public partial class mainscreen : Form
    {
        private login name; 
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonir\Desktop\LMS\LMS\lms.mdf;Integrated Security=True");
        public mainscreen()
        {
            InitializeComponent();
            name = new login();
            connection.Open();
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new updateinformation().Show();
        }

        private void enrolledclassesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new courselist().Show();
        }

        private void gpabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new gpa().Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

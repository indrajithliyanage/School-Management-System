using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();
                string str = "SELECT uname FROM employee WHERE uname = '" + textBox1.Text + "' and pword = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    Dashboard obj2 = new Dashboard();
                    obj2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password.");
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register obj2 = new Register();
            obj2.ShowDialog();
        }
    }
}

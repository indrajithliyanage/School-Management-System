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
    public partial class SearchExam : Form
    {
        public SearchExam()
        {
            InitializeComponent();
        }

        private void SearchExam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Values for Both Fields!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql = "SELECT * FROM exam WHERE module_id='" + textBox1.Text + "' AND student_id='" + textBox2.Text +"';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label9.Text = dr.GetValue(0).ToString();
                        label10.Text = dr.GetValue(1).ToString();
                        label11.Text = dr.GetValue(2).ToString();
                        label12.Text = dr.GetValue(3).ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Values for Both Fields!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql = "DELETE FROM exam WHERE module_id='" + textBox1.Text + "' AND student_id='" + textBox2.Text + "';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Exam Data Deleted Successfully...");
                    }
                    else
                    {
                        MessageBox.Show("Could not delete!");
                    }
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

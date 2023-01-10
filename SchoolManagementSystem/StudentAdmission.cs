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
    public partial class StudentAdmission : Form
    {
        public StudentAdmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("All Fields must be filled!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql = "INSERT INTO student(first_name,last_name,birth_date,guardian_name,student_address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    String sql1 = "SELECT MAX(student_id) FROM student";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Student Data Inserted Successfully... Student ID: '" + dr.GetInt32(0) + "'");
                    }
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

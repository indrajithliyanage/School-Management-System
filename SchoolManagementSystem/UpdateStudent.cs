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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();

                String sql = "SELECT * FROM student WHERE student_id='" + textBox1.Text + "';";
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
                    label13.Text = dr.GetValue(4).ToString();
                    label14.Text = dr.GetValue(5).ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = label10.Text;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = label11.Text;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = label14.Text;
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Text = label13.Text;
            }
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Text = label12.Text;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();

                String sql = "UPDATE student SET first_name = '" + textBox2.Text + "',last_name = '" + textBox3.Text + "',birth_date = '" + textBox6.Text + "',guardian_name = '" + textBox4.Text + "',student_address = '" + textBox5.Text + "' WHERE student_id = '" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = cmd.ExecuteNonQuery();
                if (i>0)
                {
                    MessageBox.Show("Student Data Updated Successfully...");
                }
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

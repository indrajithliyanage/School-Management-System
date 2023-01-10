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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Teacher ID!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql = "SELECT * FROM teacher WHERE teacher_id='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label9.Text = dr.GetValue(0).ToString();
                        label10.Text = dr.GetValue(1).ToString();
                        label11.Text = dr.GetValue(2).ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = label10.Text;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = label11.Text;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();

                String sql = "UPDATE teacher SET teacher_name = '" + textBox2.Text + "',teacher_address = '" + textBox3.Text + "' WHERE teacher_id = '" + textBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(sql, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Teacher Data Updated Successfully...");
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

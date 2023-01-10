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
    public partial class StudentAgeCalc : Form
    {
        public StudentAgeCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                con.Open();

                String sql = "SELECT student_id,first_name,last_name,birth_date,dbo.student_age(birth_date) AS age FROM student WHERE student_id='" + textBox1.Text + "';";
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
  
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

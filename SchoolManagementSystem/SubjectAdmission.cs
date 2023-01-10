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
    public partial class SubjectAdmission : Form
    {
        public SubjectAdmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All Fields must be filled!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql = "INSERT INTO module(module_name,module_periods) VALUES('" + textBox1.Text + "','" + textBox2.Text + "');";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    String sql1 = "SELECT MAX(module_id) FROM module";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Module Data Inserted Successfully... Module ID: '" + dr.GetInt32(0) + "'");
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
            textBox2.Clear();
        }
    }
}

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
    public partial class SubjectAssign : Form
    {
        public SubjectAssign()
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
                    String sql1 = "INSERT INTO teacher_module(module_id,teacher_id,module_name,teacher_name) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    int i = cmd1.ExecuteNonQuery();
                    if (i>0)
                    {
                        MessageBox.Show("Subject Assigned Successfully...");
                    }
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All fields must be filled!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=sclmgtsys_db;Integrated Security=True;");
                    con.Open();

                    String sql2 = "SELECT teacher_name FROM teacher WHERE teacher_id='" + textBox1.Text + "';";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2;
                    dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        textBox4.Text = dr2.GetValue(0).ToString();
                    }
                    dr2.Close();
                    String sql3 = "SELECT module_name FROM module WHERE module_id='" + textBox2.Text + "';";
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3;
                    dr3 = cmd3.ExecuteReader();
                    if (dr3.Read())
                    {
                        textBox3.Text = dr3.GetValue(0).ToString();
                    }
                    con.Close();
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
            textBox3.Clear();
            textBox4.Clear();
        }

        private void SubjectAssign_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sclmgtsys_dbDataSet3.teacher_module' table. You can move, or remove it, as needed.
            this.teacher_moduleTableAdapter.Fill(this.sclmgtsys_dbDataSet3.teacher_module);

        }
    }
}

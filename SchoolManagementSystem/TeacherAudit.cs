using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TeacherAudit : Form
    {
        public TeacherAudit()
        {
            InitializeComponent();
        }

        private void TeacherAudit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sclmgtsys_dbDataSet1.teacher_audit' table. You can move, or remove it, as needed.
            this.teacher_auditTableAdapter.Fill(this.sclmgtsys_dbDataSet1.teacher_audit);

        }
    }
}

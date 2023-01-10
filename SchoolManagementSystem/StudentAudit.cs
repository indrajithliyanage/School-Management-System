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
    public partial class StudentAudit : Form
    {
        public StudentAudit()
        {
            InitializeComponent();
        }

        private void StudentAudit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sclmgtsys_dbDataSet.student_audit' table. You can move, or remove it, as needed.
            this.student_auditTableAdapter.Fill(this.sclmgtsys_dbDataSet.student_audit);

        }
    }
}

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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdmission obj1 = new StudentAdmission();
            obj1.ShowDialog();
        }

        private void teacherAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAdmission obj2 = new TeacherAdmission();
            obj2.ShowDialog();
        }

        private void subjectAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectAdmission obj3 = new SubjectAdmission();
            obj3.ShowDialog();
        }

        private void examAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamAdmission obj4 = new ExamAdmission();
            obj4.ShowDialog();
        }

        private void aboutSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchStudent obj5 = new SearchStudent();
            obj5.ShowDialog();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher obj6 = new SearchTeacher();
            obj6.ShowDialog();
        }

        private void searchModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSubject obj7 = new SearchSubject();
            obj7.ShowDialog();
        }

        private void searchExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchExam obj8 = new SearchExam();
            obj8.ShowDialog();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent obj9 = new UpdateStudent();
            obj9.ShowDialog();
        }

        private void updateTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTeacher obj10 = new UpdateTeacher();
            obj10.ShowDialog();
        }

        private void updateModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSubject obj11 = new UpdateSubject();
            obj11.ShowDialog();
        }

        private void studentAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAgeCalc obj12 = new StudentAgeCalc();
            obj12.ShowDialog();
        }

        private void studentAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAudit obj13 = new StudentAudit();
            obj13.ShowDialog();
        }

        private void teacherAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAudit obj14 = new TeacherAudit();
            obj14.ShowDialog();
        }

        private void examAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamAudit obj15 = new ExamAudit();
            obj15.ShowDialog();
        }

        private void updateExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateExam obj16 = new UpdateExam();
            obj16.ShowDialog();
        }

        private void assignSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectAssign obj17 = new SubjectAssign();
            obj17.ShowDialog();
        }
    }
}

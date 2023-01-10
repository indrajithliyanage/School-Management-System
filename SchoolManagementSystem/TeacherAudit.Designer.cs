
namespace SchoolManagementSystem
{
    partial class TeacherAudit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sclmgtsys_dbDataSet1 = new SchoolManagementSystem.sclmgtsys_dbDataSet1();
            this.teacher_auditTableAdapter = new SchoolManagementSystem.sclmgtsys_dbDataSet1TableAdapters.teacher_auditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherauditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(346, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Teacher Audit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changeidDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.teachernameDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherauditBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 229);
            this.dataGridView1.TabIndex = 25;
            // 
            // changeidDataGridViewTextBoxColumn
            // 
            this.changeidDataGridViewTextBoxColumn.DataPropertyName = "change_id";
            this.changeidDataGridViewTextBoxColumn.HeaderText = "change_id";
            this.changeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changeidDataGridViewTextBoxColumn.Name = "changeidDataGridViewTextBoxColumn";
            this.changeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.Width = 125;
            // 
            // teachernameDataGridViewTextBoxColumn
            // 
            this.teachernameDataGridViewTextBoxColumn.DataPropertyName = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.HeaderText = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            this.teachernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherauditBindingSource
            // 
            this.teacherauditBindingSource.DataMember = "teacher_audit";
            this.teacherauditBindingSource.DataSource = this.sclmgtsys_dbDataSet1;
            // 
            // sclmgtsys_dbDataSet1
            // 
            this.sclmgtsys_dbDataSet1.DataSetName = "sclmgtsys_dbDataSet1";
            this.sclmgtsys_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacher_auditTableAdapter
            // 
            this.teacher_auditTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 319);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherAudit";
            this.Load += new System.EventHandler(this.TeacherAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherauditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sclmgtsys_dbDataSet1 sclmgtsys_dbDataSet1;
        private System.Windows.Forms.BindingSource teacherauditBindingSource;
        private sclmgtsys_dbDataSet1TableAdapters.teacher_auditTableAdapter teacher_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
    }
}

namespace SchoolManagementSystem
{
    partial class StudentAudit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sclmgtsys_dbDataSet = new SchoolManagementSystem.sclmgtsys_dbDataSet();
            this.student_auditTableAdapter = new SchoolManagementSystem.sclmgtsys_dbDataSetTableAdapters.student_auditTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentauditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changeidDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.studentfnameDataGridViewTextBoxColumn,
            this.guardiannameDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentauditBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 229);
            this.dataGridView1.TabIndex = 0;
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
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentfnameDataGridViewTextBoxColumn
            // 
            this.studentfnameDataGridViewTextBoxColumn.DataPropertyName = "student_fname";
            this.studentfnameDataGridViewTextBoxColumn.HeaderText = "student_fname";
            this.studentfnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentfnameDataGridViewTextBoxColumn.Name = "studentfnameDataGridViewTextBoxColumn";
            this.studentfnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // guardiannameDataGridViewTextBoxColumn
            // 
            this.guardiannameDataGridViewTextBoxColumn.DataPropertyName = "guardian_name";
            this.guardiannameDataGridViewTextBoxColumn.HeaderText = "guardian_name";
            this.guardiannameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guardiannameDataGridViewTextBoxColumn.Name = "guardiannameDataGridViewTextBoxColumn";
            this.guardiannameDataGridViewTextBoxColumn.Width = 125;
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
            // studentauditBindingSource
            // 
            this.studentauditBindingSource.DataMember = "student_audit";
            this.studentauditBindingSource.DataSource = this.sclmgtsys_dbDataSet;
            // 
            // sclmgtsys_dbDataSet
            // 
            this.sclmgtsys_dbDataSet.DataSetName = "sclmgtsys_dbDataSet";
            this.sclmgtsys_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_auditTableAdapter
            // 
            this.student_auditTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(477, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Student Audit";
            // 
            // StudentAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 313);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAudit";
            this.Load += new System.EventHandler(this.StudentAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentauditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sclmgtsys_dbDataSet sclmgtsys_dbDataSet;
        private System.Windows.Forms.BindingSource studentauditBindingSource;
        private sclmgtsys_dbDataSetTableAdapters.student_auditTableAdapter student_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}
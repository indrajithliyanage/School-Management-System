
namespace SchoolManagementSystem
{
    partial class ExamAudit
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
            this.sclmgtsys_dbDataSet2 = new SchoolManagementSystem.sclmgtsys_dbDataSet2();
            this.examauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exam_auditTableAdapter = new SchoolManagementSystem.sclmgtsys_dbDataSet2TableAdapters.exam_auditTableAdapter();
            this.changeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionprfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examauditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(346, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Exam Audit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changeidDataGridViewTextBoxColumn,
            this.modulenameDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.actionprfDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examauditBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 229);
            this.dataGridView1.TabIndex = 27;
            // 
            // sclmgtsys_dbDataSet2
            // 
            this.sclmgtsys_dbDataSet2.DataSetName = "sclmgtsys_dbDataSet2";
            this.sclmgtsys_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examauditBindingSource
            // 
            this.examauditBindingSource.DataMember = "exam_audit";
            this.examauditBindingSource.DataSource = this.sclmgtsys_dbDataSet2;
            // 
            // exam_auditTableAdapter
            // 
            this.exam_auditTableAdapter.ClearBeforeFill = true;
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
            // modulenameDataGridViewTextBoxColumn
            // 
            this.modulenameDataGridViewTextBoxColumn.DataPropertyName = "module_name";
            this.modulenameDataGridViewTextBoxColumn.HeaderText = "module_name";
            this.modulenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modulenameDataGridViewTextBoxColumn.Name = "modulenameDataGridViewTextBoxColumn";
            this.modulenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // actionprfDataGridViewTextBoxColumn
            // 
            this.actionprfDataGridViewTextBoxColumn.DataPropertyName = "action_prf";
            this.actionprfDataGridViewTextBoxColumn.HeaderText = "action_prf";
            this.actionprfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actionprfDataGridViewTextBoxColumn.Name = "actionprfDataGridViewTextBoxColumn";
            this.actionprfDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExamAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 327);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExamAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamAudit";
            this.Load += new System.EventHandler(this.ExamAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclmgtsys_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examauditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sclmgtsys_dbDataSet2 sclmgtsys_dbDataSet2;
        private System.Windows.Forms.BindingSource examauditBindingSource;
        private sclmgtsys_dbDataSet2TableAdapters.exam_auditTableAdapter exam_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionprfDataGridViewTextBoxColumn;
    }
}
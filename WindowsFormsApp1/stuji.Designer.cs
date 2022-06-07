
namespace WindowsFormsApp1
{
    partial class stuji
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
            this.classDataSet = new WindowsFormsApp1.classDataSet();
            this.stujibenxinxiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stujibenxinxiTableAdapter = new WindowsFormsApp1.classDataSetTableAdapters.stujibenxinxiTableAdapter();
            this.stunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuxuehaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chushengdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stujibenxinxiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stunameDataGridViewTextBoxColumn,
            this.stuxuehaoDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.chushengdiDataGridViewTextBoxColumn,
            this.suseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stujibenxinxiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(799, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // classDataSet
            // 
            this.classDataSet.DataSetName = "classDataSet";
            this.classDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stujibenxinxiBindingSource
            // 
            this.stujibenxinxiBindingSource.DataMember = "stujibenxinxi";
            this.stujibenxinxiBindingSource.DataSource = this.classDataSet;
            // 
            // stujibenxinxiTableAdapter
            // 
            this.stujibenxinxiTableAdapter.ClearBeforeFill = true;
            // 
            // stunameDataGridViewTextBoxColumn
            // 
            this.stunameDataGridViewTextBoxColumn.DataPropertyName = "stuname";
            this.stunameDataGridViewTextBoxColumn.HeaderText = "stuname";
            this.stunameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stunameDataGridViewTextBoxColumn.Name = "stunameDataGridViewTextBoxColumn";
            this.stunameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stuxuehaoDataGridViewTextBoxColumn
            // 
            this.stuxuehaoDataGridViewTextBoxColumn.DataPropertyName = "stuxuehao";
            this.stuxuehaoDataGridViewTextBoxColumn.HeaderText = "stuxuehao";
            this.stuxuehaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stuxuehaoDataGridViewTextBoxColumn.Name = "stuxuehaoDataGridViewTextBoxColumn";
            this.stuxuehaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // chushengdiDataGridViewTextBoxColumn
            // 
            this.chushengdiDataGridViewTextBoxColumn.DataPropertyName = "chushengdi";
            this.chushengdiDataGridViewTextBoxColumn.HeaderText = "chushengdi";
            this.chushengdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chushengdiDataGridViewTextBoxColumn.Name = "chushengdiDataGridViewTextBoxColumn";
            this.chushengdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // suseDataGridViewTextBoxColumn
            // 
            this.suseDataGridViewTextBoxColumn.DataPropertyName = "suse";
            this.suseDataGridViewTextBoxColumn.HeaderText = "suse";
            this.suseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suseDataGridViewTextBoxColumn.Name = "suseDataGridViewTextBoxColumn";
            this.suseDataGridViewTextBoxColumn.Width = 125;
            // 
            // stuji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stuji";
            this.Text = "stuji";
            this.Load += new System.EventHandler(this.stuji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stujibenxinxiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private classDataSet classDataSet;
        private System.Windows.Forms.BindingSource stujibenxinxiBindingSource;
        private classDataSetTableAdapters.stujibenxinxiTableAdapter stujibenxinxiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuxuehaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chushengdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suseDataGridViewTextBoxColumn;
    }
}
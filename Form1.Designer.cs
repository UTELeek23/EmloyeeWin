namespace EmloyeeWin
{
    partial class Form1
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
            this.ID_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.Name_lable = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Dept_Text = new System.Windows.Forms.TextBox();
            this.Dept_lable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vmDataSet = new EmloyeeWin.VmDataSet();
            this.emloyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloyeeTableAdapter = new EmloyeeWin.VmDataSetTableAdapters.EmloyeeTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_text = new System.Windows.Forms.TextBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ID_Label.Location = new System.Drawing.Point(20, 51);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(36, 29);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dept_lable);
            this.groupBox1.Controls.Add(this.Dept_Text);
            this.groupBox1.Controls.Add(this.Name_Text);
            this.groupBox1.Controls.Add(this.Name_lable);
            this.groupBox1.Controls.Add(this.ID_Text);
            this.groupBox1.Controls.Add(this.ID_Label);
            this.groupBox1.Location = new System.Drawing.Point(47, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(96, 51);
            this.ID_Text.Multiline = true;
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(484, 40);
            this.ID_Text.TabIndex = 1;
            // 
            // Name_lable
            // 
            this.Name_lable.AutoSize = true;
            this.Name_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name_lable.Location = new System.Drawing.Point(20, 129);
            this.Name_lable.Name = "Name_lable";
            this.Name_lable.Size = new System.Drawing.Size(78, 29);
            this.Name_lable.TabIndex = 2;
            this.Name_lable.Text = "Name";
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(96, 118);
            this.Name_Text.Multiline = true;
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(484, 40);
            this.Name_Text.TabIndex = 3;
            // 
            // Dept_Text
            // 
            this.Dept_Text.Location = new System.Drawing.Point(96, 202);
            this.Dept_Text.Multiline = true;
            this.Dept_Text.Name = "Dept_Text";
            this.Dept_Text.Size = new System.Drawing.Size(484, 40);
            this.Dept_Text.TabIndex = 4;
            // 
            // Dept_lable
            // 
            this.Dept_lable.AutoSize = true;
            this.Dept_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dept_lable.Location = new System.Drawing.Point(20, 213);
            this.Dept_lable.Name = "Dept_lable";
            this.Dept_lable.Size = new System.Drawing.Size(64, 29);
            this.Dept_lable.TabIndex = 5;
            this.Dept_lable.Text = "Dept";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emloyeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 612);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(701, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // vmDataSet
            // 
            this.vmDataSet.DataSetName = "VmDataSet";
            this.vmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emloyeeBindingSource
            // 
            this.emloyeeBindingSource.DataMember = "Emloyee";
            this.emloyeeBindingSource.DataSource = this.vmDataSet;
            // 
            // emloyeeTableAdapter
            // 
            this.emloyeeTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(47, 401);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(118, 45);
            this.Save_button.TabIndex = 3;
            this.Save_button.Text = "SAVE";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_buttuon_click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(339, 401);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(118, 45);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "EDIT";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(630, 401);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(118, 45);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find";
            // 
            // Find_text
            // 
            this.Find_text.Location = new System.Drawing.Point(143, 477);
            this.Find_text.Multiline = true;
            this.Find_text.Name = "Find_text";
            this.Find_text.Size = new System.Drawing.Size(484, 40);
            this.Find_text.TabIndex = 6;
            // 
            // Find_button
            // 
            this.Find_button.Location = new System.Drawing.Point(47, 545);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(118, 45);
            this.Find_button.TabIndex = 7;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 861);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Find_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "22162016_Lê Anh Khoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloyeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Dept_lable;
        private System.Windows.Forms.TextBox Dept_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label Name_lable;
        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VmDataSet vmDataSet;
        private System.Windows.Forms.BindingSource emloyeeBindingSource;
        private VmDataSetTableAdapters.EmloyeeTableAdapter emloyeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Find_text;
        private System.Windows.Forms.Button Find_button;
    }
}


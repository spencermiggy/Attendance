namespace Attendance
{
    partial class TimeIns
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Attendance.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceTBLTableAdapter = new Attendance.DataSet1TableAdapters.AttendanceTBLTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.lnDataGridViewTextBoxColumn,
            this.timinDataGridViewTextBoxColumn,
            this.datinDataGridViewTextBoxColumn,
            this.courDataGridViewTextBoxColumn,
            this.yrDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceTBLBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(37, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(730, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "LOGIN ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnDataGridViewTextBoxColumn
            // 
            this.fnDataGridViewTextBoxColumn.DataPropertyName = "fn";
            this.fnDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fnDataGridViewTextBoxColumn.Name = "fnDataGridViewTextBoxColumn";
            this.fnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "MIDDLENAME";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnDataGridViewTextBoxColumn
            // 
            this.lnDataGridViewTextBoxColumn.DataPropertyName = "ln";
            this.lnDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lnDataGridViewTextBoxColumn.Name = "lnDataGridViewTextBoxColumn";
            this.lnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timinDataGridViewTextBoxColumn
            // 
            this.timinDataGridViewTextBoxColumn.DataPropertyName = "timin";
            this.timinDataGridViewTextBoxColumn.HeaderText = "TIME IN";
            this.timinDataGridViewTextBoxColumn.Name = "timinDataGridViewTextBoxColumn";
            this.timinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datinDataGridViewTextBoxColumn
            // 
            this.datinDataGridViewTextBoxColumn.DataPropertyName = "datin";
            this.datinDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.datinDataGridViewTextBoxColumn.Name = "datinDataGridViewTextBoxColumn";
            this.datinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courDataGridViewTextBoxColumn
            // 
            this.courDataGridViewTextBoxColumn.DataPropertyName = "cour";
            this.courDataGridViewTextBoxColumn.HeaderText = "SECTION";
            this.courDataGridViewTextBoxColumn.Name = "courDataGridViewTextBoxColumn";
            this.courDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yrDataGridViewTextBoxColumn
            // 
            this.yrDataGridViewTextBoxColumn.DataPropertyName = "yr";
            this.yrDataGridViewTextBoxColumn.HeaderText = "GRADE LEVEL";
            this.yrDataGridViewTextBoxColumn.Name = "yrDataGridViewTextBoxColumn";
            this.yrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "SCHOOL ID";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceTBLBindingSource
            // 
            this.attendanceTBLBindingSource.DataMember = "AttendanceTBL";
            this.attendanceTBLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(37, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(692, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(494, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN ID:";
            // 
            // attendanceTBLTableAdapter
            // 
            this.attendanceTBLTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(431, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "SEARCH HERE:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(564, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 35);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TimeIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TimeIns";
            this.Size = new System.Drawing.Size(804, 380);
            this.Load += new System.EventHandler(this.TimeIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource attendanceTBLBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AttendanceTBLTableAdapter attendanceTBLTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

﻿namespace Attendance
{
    partial class TimeOuts
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceTBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Attendance.DataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attendanceTBLLTableAdapter = new Attendance.DataSet1TableAdapters.AttendanceTBLLTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new CustomControls.RJControls.RJTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTBLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fnDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.lnDataGridViewTextBoxColumn,
            this.timinDataGridViewTextBoxColumn,
            this.datinDataGridViewTextBoxColumn,
            this.courDataGridViewTextBoxColumn,
            this.yrDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceTBLLBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.Location = new System.Drawing.Point(37, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(730, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "LOGOUT ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 91;
            // 
            // fnDataGridViewTextBoxColumn
            // 
            this.fnDataGridViewTextBoxColumn.DataPropertyName = "fn";
            this.fnDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fnDataGridViewTextBoxColumn.Name = "fnDataGridViewTextBoxColumn";
            this.fnDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnDataGridViewTextBoxColumn.Width = 94;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "MIDDLENAME";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 104;
            // 
            // lnDataGridViewTextBoxColumn
            // 
            this.lnDataGridViewTextBoxColumn.DataPropertyName = "ln";
            this.lnDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lnDataGridViewTextBoxColumn.Name = "lnDataGridViewTextBoxColumn";
            this.lnDataGridViewTextBoxColumn.ReadOnly = true;
            this.lnDataGridViewTextBoxColumn.Width = 90;
            // 
            // timinDataGridViewTextBoxColumn
            // 
            this.timinDataGridViewTextBoxColumn.DataPropertyName = "timin";
            this.timinDataGridViewTextBoxColumn.HeaderText = "TIME OUT";
            this.timinDataGridViewTextBoxColumn.Name = "timinDataGridViewTextBoxColumn";
            this.timinDataGridViewTextBoxColumn.ReadOnly = true;
            this.timinDataGridViewTextBoxColumn.Width = 84;
            // 
            // datinDataGridViewTextBoxColumn
            // 
            this.datinDataGridViewTextBoxColumn.DataPropertyName = "datin";
            this.datinDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.datinDataGridViewTextBoxColumn.Name = "datinDataGridViewTextBoxColumn";
            this.datinDataGridViewTextBoxColumn.ReadOnly = true;
            this.datinDataGridViewTextBoxColumn.Width = 61;
            // 
            // courDataGridViewTextBoxColumn
            // 
            this.courDataGridViewTextBoxColumn.DataPropertyName = "cour";
            this.courDataGridViewTextBoxColumn.HeaderText = "COURSE";
            this.courDataGridViewTextBoxColumn.Name = "courDataGridViewTextBoxColumn";
            this.courDataGridViewTextBoxColumn.ReadOnly = true;
            this.courDataGridViewTextBoxColumn.Width = 77;
            // 
            // yrDataGridViewTextBoxColumn
            // 
            this.yrDataGridViewTextBoxColumn.DataPropertyName = "yr";
            this.yrDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yrDataGridViewTextBoxColumn.Name = "yrDataGridViewTextBoxColumn";
            this.yrDataGridViewTextBoxColumn.ReadOnly = true;
            this.yrDataGridViewTextBoxColumn.Width = 61;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "SCHOOL ID";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Width = 90;
            // 
            // attendanceTBLLBindingSource
            // 
            this.attendanceTBLLBindingSource.DataMember = "AttendanceTBLL";
            this.attendanceTBLLBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(564, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 35);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(432, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "SEARCH HERE:";
            // 
            // attendanceTBLLTableAdapter
            // 
            this.attendanceTBLLTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox1.BorderRadius = 15;
            this.textBox1.BorderSize = 2;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(526, 337);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox1.PasswordChar = false;
            this.textBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.textBox1.PlaceholderText = "LOGOUT ID";
            this.textBox1.Size = new System.Drawing.Size(172, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.Texts = "";
            this.textBox1.UnderlinedStyle = false;
            this.textBox1._TextChanged += new System.EventHandler(this.textBox1__TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Attendance.Properties.Resources.switch_on_48px;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Aquamarine;
            this.button5.Location = new System.Drawing.Point(462, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 42);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Attendance.Properties.Resources.switch_on_24px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Aquamarine;
            this.button4.Location = new System.Drawing.Point(468, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 39);
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Aquamarine;
            this.button3.Image = global::Attendance.Properties.Resources.wastebasket_50px;
            this.button3.Location = new System.Drawing.Point(698, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 45);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Aquamarine;
            this.button2.Image = global::Attendance.Properties.Resources.wastebasket_50px;
            this.button2.Location = new System.Drawing.Point(697, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 45);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Aquamarine;
            this.button1.Image = global::Attendance.Properties.Resources.counterclockwise_arrows_50px;
            this.button1.Location = new System.Drawing.Point(42, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TimeOuts";
            this.Size = new System.Drawing.Size(804, 380);
            this.Load += new System.EventHandler(this.TimeOuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTBLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource attendanceTBLLBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.AttendanceTBLLTableAdapter attendanceTBLLTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private CustomControls.RJControls.RJTextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

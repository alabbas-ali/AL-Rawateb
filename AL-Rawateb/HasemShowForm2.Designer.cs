namespace AL_Rawateb
{
    partial class HasemShowForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasemShowForm2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarysDS = new AL_Rawateb.SalarysDS();
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zatiDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sehaDataGridViewTextBoxColumn,
            this.ejazaDataGridViewTextBoxColumn,
            this.okobaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salarysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // zatiDataGridViewTextBoxColumn
            // 
            this.zatiDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.zatiDataGridViewTextBoxColumn.HeaderText = "الرقم الذاتي";
            this.zatiDataGridViewTextBoxColumn.Name = "zatiDataGridViewTextBoxColumn";
            this.zatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "الإسم الثلاثي";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sehaDataGridViewTextBoxColumn
            // 
            this.sehaDataGridViewTextBoxColumn.DataPropertyName = "seha";
            this.sehaDataGridViewTextBoxColumn.HeaderText = "صحة";
            this.sehaDataGridViewTextBoxColumn.Name = "sehaDataGridViewTextBoxColumn";
            this.sehaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ejazaDataGridViewTextBoxColumn
            // 
            this.ejazaDataGridViewTextBoxColumn.DataPropertyName = "ejaza";
            this.ejazaDataGridViewTextBoxColumn.HeaderText = "بلا راتب";
            this.ejazaDataGridViewTextBoxColumn.Name = "ejazaDataGridViewTextBoxColumn";
            this.ejazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okobaDataGridViewTextBoxColumn
            // 
            this.okobaDataGridViewTextBoxColumn.DataPropertyName = "okoba";
            this.okobaDataGridViewTextBoxColumn.HeaderText = "عقوبة";
            this.okobaDataGridViewTextBoxColumn.Name = "okobaDataGridViewTextBoxColumn";
            this.okobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarysBindingSource
            // 
            this.salarysBindingSource.DataMember = "salarys";
            this.salarysBindingSource.DataSource = this.salarysDS;
            // 
            // salarysDS
            // 
            this.salarysDS.DataSetName = "SalarysDS";
            this.salarysDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salarysTableAdapter
            // 
            this.salarysTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(4, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(78, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(54, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "العقود";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(65, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "المكلفين";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(69, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(63, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "المثبتين";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(83, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "خاص";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(79, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "صراف";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "لتاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // HasemShowForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HasemShowForm2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول حسميات الغيابات";
            this.Load += new System.EventHandler(this.HasemShowForm2_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HasemShowForm2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalarysDS salarysDS;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace AL_Rawateb
{
    partial class NakabtOmalForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarycutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omalentfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omaleshtrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkafolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mosaedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdamonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarysDS = new AL_Rawateb.SalarysDS();
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 36);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "لتاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zatiDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.salarycutDataGridViewTextBoxColumn,
            this.omalentfaDataGridViewTextBoxColumn,
            this.omaleshtrakDataGridViewTextBoxColumn,
            this.tkafolDataGridViewTextBoxColumn,
            this.mosaedaDataGridViewTextBoxColumn,
            this.tdamonDataGridViewTextBoxColumn,
            this.omalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salarysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(774, 460);
            this.dataGridView1.TabIndex = 7;
            // 
            // zatiDataGridViewTextBoxColumn
            // 
            this.zatiDataGridViewTextBoxColumn.DataPropertyName = "zati";
            this.zatiDataGridViewTextBoxColumn.HeaderText = "الرقم الذاتي";
            this.zatiDataGridViewTextBoxColumn.Name = "zatiDataGridViewTextBoxColumn";
            this.zatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.zatiDataGridViewTextBoxColumn.Width = 88;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "الإسم الثلاثي";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 96;
            // 
            // salarycutDataGridViewTextBoxColumn
            // 
            this.salarycutDataGridViewTextBoxColumn.DataPropertyName = "salarycut";
            this.salarycutDataGridViewTextBoxColumn.HeaderText = "المقطوع";
            this.salarycutDataGridViewTextBoxColumn.Name = "salarycutDataGridViewTextBoxColumn";
            this.salarycutDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarycutDataGridViewTextBoxColumn.Width = 71;
            // 
            // omalentfaDataGridViewTextBoxColumn
            // 
            this.omalentfaDataGridViewTextBoxColumn.DataPropertyName = "omalentfa";
            this.omalentfaDataGridViewTextBoxColumn.HeaderText = "انتفاع";
            this.omalentfaDataGridViewTextBoxColumn.Name = "omalentfaDataGridViewTextBoxColumn";
            this.omalentfaDataGridViewTextBoxColumn.ReadOnly = true;
            this.omalentfaDataGridViewTextBoxColumn.Width = 58;
            // 
            // omaleshtrakDataGridViewTextBoxColumn
            // 
            this.omaleshtrakDataGridViewTextBoxColumn.DataPropertyName = "omaleshtrak";
            this.omaleshtrakDataGridViewTextBoxColumn.HeaderText = "اشتراك";
            this.omaleshtrakDataGridViewTextBoxColumn.Name = "omaleshtrakDataGridViewTextBoxColumn";
            this.omaleshtrakDataGridViewTextBoxColumn.ReadOnly = true;
            this.omaleshtrakDataGridViewTextBoxColumn.Width = 66;
            // 
            // tkafolDataGridViewTextBoxColumn
            // 
            this.tkafolDataGridViewTextBoxColumn.DataPropertyName = "tkafol";
            this.tkafolDataGridViewTextBoxColumn.HeaderText = "تكافل";
            this.tkafolDataGridViewTextBoxColumn.Name = "tkafolDataGridViewTextBoxColumn";
            this.tkafolDataGridViewTextBoxColumn.ReadOnly = true;
            this.tkafolDataGridViewTextBoxColumn.Width = 57;
            // 
            // mosaedaDataGridViewTextBoxColumn
            // 
            this.mosaedaDataGridViewTextBoxColumn.DataPropertyName = "mosaeda";
            this.mosaedaDataGridViewTextBoxColumn.HeaderText = "ص المساعدة";
            this.mosaedaDataGridViewTextBoxColumn.Name = "mosaedaDataGridViewTextBoxColumn";
            this.mosaedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mosaedaDataGridViewTextBoxColumn.Width = 94;
            // 
            // tdamonDataGridViewTextBoxColumn
            // 
            this.tdamonDataGridViewTextBoxColumn.DataPropertyName = "tdamon";
            this.tdamonDataGridViewTextBoxColumn.HeaderText = "ص تضامن";
            this.tdamonDataGridViewTextBoxColumn.Name = "tdamonDataGridViewTextBoxColumn";
            this.tdamonDataGridViewTextBoxColumn.ReadOnly = true;
            this.tdamonDataGridViewTextBoxColumn.Width = 77;
            // 
            // omalDataGridViewTextBoxColumn
            // 
            this.omalDataGridViewTextBoxColumn.DataPropertyName = "omal";
            this.omalDataGridViewTextBoxColumn.HeaderText = "المجموع";
            this.omalDataGridViewTextBoxColumn.Name = "omalDataGridViewTextBoxColumn";
            this.omalDataGridViewTextBoxColumn.ReadOnly = true;
            this.omalDataGridViewTextBoxColumn.Width = 71;
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
            // NakabtOmalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NakabtOmalForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول نقابة العمال";
            this.Load += new System.EventHandler(this.NakabtOmalForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NakabtOmalForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SalarysDS salarysDS;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omalentfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omaleshtrakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkafolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mosaedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdamonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omalDataGridViewTextBoxColumn;
    }
}
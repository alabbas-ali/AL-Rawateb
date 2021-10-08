namespace AL_Rawateb
{
    partial class TawedShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TawedShowForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarycutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nesptektsasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ektesasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darepaektesasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakabtmohandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarysDS = new AL_Rawateb.SalarysDS();
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "طباعة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "جدول تعويض طبيعة العمل",
            "جدول تعويض الإختصاص",
            "جدول تعويض المسؤولية"});
            this.cbtype.Location = new System.Drawing.Point(293, 16);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(179, 21);
            this.cbtype.TabIndex = 6;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "لتاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "النوع";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbtype);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            this.dataGridViewTextBoxColumn2,
            this.salarycutDataGridViewTextBoxColumn,
            this.nesptektsasDataGridViewTextBoxColumn,
            this.ektesasDataGridViewTextBoxColumn,
            this.darepaektesasDataGridViewTextBoxColumn,
            this.nakabtmohandsDataGridViewTextBoxColumn,
            this.lastsalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salarysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 480);
            this.dataGridView1.TabIndex = 10;
            // 
            // zatiDataGridViewTextBoxColumn
            // 
            this.zatiDataGridViewTextBoxColumn.DataPropertyName = "zati";
            this.zatiDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.zatiDataGridViewTextBoxColumn.Name = "zatiDataGridViewTextBoxColumn";
            this.zatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.zatiDataGridViewTextBoxColumn.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "الإسم الثلاثي";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // salarycutDataGridViewTextBoxColumn
            // 
            this.salarycutDataGridViewTextBoxColumn.DataPropertyName = "salarycut";
            this.salarycutDataGridViewTextBoxColumn.HeaderText = "المقطوع";
            this.salarycutDataGridViewTextBoxColumn.Name = "salarycutDataGridViewTextBoxColumn";
            this.salarycutDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarycutDataGridViewTextBoxColumn.Width = 71;
            // 
            // nesptektsasDataGridViewTextBoxColumn
            // 
            this.nesptektsasDataGridViewTextBoxColumn.HeaderText = "النسبة";
            this.nesptektsasDataGridViewTextBoxColumn.Name = "nesptektsasDataGridViewTextBoxColumn";
            this.nesptektsasDataGridViewTextBoxColumn.ReadOnly = true;
            this.nesptektsasDataGridViewTextBoxColumn.Width = 64;
            // 
            // ektesasDataGridViewTextBoxColumn
            // 
            this.ektesasDataGridViewTextBoxColumn.DataPropertyName = "ektesas";
            this.ektesasDataGridViewTextBoxColumn.HeaderText = "الإستحقاق";
            this.ektesasDataGridViewTextBoxColumn.Name = "ektesasDataGridViewTextBoxColumn";
            this.ektesasDataGridViewTextBoxColumn.ReadOnly = true;
            this.ektesasDataGridViewTextBoxColumn.Width = 83;
            // 
            // darepaektesasDataGridViewTextBoxColumn
            // 
            this.darepaektesasDataGridViewTextBoxColumn.DataPropertyName = "darepaektesas";
            this.darepaektesasDataGridViewTextBoxColumn.HeaderText = "الظريبة";
            this.darepaektesasDataGridViewTextBoxColumn.Name = "darepaektesasDataGridViewTextBoxColumn";
            this.darepaektesasDataGridViewTextBoxColumn.ReadOnly = true;
            this.darepaektesasDataGridViewTextBoxColumn.Width = 64;
            // 
            // nakabtmohandsDataGridViewTextBoxColumn
            // 
            this.nakabtmohandsDataGridViewTextBoxColumn.DataPropertyName = "nakabtmohands";
            this.nakabtmohandsDataGridViewTextBoxColumn.HeaderText = "ن مهندس";
            this.nakabtmohandsDataGridViewTextBoxColumn.Name = "nakabtmohandsDataGridViewTextBoxColumn";
            this.nakabtmohandsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nakabtmohandsDataGridViewTextBoxColumn.Width = 77;
            // 
            // lastsalaryDataGridViewTextBoxColumn
            // 
            this.lastsalaryDataGridViewTextBoxColumn.DataPropertyName = "lastsalary";
            this.lastsalaryDataGridViewTextBoxColumn.HeaderText = "الصافي";
            this.lastsalaryDataGridViewTextBoxColumn.Name = "lastsalaryDataGridViewTextBoxColumn";
            this.lastsalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastsalaryDataGridViewTextBoxColumn.Width = 66;
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
            // TawedShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TawedShowForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جداول التعويضات";
            this.Load += new System.EventHandler(this.TabeaAmalShowForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TabeaAmalShowForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbtype;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nespaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esthkakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darepaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mohandesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SalarysDS salarysDS;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nesptektsasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ektesasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darepaektesasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakabtmohandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastsalaryDataGridViewTextBoxColumn;
    }
}
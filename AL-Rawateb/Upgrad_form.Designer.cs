namespace AL_Rawateb
{
    partial class Upgrad_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upgrad_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldcutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newcutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forokatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dareptdakelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mohandesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeraeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ektsasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabeatamlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upGratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upGreatDS = new AL_Rawateb.UpGreatDS();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.upGratTableAdapter = new AL_Rawateb.UpGreatDSTableAdapters.UpGratTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGreatDS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ترفيع العاملين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "تريخ الترفيعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "نسبة الترفيعة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ترفيع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "عدد الأشهر لحساب الفروقات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zatiDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.oldcutDataGridViewTextBoxColumn,
            this.newcutDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.forokatDataGridViewTextBoxColumn,
            this.tamenDataGridViewTextBoxColumn,
            this.dareptdakelDataGridViewTextBoxColumn,
            this.omalDataGridViewTextBoxColumn,
            this.mohandesDataGridViewTextBoxColumn,
            this.zeraeeDataGridViewTextBoxColumn,
            this.ektsasDataGridViewTextBoxColumn,
            this.tabeatamlDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.upGratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 364);
            this.dataGridView1.TabIndex = 1;
            // 
            // zatiDataGridViewTextBoxColumn
            // 
            this.zatiDataGridViewTextBoxColumn.DataPropertyName = "zati";
            this.zatiDataGridViewTextBoxColumn.HeaderText = "الرقم الذاتي";
            this.zatiDataGridViewTextBoxColumn.Name = "zatiDataGridViewTextBoxColumn";
            this.zatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.zatiDataGridViewTextBoxColumn.Width = 81;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "الإسم الثلاثي";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 88;
            // 
            // oldcutDataGridViewTextBoxColumn
            // 
            this.oldcutDataGridViewTextBoxColumn.DataPropertyName = "oldcut";
            this.oldcutDataGridViewTextBoxColumn.HeaderText = "المقطوع القديم";
            this.oldcutDataGridViewTextBoxColumn.Name = "oldcutDataGridViewTextBoxColumn";
            this.oldcutDataGridViewTextBoxColumn.ReadOnly = true;
            this.oldcutDataGridViewTextBoxColumn.Width = 95;
            // 
            // newcutDataGridViewTextBoxColumn
            // 
            this.newcutDataGridViewTextBoxColumn.DataPropertyName = "newcut";
            this.newcutDataGridViewTextBoxColumn.HeaderText = "المقطوع الجديد";
            this.newcutDataGridViewTextBoxColumn.Name = "newcutDataGridViewTextBoxColumn";
            this.newcutDataGridViewTextBoxColumn.ReadOnly = true;
            this.newcutDataGridViewTextBoxColumn.Width = 94;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "عدد أشهر الفروقات";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Width = 110;
            // 
            // forokatDataGridViewTextBoxColumn
            // 
            this.forokatDataGridViewTextBoxColumn.DataPropertyName = "forokat";
            this.forokatDataGridViewTextBoxColumn.HeaderText = "الفروقات";
            this.forokatDataGridViewTextBoxColumn.Name = "forokatDataGridViewTextBoxColumn";
            this.forokatDataGridViewTextBoxColumn.ReadOnly = true;
            this.forokatDataGridViewTextBoxColumn.Width = 71;
            // 
            // tamenDataGridViewTextBoxColumn
            // 
            this.tamenDataGridViewTextBoxColumn.DataPropertyName = "tamen";
            this.tamenDataGridViewTextBoxColumn.HeaderText = "تأمينات";
            this.tamenDataGridViewTextBoxColumn.Name = "tamenDataGridViewTextBoxColumn";
            this.tamenDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamenDataGridViewTextBoxColumn.Width = 64;
            // 
            // dareptdakelDataGridViewTextBoxColumn
            // 
            this.dareptdakelDataGridViewTextBoxColumn.DataPropertyName = "dareptdakel";
            this.dareptdakelDataGridViewTextBoxColumn.HeaderText = "ضريبة دخل";
            this.dareptdakelDataGridViewTextBoxColumn.Name = "dareptdakelDataGridViewTextBoxColumn";
            this.dareptdakelDataGridViewTextBoxColumn.ReadOnly = true;
            this.dareptdakelDataGridViewTextBoxColumn.Width = 76;
            // 
            // omalDataGridViewTextBoxColumn
            // 
            this.omalDataGridViewTextBoxColumn.DataPropertyName = "omal";
            this.omalDataGridViewTextBoxColumn.HeaderText = "ن عمال";
            this.omalDataGridViewTextBoxColumn.Name = "omalDataGridViewTextBoxColumn";
            this.omalDataGridViewTextBoxColumn.ReadOnly = true;
            this.omalDataGridViewTextBoxColumn.Width = 61;
            // 
            // mohandesDataGridViewTextBoxColumn
            // 
            this.mohandesDataGridViewTextBoxColumn.DataPropertyName = "mohandes";
            this.mohandesDataGridViewTextBoxColumn.HeaderText = "ن مهندس";
            this.mohandesDataGridViewTextBoxColumn.Name = "mohandesDataGridViewTextBoxColumn";
            this.mohandesDataGridViewTextBoxColumn.ReadOnly = true;
            this.mohandesDataGridViewTextBoxColumn.Width = 71;
            // 
            // zeraeeDataGridViewTextBoxColumn
            // 
            this.zeraeeDataGridViewTextBoxColumn.DataPropertyName = "zeraee";
            this.zeraeeDataGridViewTextBoxColumn.HeaderText = "ن زراعي";
            this.zeraeeDataGridViewTextBoxColumn.Name = "zeraeeDataGridViewTextBoxColumn";
            this.zeraeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.zeraeeDataGridViewTextBoxColumn.Width = 66;
            // 
            // ektsasDataGridViewTextBoxColumn
            // 
            this.ektsasDataGridViewTextBoxColumn.DataPropertyName = "ektsas";
            this.ektsasDataGridViewTextBoxColumn.HeaderText = "اختصاص";
            this.ektsasDataGridViewTextBoxColumn.Name = "ektsasDataGridViewTextBoxColumn";
            this.ektsasDataGridViewTextBoxColumn.ReadOnly = true;
            this.ektsasDataGridViewTextBoxColumn.Width = 71;
            // 
            // tabeatamlDataGridViewTextBoxColumn
            // 
            this.tabeatamlDataGridViewTextBoxColumn.DataPropertyName = "tabeataml";
            this.tabeatamlDataGridViewTextBoxColumn.HeaderText = "طيبعة عمل";
            this.tabeatamlDataGridViewTextBoxColumn.Name = "tabeatamlDataGridViewTextBoxColumn";
            this.tabeatamlDataGridViewTextBoxColumn.ReadOnly = true;
            this.tabeatamlDataGridViewTextBoxColumn.Width = 78;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "الصافي";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 66;
            // 
            // upGratBindingSource
            // 
            this.upGratBindingSource.DataMember = "UpGrat";
            this.upGratBindingSource.DataSource = this.upGreatDS;
            // 
            // upGreatDS
            // 
            this.upGreatDS.DataSetName = "UpGreatDS";
            this.upGreatDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(2, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 37);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "طباعة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "عرض ترفيعة تاريخ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(164, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 0;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // upGratTableAdapter
            // 
            this.upGratTableAdapter.ClearBeforeFill = true;
            // 
            // Upgrad_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Upgrad_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الترفيعات";
            this.Load += new System.EventHandler(this.Upgrad_form_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upgrad_form_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGreatDS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private UpGreatDS upGreatDS;
        private System.Windows.Forms.BindingSource upGratBindingSource;
        private AL_Rawateb.UpGreatDSTableAdapters.UpGratTableAdapter upGratTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldcutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newcutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forokatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dareptdakelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mohandesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeraeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ektsasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabeatamlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;

    }
}
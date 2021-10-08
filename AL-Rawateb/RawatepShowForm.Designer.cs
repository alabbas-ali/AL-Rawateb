namespace AL_Rawateb
{
    partial class RawatepShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawatepShowForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.PrintButton = new System.Windows.Forms.Button();
            this.cbox6 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarycutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forokattawedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savinguser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingejtma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darepadakelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sakanomaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabeamaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabeaamaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forokathasmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakabtmohandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nakabazeraeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kedmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalkaredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalaksatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherhasemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarysDS = new AL_Rawateb.SalarysDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.zatiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 36);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "جدول الرواتب الخاص";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "جدول رواتب الصراف";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(292, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 37);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "مصرف";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(89, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "جدول الرواتب";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(909, 9);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(100, 28);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "طباعة";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // cbox6
            // 
            this.cbox6.FormattingEnabled = true;
            this.cbox6.Items.AddRange(new object[] {
            "الكل",
            "المثبتين",
            "العقود",
            "المكلفين"});
            this.cbox6.Location = new System.Drawing.Point(490, 13);
            this.cbox6.Name = "cbox6";
            this.cbox6.Size = new System.Drawing.Size(185, 21);
            this.cbox6.TabIndex = 8;
            this.cbox6.SelectedIndexChanged += new System.EventHandler(this.cbox6_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "لتاريخ :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(687, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 36);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zatiDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.salarycutDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.forokattawedDataGridViewTextBoxColumn,
            this.total1DataGridViewTextBoxColumn,
            this.savingtotal,
            this.savinguser,
            this.savingejtma,
            this.darepadakelDataGridViewTextBoxColumn,
            this.sakanomaliDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.tabeamaliDataGridViewTextBoxColumn,
            this.tabeaamaliDataGridViewTextBoxColumn,
            this.forokathasmDataGridViewTextBoxColumn,
            this.nakabtmohandsDataGridViewTextBoxColumn,
            this.nakabazeraeeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.kedmaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.okobaDataGridViewTextBoxColumn,
            this.ejazaDataGridViewTextBoxColumn,
            this.sehaDataGridViewTextBoxColumn,
            this.totalkaredDataGridViewTextBoxColumn,
            this.totalaksatDataGridViewTextBoxColumn,
            this.otherhasemDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.DataSource = this.salarysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 524);
            this.dataGridView1.TabIndex = 5;
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
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "ت العائلي";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            this.familyDataGridViewTextBoxColumn.Width = 77;
            // 
            // forokattawedDataGridViewTextBoxColumn
            // 
            this.forokattawedDataGridViewTextBoxColumn.DataPropertyName = "forokattawed";
            this.forokattawedDataGridViewTextBoxColumn.HeaderText = "ت فروقات";
            this.forokattawedDataGridViewTextBoxColumn.Name = "forokattawedDataGridViewTextBoxColumn";
            this.forokattawedDataGridViewTextBoxColumn.ReadOnly = true;
            this.forokattawedDataGridViewTextBoxColumn.Width = 76;
            // 
            // total1DataGridViewTextBoxColumn
            // 
            this.total1DataGridViewTextBoxColumn.DataPropertyName = "total1";
            this.total1DataGridViewTextBoxColumn.HeaderText = "المجموع";
            this.total1DataGridViewTextBoxColumn.Name = "total1DataGridViewTextBoxColumn";
            this.total1DataGridViewTextBoxColumn.ReadOnly = true;
            this.total1DataGridViewTextBoxColumn.Width = 71;
            // 
            // savingtotal
            // 
            this.savingtotal.DataPropertyName = "savingemployee";
            this.savingtotal.HeaderText = "ت موظف";
            this.savingtotal.Name = "savingtotal";
            this.savingtotal.ReadOnly = true;
            this.savingtotal.Width = 72;
            // 
            // savinguser
            // 
            this.savinguser.DataPropertyName = "savinguser";
            this.savinguser.HeaderText = "ت مستخدم";
            this.savinguser.Name = "savinguser";
            this.savinguser.ReadOnly = true;
            this.savinguser.Width = 86;
            // 
            // savingejtma
            // 
            this.savingejtma.DataPropertyName = "savingejtma";
            this.savingejtma.HeaderText = "ت اجتماعية";
            this.savingejtma.Name = "savingejtma";
            this.savingejtma.ReadOnly = true;
            this.savingejtma.Width = 85;
            // 
            // darepadakelDataGridViewTextBoxColumn
            // 
            this.darepadakelDataGridViewTextBoxColumn.DataPropertyName = "darepadakel";
            this.darepadakelDataGridViewTextBoxColumn.HeaderText = "الضريبة";
            this.darepadakelDataGridViewTextBoxColumn.Name = "darepadakelDataGridViewTextBoxColumn";
            this.darepadakelDataGridViewTextBoxColumn.ReadOnly = true;
            this.darepadakelDataGridViewTextBoxColumn.Width = 65;
            // 
            // sakanomaliDataGridViewTextBoxColumn
            // 
            this.sakanomaliDataGridViewTextBoxColumn.DataPropertyName = "sakanomali";
            this.sakanomaliDataGridViewTextBoxColumn.HeaderText = "سكن ع";
            this.sakanomaliDataGridViewTextBoxColumn.Name = "sakanomaliDataGridViewTextBoxColumn";
            this.sakanomaliDataGridViewTextBoxColumn.ReadOnly = true;
            this.sakanomaliDataGridViewTextBoxColumn.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "madena";
            this.dataGridViewTextBoxColumn4.HeaderText = "م مدينة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tahrer";
            this.dataGridViewTextBoxColumn5.HeaderText = "ج تحرير";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 65;
            // 
            // tabeamaliDataGridViewTextBoxColumn
            // 
            this.tabeamaliDataGridViewTextBoxColumn.DataPropertyName = "tabeamali";
            this.tabeamaliDataGridViewTextBoxColumn.HeaderText = "ط م";
            this.tabeamaliDataGridViewTextBoxColumn.Name = "tabeamaliDataGridViewTextBoxColumn";
            this.tabeamaliDataGridViewTextBoxColumn.ReadOnly = true;
            this.tabeamaliDataGridViewTextBoxColumn.Width = 49;
            // 
            // tabeaamaliDataGridViewTextBoxColumn
            // 
            this.tabeaamaliDataGridViewTextBoxColumn.DataPropertyName = "tabeaamali";
            this.tabeaamaliDataGridViewTextBoxColumn.HeaderText = "ط ع";
            this.tabeaamaliDataGridViewTextBoxColumn.Name = "tabeaamaliDataGridViewTextBoxColumn";
            this.tabeaamaliDataGridViewTextBoxColumn.ReadOnly = true;
            this.tabeaamaliDataGridViewTextBoxColumn.Width = 49;
            // 
            // forokathasmDataGridViewTextBoxColumn
            // 
            this.forokathasmDataGridViewTextBoxColumn.DataPropertyName = "forokathasm";
            this.forokathasmDataGridViewTextBoxColumn.HeaderText = "ح فروقات";
            this.forokathasmDataGridViewTextBoxColumn.Name = "forokathasmDataGridViewTextBoxColumn";
            this.forokathasmDataGridViewTextBoxColumn.ReadOnly = true;
            this.forokathasmDataGridViewTextBoxColumn.Width = 74;
            // 
            // nakabtmohandsDataGridViewTextBoxColumn
            // 
            this.nakabtmohandsDataGridViewTextBoxColumn.DataPropertyName = "nakabtmohands";
            this.nakabtmohandsDataGridViewTextBoxColumn.HeaderText = "ن مهندس";
            this.nakabtmohandsDataGridViewTextBoxColumn.Name = "nakabtmohandsDataGridViewTextBoxColumn";
            this.nakabtmohandsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nakabtmohandsDataGridViewTextBoxColumn.Width = 77;
            // 
            // nakabazeraeeDataGridViewTextBoxColumn
            // 
            this.nakabazeraeeDataGridViewTextBoxColumn.DataPropertyName = "nakabazeraee";
            this.nakabazeraeeDataGridViewTextBoxColumn.HeaderText = "ن زراعية";
            this.nakabazeraeeDataGridViewTextBoxColumn.Name = "nakabazeraeeDataGridViewTextBoxColumn";
            this.nakabazeraeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nakabazeraeeDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "omal";
            this.dataGridViewTextBoxColumn6.HeaderText = "ن عمال";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "thema";
            this.dataGridViewTextBoxColumn7.HeaderText = "ذمة";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 49;
            // 
            // kedmaDataGridViewTextBoxColumn
            // 
            this.kedmaDataGridViewTextBoxColumn.DataPropertyName = "kedma";
            this.kedmaDataGridViewTextBoxColumn.HeaderText = "خدمة";
            this.kedmaDataGridViewTextBoxColumn.Name = "kedmaDataGridViewTextBoxColumn";
            this.kedmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kedmaDataGridViewTextBoxColumn.Width = 57;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tanfiz";
            this.dataGridViewTextBoxColumn8.HeaderText = "تنفيذ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 55;
            // 
            // okobaDataGridViewTextBoxColumn
            // 
            this.okobaDataGridViewTextBoxColumn.DataPropertyName = "okoba";
            this.okobaDataGridViewTextBoxColumn.HeaderText = "عقوبة";
            this.okobaDataGridViewTextBoxColumn.Name = "okobaDataGridViewTextBoxColumn";
            this.okobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.okobaDataGridViewTextBoxColumn.Width = 59;
            // 
            // ejazaDataGridViewTextBoxColumn
            // 
            this.ejazaDataGridViewTextBoxColumn.DataPropertyName = "ejaza";
            this.ejazaDataGridViewTextBoxColumn.HeaderText = "اجازة";
            this.ejazaDataGridViewTextBoxColumn.Name = "ejazaDataGridViewTextBoxColumn";
            this.ejazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ejazaDataGridViewTextBoxColumn.Width = 54;
            // 
            // sehaDataGridViewTextBoxColumn
            // 
            this.sehaDataGridViewTextBoxColumn.DataPropertyName = "seha";
            this.sehaDataGridViewTextBoxColumn.HeaderText = "صحة";
            this.sehaDataGridViewTextBoxColumn.Name = "sehaDataGridViewTextBoxColumn";
            this.sehaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sehaDataGridViewTextBoxColumn.Width = 54;
            // 
            // totalkaredDataGridViewTextBoxColumn
            // 
            this.totalkaredDataGridViewTextBoxColumn.DataPropertyName = "totalkared";
            this.totalkaredDataGridViewTextBoxColumn.HeaderText = "مج قرض";
            this.totalkaredDataGridViewTextBoxColumn.Name = "totalkaredDataGridViewTextBoxColumn";
            this.totalkaredDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalkaredDataGridViewTextBoxColumn.Width = 72;
            // 
            // totalaksatDataGridViewTextBoxColumn
            // 
            this.totalaksatDataGridViewTextBoxColumn.DataPropertyName = "totalaksat";
            this.totalaksatDataGridViewTextBoxColumn.HeaderText = "مج اقساط";
            this.totalaksatDataGridViewTextBoxColumn.Name = "totalaksatDataGridViewTextBoxColumn";
            this.totalaksatDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalaksatDataGridViewTextBoxColumn.Width = 79;
            // 
            // otherhasemDataGridViewTextBoxColumn
            // 
            this.otherhasemDataGridViewTextBoxColumn.DataPropertyName = "otherhasem";
            this.otherhasemDataGridViewTextBoxColumn.HeaderText = "اخرى";
            this.otherhasemDataGridViewTextBoxColumn.Name = "otherhasemDataGridViewTextBoxColumn";
            this.otherhasemDataGridViewTextBoxColumn.ReadOnly = true;
            this.otherhasemDataGridViewTextBoxColumn.Width = 57;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn13.HeaderText = "الصافي";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 66;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zatiDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.total,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView2.DataSource = this.salarysBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(443, 524);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.Visible = false;
            // 
            // zatiDataGridViewTextBoxColumn1
            // 
            this.zatiDataGridViewTextBoxColumn1.DataPropertyName = "zati";
            this.zatiDataGridViewTextBoxColumn1.HeaderText = "الرقم";
            this.zatiDataGridViewTextBoxColumn1.Name = "zatiDataGridViewTextBoxColumn1";
            this.zatiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zatiDataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "الإسم الثلاثي";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 96;
            // 
            // total
            // 
            this.total.DataPropertyName = "lastsalary";
            this.total.HeaderText = "الصافي";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 66;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "visacard";
            this.dataGridViewTextBoxColumn9.HeaderText = "بطاقة الصراف";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 93;
            // 
            // salarysTableAdapter
            // 
            this.salarysTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1015, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "تصدير";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.Filter = "\"Exel Filel (*.xls)|*.xls|All files (*.*)|*.*\"";
            this.saveFileDialog1.Title = "تصدير جدور رواتب الصراف";
            // 
            // RawatepShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbox6);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RawatepShowForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول الرواتب";
            this.Load += new System.EventHandler(this.RawatepShowForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RawatepShowForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taslefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawferDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visacardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taweda3lyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forokatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawedmowazafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawedmostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darepaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanfizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seheaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn withoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okopatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tawedejtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zerayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mohandesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahrerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaerd;
        private System.Windows.Forms.DataGridViewTextBoxColumn madenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SalarysDS salarysDS;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarycutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forokattawedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn savinguser;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingejtma;
        private System.Windows.Forms.DataGridViewTextBoxColumn darepadakelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sakanomaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabeamaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabeaamaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forokathasmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakabtmohandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nakabazeraeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn kedmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn okobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalkaredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalaksatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherhasemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zatiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
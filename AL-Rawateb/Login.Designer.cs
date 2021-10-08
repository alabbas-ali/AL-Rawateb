namespace AL_Rawateb
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usareDS = new AL_Rawateb.UsareDS();
            this.enter = new System.Windows.Forms.Button();
            this.upass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new AL_Rawateb.UsareDSTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usareDS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(220, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "إنهاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uname
            // 
            this.uname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uname.DataSource = this.usersBindingSource;
            this.uname.DisplayMember = "user_name";
            this.uname.FormattingEnabled = true;
            this.uname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uname.Location = new System.Drawing.Point(127, 18);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(223, 21);
            this.uname.TabIndex = 7;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usareDS;
            // 
            // usareDS
            // 
            this.usareDS.DataSetName = "UsareDS";
            this.usareDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enter
            // 
            this.enter.AutoEllipsis = true;
            this.enter.Location = new System.Drawing.Point(33, 92);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(142, 27);
            this.enter.TabIndex = 9;
            this.enter.Text = "دخول";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // upass
            // 
            this.upass.Location = new System.Drawing.Point(127, 56);
            this.upass.Name = "upass";
            this.upass.Size = new System.Drawing.Size(223, 20);
            this.upass.TabIndex = 8;
            this.upass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "كلمة المرور  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "أسم المستخدم  :";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(376, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.upass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدخول";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usareDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox uname;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox upass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UsareDS usareDS;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AL_Rawateb.UsareDSTableAdapters.usersTableAdapter usersTableAdapter;
    }
}
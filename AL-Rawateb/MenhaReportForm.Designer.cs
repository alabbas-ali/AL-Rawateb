namespace AL_Rawateb
{
    partial class MenhaReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MenhaDS = new AL_Rawateb.MenhaDS();
            this.MenhaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenhaTableAdapter = new AL_Rawateb.MenhaDSTableAdapters.MenhaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MenhaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenhaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MenhaDS_Menha";
            reportDataSource1.Value = this.MenhaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AL_Rawateb.ReportMenha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportViewer1.Size = new System.Drawing.Size(718, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // MenhaDS
            // 
            this.MenhaDS.DataSetName = "MenhaDS";
            this.MenhaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MenhaBindingSource
            // 
            this.MenhaBindingSource.DataMember = "Menha";
            this.MenhaBindingSource.DataSource = this.MenhaDS;
            // 
            // MenhaTableAdapter
            // 
            this.MenhaTableAdapter.ClearBeforeFill = true;
            // 
            // MenhaReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 490);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenhaReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول المنحة";
            this.Load += new System.EventHandler(this.MenhaReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenhaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenhaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MenhaBindingSource;
        private MenhaDS MenhaDS;
        private AL_Rawateb.MenhaDSTableAdapters.MenhaTableAdapter MenhaTableAdapter;
    }
}
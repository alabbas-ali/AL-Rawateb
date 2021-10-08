namespace AL_Rawateb
{
    partial class NakabatReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalarysDS = new AL_Rawateb.SalarysDS();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalarysDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "SalarysDS_salarys";
            reportDataSource2.Value = this.salarysBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AL_Rawateb.NakabatReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportViewer1.Size = new System.Drawing.Size(700, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalarysDS
            // 
            this.SalarysDS.DataSetName = "SalarysDS";
            this.SalarysDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salarysBindingSource
            // 
            this.salarysBindingSource.DataMember = "salarys";
            this.salarysBindingSource.DataSource = this.SalarysDS;
            // 
            // salarysTableAdapter
            // 
            this.salarysTableAdapter.ClearBeforeFill = true;
            // 
            // NakabatReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NakabatReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جداول النقابات";
            this.Load += new System.EventHandler(this.NakabatReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalarysDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private SalarysDS SalarysDS;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;
    }
}
namespace AL_Rawateb
{
    partial class RawatepReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawatepReportForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salarysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalarysDS = new AL_Rawateb.SalarysDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salarysTableAdapter = new AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalarysDS)).BeginInit();
            this.SuspendLayout();
            // 
            // salarysBindingSource
            // 
            this.salarysBindingSource.DataMember = "salarys";
            this.salarysBindingSource.DataSource = this.SalarysDS;
            // 
            // SalarysDS
            // 
            this.SalarysDS.DataSetName = "SalarysDS";
            this.SalarysDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibleDescription = null;
            this.reportViewer1.AccessibleName = null;
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.BackgroundImage = null;
            this.reportViewer1.Font = null;
            reportDataSource1.Name = "SalarysDS_salarys";
            reportDataSource1.Value = this.salarysBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AL_Rawateb.ReportRawatep.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            // 
            // salarysTableAdapter
            // 
            this.salarysTableAdapter.ClearBeforeFill = true;
            // 
            // RawatepReportForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.reportViewer1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = null;
            this.Name = "RawatepReportForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.RawatepReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salarysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalarysDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource salarysBindingSource;
        private SalarysDS SalarysDS;
        private AL_Rawateb.SalarysDSTableAdapters.salarysTableAdapter salarysTableAdapter;


    }
}
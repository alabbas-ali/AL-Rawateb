﻿namespace AL_Rawateb
{
    partial class UpGreatReportForm
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
            this.UpGreatDS = new AL_Rawateb.UpGreatDS();
            this.UpGratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpGratTableAdapter = new AL_Rawateb.UpGreatDSTableAdapters.UpGratTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UpGreatDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpGratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UpGreatDS_UpGrat";
            reportDataSource1.Value = this.UpGratBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AL_Rawateb.ReportUpGreat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportViewer1.Size = new System.Drawing.Size(1033, 497);
            this.reportViewer1.TabIndex = 0;
            // 
            // UpGreatDS
            // 
            this.UpGreatDS.DataSetName = "UpGreatDS";
            this.UpGreatDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpGratBindingSource
            // 
            this.UpGratBindingSource.DataMember = "UpGrat";
            this.UpGratBindingSource.DataSource = this.UpGreatDS;
            // 
            // UpGratTableAdapter
            // 
            this.UpGratTableAdapter.ClearBeforeFill = true;
            // 
            // UpGreatReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 497);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpGreatReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول الترفيعة";
            this.Load += new System.EventHandler(this.UpGreatReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpGreatDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpGratBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UpGratBindingSource;
        private UpGreatDS UpGreatDS;
        private AL_Rawateb.UpGreatDSTableAdapters.UpGratTableAdapter UpGratTableAdapter;
    }
}
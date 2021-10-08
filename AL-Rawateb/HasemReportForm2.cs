using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections.ObjectModel;

namespace AL_Rawateb
{
    public partial class HasemReportForm2 : Form
    {
        private int month;
        private int year;
        private string usingsubject1 = "";
        private string usingsubject2 = "";
        private string visacad = "";

        public HasemReportForm2(string usingsubject1,string usingsubject2,string visacad,int month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.usingsubject1 = usingsubject1;
            this.usingsubject2 = usingsubject2;
            this.visacad = visacad;
        }

        private void HasemReportForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            this.salarysTableAdapter.FillHasm2(this.SalarysDS.salarys,usingsubject1,usingsubject2,visacad, month, year);
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            this.reportViewer1.RefreshReport();
        }
    }
}

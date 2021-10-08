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
    public partial class RawatepReportForm : Form
    {
        Boolean chec;
        int month;
        int year;
        string usingsubject;
        public RawatepReportForm(Boolean ch , int month,int year , string usingsubject)
        {
            InitializeComponent();
            this.chec = ch;
            this.month = month;
            this.year = year;
            this.usingsubject = usingsubject;
        }

        private void RawatepReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            //this.salarysTableAdapter.Fill(this.SalarysDS.salarys);
            if (usingsubject == "")
            {
                if (chec == true)
                {
                    this.salarysTableAdapter.FillForAllForVisa(this.SalarysDS.salarys, month, year);
                }
                else
                {
                    this.salarysTableAdapter.FillForAllNoVisa(this.SalarysDS.salarys, month, year);
                }
            }
            else
            {
                if (chec == true)
                {
                    this.salarysTableAdapter.FillForVisa(this.SalarysDS.salarys, usingsubject, month, year);
                }
                else
                {
                    this.salarysTableAdapter.FillForNoVisa(this.SalarysDS.salarys, usingsubject, month, year);
                }
            }
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            this.reportViewer1.RefreshReport();
        }
    }
}

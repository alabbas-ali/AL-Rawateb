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
    public partial class TawedReportForm : Form
    {
        private int type = 0;
        private int month;
        private int year;
        public TawedReportForm(int type ,int month , int year)
        {
            InitializeComponent();
            this.type = type;
            this.month = month;
            this.year = year;
        }

        private void TawedReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TawedRepotDS.tempTawed' table. You can move, or remove it, as needed.
            //this.tempTawedTableAdapter.Fill(this.TawedRepotDS.tempTawed);
            ReportParameter type = new ReportParameter("type", this.type.ToString());
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(type);
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            if (this.type == 0)
            {
                this.salarysTableAdapter.FillTabeaTawed(this.SalarysDS.salarys, month, year);
            }
            else if (this.type == 1)
            {
                this.salarysTableAdapter.FillEktesasTawed(this.SalarysDS.salarys, month, year);
            }
            else
            {
                this.salarysTableAdapter.FillMaseoleaTawed(this.SalarysDS.salarys, month, year);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

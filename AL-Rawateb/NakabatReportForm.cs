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
    public partial class NakabatReportForm : Form
    {
        private int type;
        private int month;
        private int year;

        public NakabatReportForm(int type,int month, int year)
        {
            InitializeComponent();
            this.type = type;
            this.month = month;
            this.year = year;
        }

        private void NakabatReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            ReportParameter type = new ReportParameter("type", this.type.ToString());
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(type);
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            switch(this.type){
                case 0 : 
                    this.salarysTableAdapter.FillNakabat(this.SalarysDS.salarys,month,year, 0, -1);
                    break;
                case 1:
                    this.salarysTableAdapter.FillNakabat(this.SalarysDS.salarys, month, year, -1, 0);
                    break;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

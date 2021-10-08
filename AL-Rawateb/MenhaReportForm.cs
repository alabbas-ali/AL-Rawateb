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
    public partial class MenhaReportForm : Form
    {
        private int month;
        private int year;

        public MenhaReportForm(int month,int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
        }

        private void MenhaReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MenhaDS.Menha' table. You can move, or remove it, as needed.
            this.MenhaTableAdapter.Fill(this.MenhaDS.Menha,month,year);
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            this.reportViewer1.RefreshReport();
        }
    }
}

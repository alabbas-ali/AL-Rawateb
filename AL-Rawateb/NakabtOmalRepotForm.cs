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
    public partial class NakabtOmalRepotForm : Form
    {
        private int month;
        private int year;

        public NakabtOmalRepotForm(int month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
        }

        private void NakabtOmalRepotForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            this.salarysTableAdapter.Fill(this.SalarysDS.salarys,month,year);
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);
            this.reportViewer1.RefreshReport();
        }
    }
}

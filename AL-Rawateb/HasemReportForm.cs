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
    public partial class HasemReportForm : Form
    {
        private int type = 0;
        private int month;
        private int year;
        private string usingsubject1 = "";
        private string usingsubject2 = "";
        private string visacad = "";

        public HasemReportForm(int type,string usingsubject1 ,string usingsubject2 ,string visacad , int month, int year)
        {
            InitializeComponent();
            this.type = type;
            this.month = month;
            this.year = year;
            this.usingsubject1 = usingsubject1;
            this.usingsubject2 = usingsubject2;
            this.visacad = visacad;
        }

        private void HasemReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            switch (this.type)
            {
                case 0: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "sakanomali";
                        break;
                case 1: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "madena";
                        break;
                case 2: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tahrer";
                        break;
                case 3: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tabeaamali";
                        break;
                case 4: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tabeamali";
                        break;
                case 5: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "forokathasem";
                        break;
                case 6: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "kedma";
                        break;
                case 7: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "thema";
                        break;
                case 8: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tanfiz";
                        break;
                case 9: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "salttajze";
                        break;
                case 10: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "sharkttajzea";
                        break;
                case 11: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "sondos";
                        break;
                case 12: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "sakan";
                        break;
                case 13: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "estmlakbalade";
                        break;
                case 14: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "otherhasem";
                        break;
                case 15: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "solfa";
                        break;
                case 16: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "savingejtma";
                        break;
                case 17: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "savingemployee";
                        break;
                case 18: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "savinguser";
                        break;
                case 19: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "kardakare";
                        break;
                case 20: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "taslef";
                        break;
                case 21: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tawfer";
                        break;
                case 22: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "nakaba";
                        break;
                case 23: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "tejare";
                        break;
                case 24: this.salarysTableAdapter.FillHasemeat(this.SalarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, usingsubject1, usingsubject2, visacad, month, year);
                        //this.sakanomali.DataPropertyName = "zawaj";
                        break;
            }

            ReportParameter type = new ReportParameter("type", this.type.ToString());
            ReportParameter date = new ReportParameter("date", this.month + "/" + this.year);
            Collection<ReportParameter> paramtrlist = new Collection<ReportParameter>();
            paramtrlist.Add(type);
            paramtrlist.Add(date);
            this.reportViewer1.LocalReport.SetParameters(paramtrlist);

            this.reportViewer1.RefreshReport();
        }
    }
}

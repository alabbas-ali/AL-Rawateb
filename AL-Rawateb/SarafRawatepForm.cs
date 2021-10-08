using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AL_Rawateb
{
    public partial class SarafRawatepForm : Form
    {
        int month;
        int year;
        string usingsubject;

        public SarafRawatepForm(int month,int year , string usingsubject)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.usingsubject = usingsubject;
        }

        private void SarafRawatepForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalarysDS.salarys' table. You can move, or remove it, as needed.
            if (usingsubject == "")
            {
                this.salarysTableAdapter.FillForAllForVisa(this.SalarysDS.salarys , month, year);
            }
            else
            {
                this.salarysTableAdapter.FillForVisa(this.SalarysDS.salarys , usingsubject, month, year);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

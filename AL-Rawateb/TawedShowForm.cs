using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AL_Rawateb
{
    public partial class TawedShowForm : Form
    {
        private Master_form part;
        private int type = 0;
        private int month;
        private int year;

        public TawedShowForm( Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void TabeaAmalShowForm_Load(object sender, EventArgs e)
        {
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            cbtype.SelectedIndex = 0;
        }

        private void TabeaAmalShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.Tawed_f = 1;
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.type = cbtype.SelectedIndex;
            fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TawedReportForm(this.type,month,year).Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            fill();
        }
        private void fill()
        {
            if (cbtype.SelectedIndex == 0)
            {
                this.nesptektsasDataGridViewTextBoxColumn.DataPropertyName = "nespttapea";
                this.ektesasDataGridViewTextBoxColumn.DataPropertyName = "tabeaamal";
                this.darepaektesasDataGridViewTextBoxColumn.DataPropertyName = "darepatapea";
                this.salarysTableAdapter.FillTabeaTawed(this.salarysDS.salarys, month, year);
            }
            else if (cbtype.SelectedIndex == 1)
            {
                this.nesptektsasDataGridViewTextBoxColumn.DataPropertyName = "nesptektsas";
                this.ektesasDataGridViewTextBoxColumn.DataPropertyName = "ektesas";
                this.darepaektesasDataGridViewTextBoxColumn.DataPropertyName = "darepaektesas";
                this.salarysTableAdapter.FillEktesasTawed(this.salarysDS.salarys, month, year);
            }
            else
            {
                this.nesptektsasDataGridViewTextBoxColumn.DataPropertyName = "";
                this.ektesasDataGridViewTextBoxColumn.DataPropertyName = "maseolea";
                this.darepaektesasDataGridViewTextBoxColumn.DataPropertyName = "darepamaseolea";
                this.salarysTableAdapter.FillMaseoleaTawed(this.salarysDS.salarys, month, year);
            }
        }
    }
}

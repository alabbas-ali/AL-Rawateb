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
    public partial class NakabtOmalForm : Form
    {
        private Master_form part;
        private int month;
        private int year;
        public NakabtOmalForm(Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void NakabtOmalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarysDS.salarys' table. You can move, or remove it, as needed.
            //this.salarysTableAdapter.Fill(this.salarysDS.salarys);
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            fill();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            fill();
        }

        private void fill()
        {
            this.salarysTableAdapter.Fill(this.salarysDS.salarys, month, year);
        }

        private void NakabtOmalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.NakabtOmal_f = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NakabtOmalRepotForm(month, year).Show();
        }
    }
}

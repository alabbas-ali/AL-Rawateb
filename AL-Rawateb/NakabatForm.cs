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
    public partial class NakabatForm : Form
    {
        private Master_form part;
        int type = 0;
        int month;
        int year;
        public NakabatForm(Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void NakabatForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NakabatReportForm(type, month, year).Show();
        }

        private void NakabatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.Nakabt_f = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = comboBox1.SelectedIndex;
            fill();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            fill();
        }

        private void fill()
        {
            switch (type)
            {
                case 0:
                    this.salarysTableAdapter.FillNakabat(this.salarysDS.salarys, month, year, 0, -1);
                    this.nakabtmohandsDataGridViewTextBoxColumn.DataPropertyName = "nakabtmohands";
                    break;
                case 1:
                    this.salarysTableAdapter.FillNakabat(this.salarysDS.salarys, month, year, -1, 0);
                    this.nakabtmohandsDataGridViewTextBoxColumn.DataPropertyName = "nakabazeraee";
                    break;
            }
        }
    }
}

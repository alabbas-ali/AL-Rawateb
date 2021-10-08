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
    public partial class MenhaForm : Form
    {
        Myconnection mycon;
        Master_form prnt;
        private int month;
        private int year;

        public MenhaForm(Master_form master)
        {
            InitializeComponent();
            this.prnt = master;
        }

        private void MenhaForm_Load(object sender, EventArgs e)
        {
            this.month = dateTimePicker2.Value.Month;
            this.year = dateTimePicker2.Value.Year;
            fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tarf = 0;
            if (int.Parse(textBox1.Text) > 0)
            {
                //MessageBox.Show("asdas");
                tarf = int.Parse(textBox1.Text);
            }

            int month1 = dateTimePicker1.Value.Month;
            int year1 = dateTimePicker1.Value.Year;

            if (tarf > 0)
            {

                this.mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
                DataTable dtemployees = mycon.myselect_ds("select * from Employees WHERE stopsal=0");
                foreach (DataRow employee in dtemployees.Rows)
                {
                    string id = employee["id"].ToString().Trim();
                    string zati = employee["zati"].ToString().Trim();
                    string name = employee["fname"].ToString().Trim() + " " + employee["father"].ToString().Trim() + " " + employee["lname"].ToString().Trim();
                    int salarycut = Convert.ToInt32(employee["salarycut"].ToString());
                    int total = (salarycut * tarf) / 100;
                    mycon.Commoand("insert into Menha (id,zati,name,salarycut,total,month,year)" +
                                   "values(" + id + "," + zati + ",'" + name + "'," + salarycut + "," + total + "," + month1 + "," + year1 + ")");
                }
            }
            fill();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.month = dateTimePicker2.Value.Month;
            this.year = dateTimePicker2.Value.Year;
            fill();
        }

        private void fill()
        {
            // TODO: This line of code loads data into the 'menhaDS.Menha' table. You can move, or remove it, as needed.
            this.menhaTableAdapter.Fill(this.menhaDS.Menha, this.month, this.year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MenhaReportForm(this.month, this.year).Show();
        }
    }
}

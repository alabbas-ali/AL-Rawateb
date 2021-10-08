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
    public partial class HasemShowForm2 : Form
    {
        private Master_form part;
        private int month;
        private int year;
        private string usingsubject1 = "";
        private string usingsubject2 = "";
        private string visacad = "";

        public HasemShowForm2(Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void HasemShowForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarysDS.salarys' table. You can move, or remove it, as needed.
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

        private void checkall()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%مكلف%"; usingsubject2 = "%عقد%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%مكلف%"; usingsubject2 = "%عقد%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%مكلف%"; usingsubject2 = "%عقد%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%مثبت%"; usingsubject2 = "%عقد%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%مثبت%"; usingsubject2 = "%عقد%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%مثبت%"; usingsubject2 = "%عقد%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%عقد%"; usingsubject2 = "%عقد%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%عقد%"; usingsubject2 = "%عقد%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%عقد%"; usingsubject2 = "%عقد%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == true) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }



            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مكلف%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مكلف%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مكلف%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مكلف%"; usingsubject2 = "%مكلف%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مكلف%"; usingsubject2 = "%مكلف%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%مكلف%"; usingsubject2 = "%مكلف%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مثبت%"; visacad = "%%"; }
            if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مثبت%"; visacad = "%no%"; }
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%مثبت%"; usingsubject2 = "%مثبت%"; visacad = "%0%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            //if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            //if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            //if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false) { usingsubject1 = "%%"; usingsubject2 = "%%"; visacad = "%%"; }
            fill();
        }

        private void fill()
        {
            this.salarysTableAdapter.FillHasm2(this.salarysDS.salarys, usingsubject1, usingsubject2, visacad, month, year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HasemReportForm2(usingsubject1,usingsubject2,visacad,month, year).Show();
        }

        private void HasemShowForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.Hasem_f2 = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkall();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkall();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkall();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkall();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkall();
        }
    }
}

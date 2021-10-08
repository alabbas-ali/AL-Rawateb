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
    public partial class HasemShowForm : Form
    {
        private Master_form part;
        private int type = 0;
        private int month;
        private int year;
        private string usingsubject1 = "";
        private string usingsubject2 = "";
        private string visacad = "";

        public HasemShowForm(Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.type = cbtype.SelectedIndex;
            fill();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            fill();
        }

        private void HasemShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.Hasem_f = 1;
        }

        private void HasemShowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarysDS.salarys' table. You can move, or remove it, as needed.
            this.month = dateTimePicker1.Value.Month;
            this.year = dateTimePicker1.Value.Year;
            cbtype.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HasemReportForm(this.type,usingsubject1 , usingsubject2 , visacad , month, year).Show();
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
            switch (type)
            {
                case 0: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "sakanomali";
                        break;
                case 1: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "madena";
                        break;
                case 2: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tahrer";
                        break;
                case 3: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tabeaamali";
                        break;
                case 4: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tabeamali";
                        break;
                case 5: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "forokathasem";
                        break;
                case 6: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "kedma";
                        break;
                case 7: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "thema";
                        break;
                case 8: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tanfiz";
                        break;
                case 9: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "salttajze";
                        break;
                case 10: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "sharkttajzea";
                        break;
                case 11: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "sondos";
                        break;
                case 12: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "sakan";
                        break;
                case 13: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "estmlakbalade";
                        break;
                case 14: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "otherhasem";
                        break;
                case 15: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "solfa";
                        break;
                case 16: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "savingejtma";
                        break;
                case 17: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "savingemployee";
                        break;
                case 18: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "savinguser";
                        break;
                case 19: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "kardakare";
                        break;
                case 20: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "taslef";
                        break;
                case 21: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tawfer";
                        break;
                case 22: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "nakaba";
                        break;
                case 23: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, -1, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "tejare";
                        break;
                case 24: this.salarysTableAdapter.FillHasemeat(this.salarysDS.salarys, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, usingsubject1, usingsubject2, visacad, month, year);
                        this.sakanomali.DataPropertyName = "zawaj";
                        break;
            }
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

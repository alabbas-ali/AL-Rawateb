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
    public partial class Upgrad_form : Form
    {   
        private Master_form prnt;
        private int month;
        private int year;
        private Myconnection mycon;

        public Upgrad_form(Master_form pr)
        {
            InitializeComponent();
            this.prnt = pr;
        }

        private void Upgrad_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'upGreatDS.UpGrat' table. You can move, or remove it, as needed.
            this.month = dateTimePicker2.Value.Month;
            this.year = dateTimePicker2.Value.Year;
            fill();
        }

        private void Upgrad_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.upgrad_f = 1;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.month = dateTimePicker2.Value.Month;
            this.year = dateTimePicker2.Value.Year;
            fill();
        }

        private void fill()
        {
            this.upGratTableAdapter.Fill(this.upGreatDS.UpGrat, month, year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tarf=0;
            if (int.Parse(textBox1.Text) > 0)
            {
                tarf = int.Parse(textBox1.Text);
            }
            int num=0;
            if (int.Parse(textBox3.Text)>0)
            {
                num = int.Parse(textBox3.Text);
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
                    int oldsalarycut = Convert.ToInt32(employee["salarycut"].ToString());
                    int newsalarycut = oldsalarycut + ((oldsalarycut * tarf) / 100);
                    int sub = newsalarycut - oldsalarycut;
                    if (num > 0)
                    {
                        int forokat = num * sub;
                        int tamen = forokat * 7 / 100;
                        int dareptdakel = collect_darept(oldsalarycut, forokat);
                        ////////////////
                        DataTable dttawed = mycon.myselect_ds("select * from Tawed where idemployee=" + id + "");
                        int ekhtesas = 0;
                        int tabeah = 0;

                        if (dttawed.Rows.Count > 0)
                        {
                            int stopektsas = Convert.ToInt32(mycon.getonevalue("select stopektsas from Options where id=1"));
                            if (stopektsas == 0)
                            {
                                ekhtesas = (int)Math.Round(float.Parse(dttawed.Rows[0]["tawedekhtesas"].ToString()) * forokat / 100);
                                int d = collect_darept(oldsalarycut, ekhtesas);
                                ekhtesas -= d;
                            }

                            int stoptabea = Convert.ToInt32(mycon.getonevalue("select stoptabea from Options where id=1"));
                            if (stoptabea == 0)
                            {
                                tabeah = (int)Math.Round(float.Parse(dttawed.Rows[0]["tawedtabeah"].ToString()) * forokat / 100);
                                int d = collect_darept(oldsalarycut, tabeah);
                                tabeah -= d;
                            }
                        }
                        ///////////

                        DataTable dthasmcut = mycon.myselect_ds("select * from Hasmcut where idemployee=" + id + "");
                        //int dareptdakhl = 0;

                        int nakaptmohands = 0;
                        int nakaptzerai = 0;
                        int nakaptomalentfa = 0;
                        int nakaptomaleshtrak = 0;
                        int omal = 0;

                        if (dthasmcut.Rows.Count > 0)
                        {
                            nakaptzerai = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptzerai"].ToString()) * forokat / 100));
                            nakaptmohands = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptmohands"].ToString()) * forokat / 100));

                            if (Convert.ToDouble(dthasmcut.Rows[0]["nakaptentefa"].ToString()) != 0)
                            {
                                nakaptomalentfa = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptentefa"].ToString()) * forokat / 100));
                            }

                            if (Convert.ToDouble(dthasmcut.Rows[0]["nakaptamalishare"].ToString()) != 0)
                            {
                                nakaptomaleshtrak = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptamalishare"].ToString()) * forokat / 100));
                            }
                            omal = nakaptomalentfa + nakaptomaleshtrak;
                        }
                        int total = forokat - tamen - dareptdakel - omal - nakaptmohands - nakaptzerai + ekhtesas + tabeah;
                        mycon.Commoand("insert into upgrat (id,zati,name,oldcut,newcut,num,forokat" +
                                       ",tamen,dareptdakel,omal,mohandes,zeraee,ektsas,tabeataml,total,month,year)" +
                                       "values(" + id + "," + zati + ",'" + name + "'," + oldsalarycut + "," + newsalarycut + ","+ num +","+ forokat +","+ tamen +","+ dareptdakel +
                                       ","+ omal +","+ nakaptmohands +","+ nakaptzerai +","+ ekhtesas +","+ tabeah +","+ total +"," + month1 + "," + year1 + ")");
                    }
                    else
                    {
                        mycon.Commoand("insert into upgrat (id,zati,name,oldcut,newcut,num,forokat" +
                                       ",tamen,dareptdakel,omal,mohandes,zeraee,ektsas,tabeataml,total,month,year)" +
                                       "values("+ id +","+ zati +",'"+ name +"',"+ oldsalarycut +","+ newsalarycut +",0,0,0,0,0,0,0,0,0,0,"+ month1 +","+ year1 +")");
                    }
                }
            }
            fill();
        }


        // توابع حساب ضريبة تعويض الاختصاص وضريبة طبيعة العمل والمسؤولية
        private int collect_darept(int sal, int tabeah)
        {
            try
            {
                int sal_tabeah = sal + tabeah;
                double darept = 0;
                double darept1 = 0;
                double darept2 = 0;
                int newsalafterminus = sal_tabeah;

                int max_percent_befor = get_max_percent_cut_shareha(sal);
                int max_percent_after = get_max_percent_cut_shareha(sal_tabeah);
                int sharehaSalary = get_p1_of_max_limit_shareha(sal);//part1_of_max_sharehaSalary
                int part1 = 0;
                int part2 = 0;
                int result = 0;
                if (max_percent_befor == max_percent_after)
                {
                    darept = tabeah * max_percent_after / 100;
                    result = (int)Math.Ceiling(tabeah - darept);
                }
                else
                {
                    part1 = sal_tabeah - sharehaSalary;
                    part2 = tabeah - part1;
                    darept1 = tabeah * max_percent_after / 100;
                    darept2 = tabeah * max_percent_befor / 100;
                    result = (int)Math.Ceiling(tabeah - (darept1 + darept2));
                }
                int totaldarepa = Convert.ToInt32(darept + darept1 + darept2);
                string count = "0";
                return result;
            }
            catch (Exception eddd)
            {
                //MessageBox.Show(eddd.Message);
                return 0;
            }
        }
        private int get_max_percent_cut_shareha(int salarycuting)
        {
            if (salarycuting > 38000 && salarycuting <= 50000) { return 19; }
            if (salarycuting > 30000 && salarycuting <= 38000) { return 13; }
            if (salarycuting > 25000 && salarycuting <= 30000) { return 11; }
            if (salarycuting > 20000 && salarycuting <= 25000) { return 9; }
            if (salarycuting > 15000 && salarycuting <= 20000) { return 7; }
            if (salarycuting > 10000 && salarycuting <= 15000) { return 5; }
            else { return 0; }
        }
        private int get_p1_of_max_limit_shareha(int salarycuting)
        {
            if (salarycuting > 38000 && salarycuting <= 50000) { return 38000; }
            if (salarycuting > 30000 && salarycuting <= 38000) { return 30000; }
            if (salarycuting > 25000 && salarycuting <= 30000) { return 25000; }
            if (salarycuting > 20000 && salarycuting <= 25000) { return 20000; }
            if (salarycuting > 15000 && salarycuting <= 20000) { return 15000; }
            if (salarycuting > 10000 && salarycuting <= 15000) { return 10000; }
            else { return salarycuting; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UpGreatReportForm(this.month, this.year).Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
namespace AL_Rawateb
{
    public partial class Salary_form : Form
    {
        Master_form prnt;
        Myconnection mycon = null;
        string datetimenow = "";
        private ProsessingForm Process_Form;
        public int Process_f = 1;

        ArrayList id_name_arr;
        ArrayList arid;
        DataTable dtid;
        int index = 0; int countid = 0;

        public Salary_form(Master_form master)
        {
            InitializeComponent();
            this.prnt = master;
        }

        private void Salary_form_Load(object sender, EventArgs e)
        {
            mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
            //Myconnection ucon = new Myconnection("D:\\lak\\rwateb.mdf;");
            //-------------------------------------------------------------------

            //DataTable dtttt = mycon.myselect_ds("select * from table1");
            //foreach(DataRow dr in dtttt.Rows )
            //{
            //    int id = (int)dr["id"];
            //    string name = dr["name"].ToString().Trim();
            //    string visa = mycon.getonevalue("select visacard from temp1 where name like '%" + name + "%'");
            //    if (visa != "no")
            //    {
            //        mycon.Commoand("update table1 set visacard='" + visa + "' where id=" + id + "");
            //    }
            //}
            //mycon.Commoand("update Hasmcut set nakaptamalishare=1 ,nakaptamalishare1=80 ,nakaptamalishare2=200");
            //mycon.Commoand("update Kest set restvalue=kestvalue");
            //mycon.Commoand("update Employees set visacard='no'");

            //DataTable dtttt = mycon.myselect_ds("select * from table1 where visacard not like '%no%'");
            //foreach (DataRow dr in dtttt.Rows)
            //{
            //    int id = (int)dr["id"];
            //    string visa = dr["visacard"].ToString().Trim();
            //    mycon.Commoand("update Employees set visacard='" + visa + "' where id=" + id + "");
            //}

            datetimenow = dateTimePicker5.Text;
            arid = new ArrayList();
            id_name_arr = new ArrayList();
            fillarrayid();
            if (countid > 0)
            {
                id_box.Text = arid[index].ToString();
                button17_Click(null, null);//search*
            }
            searchbyname();
            id_box.Focus();
            id_box.SelectAll();
            collectDataTime_ValueChanged(null, null);
        }

        public void fillarrayid()
        {
            try
            {
                dtid = mycon.myselect_ds("select id from Employees");
                countid = dtid.Rows.Count;
                arid.Clear();
                index = 0;
                for (int i = 0; i < countid; i++)
                {
                    arid.Add(dtid.Rows[i]["id"].ToString());
                }
                if (countid == 0)
                {
                    id_box.Text = "لا يوجد أي موظف بعد";
                    //button17_Click(null, null);
                    id_box.Focus();
                }
            }
            catch { }
        }
  
        //insert update delete emp info ______________________________________________________________________________________________________________
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbed1.Text.Trim() == "")
                {
                    string motkaed = "0";
                    if (checkBox2.Checked)
                        motkaed = "1";
                    string seq="0";
                    if (textBox60.Text.Trim() != "")
                        seq = textBox60.Text;

                    string stopsal = "0";
                    if (checkBox20.Checked)
                        stopsal = "1";

                    string q = "insert into Employees (seq,stopsal,shatp,zati,edpara,fname,father,mother,lname,familystate,visacard,workplace,usersubject,motkaed" +
                                                          ",paymaster,salarycut,nowwork,department,work,savingcut,savingsystem,feah,level,degree,endsalary" +
                                                          ",note)" +
                                   "values ("+ seq +","+ stopsal +",'" + dbed2.Text + "','" + dbed3.Text + "','" + dbed4.Text + "','" + dbed5.Text + "'," +
                                   "'" + dbed6.Text + "','" + dbed7.Text + "','" + dbed8.Text + "','" + cbox4.Text + "','" + textBox25.Text + "'," +
                                   "'" + cbox5.Text + "','" + cbox6.Text + "'," + motkaed + ",'" + cbox1.Text + "'," + dbed10.Text + "," +
                                   "'" + cbox2.Text + "','" + cboxk.Text + "','" + cbox3.Text + "','" + dbed11.Text + "','" + cbox7.Text + "'," +
                                   "'" + cbox8.Text + "','" + cbox9.Text + "','" + cbox10.Text + "', 0 ,'" + textBox1.Text + "' )";
                    
                    mycon.Commoand(q);
                    //MessageBox.Show("تمت الاضافة بنجاح");
                    fillarrayid();
                    string res = mycon.getonevalue("select max(id) from Employees");
                    dbed1.Text = res;
                    textBox26.Text = "تمت الاضافة";
                    searchbyname();
                    id_box.Text = res;
                    id_box.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show("هناك خلل في عملية الاضافة تأكد من المدخلات من فضلك"); }
        }
        
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbed1.Text.Trim() != "")
                {
                    if (DialogResult.Yes == MessageBox.Show("هل تريد تأكيد الحذف", "حذف موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string q1 = "delete from Employees where id=" + dbed1.Text + "  ";
                        mycon.Commoand(q1);
                        string idd = dbed1.Text;
                        fillarrayid();
                        clearalltools();
                        textBox26.Text = "تم الحذف";
                        searchbyname();
                        id_box.Text = idd;
                    }
                }
            }
            catch (Exception er) { MessageBox.Show("هناك خلل في عملية الحذف تأكد من المدخلات"); }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            dbed44.Enabled = !dbed44.Enabled;
            dbed45.Enabled = !dbed45.Enabled;
            dbed46.Enabled = !dbed46.Enabled;
            dbed44.Text = "0"; dbed45.Text = "0"; dbed46.Text = "0";
        }
        //search for employee data
        //_______________________________________________________________________________________________________________________________
        public void searchbyname()
        {
            try
            {
                    //string name1 = textBox26.Text + "%";
                    DataTable dt = mycon.myselect_ds("select id,fname,lname from Employees ");
                    if (dt.Rows.Count > 0)
                    {
                        comboBox1.Items.Clear();
                        id_name_arr.Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(dt.Rows[i]["fname"].ToString().Trim() + " " + dt.Rows[i]["lname"].ToString().Trim());
                            id_name_arr.Add(dt.Rows[i]["id"].ToString());
                        }
                        //MessageBox.Show(id_name_arr.Count.ToString());
                        //comboBox1.SelectedIndex = 0;
                    }
                    else
                        textBox26.SelectAll();
            }
            catch(Exception eee) { MessageBox.Show("تأكد من المدخلات يوجد خلل في عملية البحث بالاسم"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                id_box.Text= id_name_arr[comboBox1.SelectedIndex].ToString();
                button17_Click(null, null);//search by id
                textBox26.Text = "";
                comboBox1.Focus();
            }
            catch { }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            searchbyname();
        }

        //__________________________________________________________________________________________________________________
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox25.Enabled = !textBox25.Enabled;
            if (!textBox25.Enabled)
                textBox25.Text = "no";
            else
            {
                textBox25.Text = "";
                textBox25.Focus();
            }
        }
      
        private void textBox26_Click(object sender, EventArgs e)
        {
            textBox26.SelectAll();
        }

        private void dbed10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////
                //dbed11.Text = dt.Rows[0]["savingcut"].ToString().Trim();
                if (dbed1.Text.Trim() != "")
                {
                    double d = Convert.ToInt32(dbed10.Text) * 7 / 100;
                    dbed11.Text = Math.Round(d).ToString();
                }
                //////////////////////////////////////
            }
            catch { }
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {
            if (id_box.Text != "")
            {
                try
                {
                    for (int x = 0; x < arid.Count; x++)
                        if (int.Parse(arid[x].ToString()) == int.Parse(id_box.Text)) index = x;
                    collectDataTime_ValueChanged(null, null);
                }
                catch (Exception exp) { MessageBox.Show("لا يوجد موظف يهذا الرقم !!"); }
            }
        }

        //Newwwwww________________________________________________________________________________________________________________________________
        private void button1_Click(object sender, EventArgs e)
        {
            clearalltools();
        }

        private void Salary_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.salary_f = 1;
        }

        //clear all******************
        private void clearalltools()
        {
            checkBox9.Checked = false;
            ///////////////////////////////////////////////////
            //Totals
            //safe.Text = "End Salary"; 
            textBox46.Text = "total"; textBox47.Text = "total";
            textBox48.Text = "total"; textBox49.Text = "total"; textBox50.Text = "total";
            //kest.Text = "0"; //textBox54.Text = "0"; 
            //hasem.Text = "0";
            //textBox57.Text = "0"; 
            //kard.Text = "0"; 
            textBox58.Text = "total";
            //tawed.Text = "0";
            //------------------------------------------------
            //id_box.Text = "";
            comboBox1.Text = "";//names after search
            textBox26.Text = "";//name
            //---------------------------------------------------------------------------employee
            checkBox20.Checked = false;
            textBox60.Text = "";
            dbed2.Text = ""; dbed3.Text = ""; dbed4.Text = "";
            dbed5.Text = ""; dbed6.Text = ""; dbed7.Text = "";
            dbed8.Text = ""; cbox4.SelectedIndex=0; textBox25.Text = "no";
            cbox5.Text = ""; cbox6.SelectedIndex=0; checkBox2.Checked = false;
            cbox1.Text = ""; dbed10.Text = ""; cbox2.Text = "";
            cboxk.Text = ""; cbox3.Text = ""; dbed11.Text = "";
            cbox7.SelectedIndex = 0; cbox8.SelectedIndex =0; cbox9.Text = "";
            cbox10.Text = ""; textBox1.Text = ""; checkBox3.Checked = false;
            //---------------------------------------------------------------------------hasm cut
             dbed24.Text = "0";
            dbed25.Text = "0";
            dbed23.Text = "0"; dbed22.Text = "0"; dbed17.Text = "0";
            dbed18.Text = "0"; dbed19.Text = "0"; dbed21.Text = "0";
            dbed20.Text = "0"; 
             dbed31.Text = "0"; dbed1.Text = "";
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox12.Checked = false; checkBox13.Checked = false; checkBox14.Checked = false;
            checkBox15.Checked = false;  checkBox17.Checked = false; 
            //---------------------------------------------------------------------------tawed
            checkBox21.Checked = true; checkBox21.Checked = false;
            checkBox22.Checked = true; checkBox22.Checked = false;
            checkBox23.Checked = true; checkBox23.Checked = false;
            checkBox36.Checked = true; checkBox36.Checked = false;

            textBox59.Text = "0";//total tawed family
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox40.Checked = false;
            textBox2.Text = "0";

            checkBox1.Checked = true; checkBox1.Checked = false;
            dbed44.Text = "0"; dbed45.Text = "0"; dbed46.Text = "0";

            dbed43.Text = "0";
            dbed444.Text = "0";

            //---------------------------------------------------------------------------Aksat           
            checkBox51.Checked = false;
            checkBox52.Checked = false;
            checkBox53.Checked = false;
            checkBox54.Checked = false;
            checkBox55.Checked = false;
            checkBox56.Checked = false;
            checkBox57.Checked = false;

            dateTimePicker10.Value = DateTime.Now;
            dateTimePicker17.Value = DateTime.Now;
            dbed112.Text = "";
            textBox17.Text = "";
            dbed119.Text = "";

            dateTimePicker11.Value = DateTime.Now;
            dateTimePicker18.Value = DateTime.Now;
            dbed113.Text = "";
            textBox18.Text = "";
            dbed120.Text = "";

            dateTimePicker12.Value = DateTime.Now;
            dateTimePicker19.Value = DateTime.Now;
            dbed114.Text = "";
            textBox19.Text = "";
            dbed121.Text = "";

            dateTimePicker13.Value = DateTime.Now;
            dateTimePicker20.Value = DateTime.Now;
            dbed115.Text = "";
            textBox20.Text = "";
            dbed122.Text = "";

            dateTimePicker14.Value = DateTime.Now;
            dateTimePicker21.Value = DateTime.Now;
            dbed116.Text = "";
            textBox21.Text = "";
            dbed123.Text = "";

            dateTimePicker15.Value = DateTime.Now;
            dateTimePicker22.Value = DateTime.Now;
            dbed117.Text = "";
            textBox22.Text = "";
            dbed124.Text = "";

            dateTimePicker16.Value = DateTime.Now;
            dateTimePicker23.Value = DateTime.Now;
            dbed118.Text = "";
            textBox23.Text = "";
            dbed125.Text = "";

            //---------------------------------------------------------------------------loan
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            checkBox43.Checked = false;
            checkBox44.Checked = false;

            dbed47.Value = DateTime.Now;
            dbed69.Value = DateTime.Now;
            dbed53.Text = ""; dbed61.Text = "";
            textBox16.Text = "";//select from loan
            dbed57.Text = ""; dbed51.Text = "";

            dbed48.Value = DateTime.Now;
            dbed70.Value = DateTime.Now;
            dbed54.Text = ""; dbed62.Text = "";
            dbed58.Text = ""; cbox11.Text = "";
            textBox15.Text = "";//select from loan

            dbed49.Value = DateTime.Now;
            dbed71.Value = DateTime.Now;
            dbed55.Text = ""; dbed63.Text = "";
            dbed59.Text = ""; cbox12.Text = "";
            textBox14.Text = "";//select from loan

            dbed50.Value = DateTime.Now;
            dbed72.Value = DateTime.Now;
            dbed56.Text = ""; dbed64.Text = "";
            dbed60.Text = ""; dbed52.Text = "";
            textBox13.Text = "";//select from loan

            checkBox10.Checked = false;//tejary
            dateTimePicker26.Value = DateTime.Now;
            dateTimePicker25.Value = DateTime.Now;

            textBox31.Text = ""; textBox29.Text = "";
            textBox27.Text = ""; textBox30.Text = "";
            textBox32.Text = "";//select from loan

            checkBox11.Checked = false;//zwaj
            dateTimePicker28.Value = DateTime.Now;
            dateTimePicker27.Value = DateTime.Now;

            textBox37.Text = ""; textBox35.Text = "";
            textBox33.Text = ""; textBox36.Text = "";
            textBox38.Text = "";//select from loan

            checkBox17.Checked = false;//sulfa
            dateTimePicker30.Value = DateTime.Now;
            dateTimePicker29.Value = DateTime.Now;

            textBox43.Text = ""; textBox41.Text = "";
            textBox39.Text = ""; textBox42.Text = "";
            textBox44.Text = "";//select from loan
            //---------------------------------------------------------------------------hasmeat
            checkBox45.Checked = false;
            checkBox46.Checked = false;
            checkBox47.Checked = false;
            checkBox48.Checked = false;
            checkBox49.Checked = false;
            checkBox50.Checked = false;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dbed77.Text = "";
            textBox9.Text = "";//select from hasmeat
            dbed80.Text = "";

            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            dbed78.Text = "";
            textBox11.Text = "";//select from hasmeat
            dbed81.Text = "";
            textBox24.Text = "";

            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker6.Value = DateTime.Now;
            dbed79.Text = "";
            textBox12.Text = "";//select from hasmeat
            dbed82.Text = "";

            //===================================================================================================okoba
            dateTimePicker7.Value = DateTime.Now;
            dbed89.Text = "";
            textBox45.Text = "";//select from hasmeat
            dbed95.Text = "";

            dateTimePicker8.Value = DateTime.Now;
            dbed90.Text = "";
            dbed93.Text = "";//select from hasmeat
            dbed96.Text = "";

            dateTimePicker9.Value = DateTime.Now;
            dbed91.Text = "";
            dbed94.Text = "";//select from hasmeat
            dbed97.Text = "";
            //===================================================================================================

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dbed17.Enabled = !dbed17.Enabled;
            dbed17.Text = "0";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            dbed18.Enabled = !dbed18.Enabled;
            dbed18.Text = "0";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            dbed19.Enabled = !dbed19.Enabled;
            dbed19.Text = "0";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            dbed20.Enabled = !dbed20.Enabled;
            dbed20.Text = "0";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            dbed21.Enabled = !dbed21.Enabled;
            dbed21.Text = "0";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            dbed22.Enabled = !dbed22.Enabled;
            dbed22.Text = "0";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            dbed23.Enabled = !dbed23.Enabled;
            dbed23.Text = "0";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            dbed24.Enabled = !dbed24.Enabled;
            dbed24.Text = "0";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            dbed25.Enabled = !dbed25.Enabled;
            dbed25.Text = "0";
        }

        //_______________________________________________________________________________________________________________________________________
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            dbed33.Enabled = !dbed33.Enabled;
            dbed33.Text = "0";
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            dbed34.Enabled = !dbed34.Enabled;
            dbed34.Text = "0";
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            dbed35.Enabled = !dbed35.Enabled;
            dbed35.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void id_box_Enter(object sender, EventArgs e)
        {
            id_box.SelectAll();
        }
        //__________________________________________________>>
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (countid != 0)
                {
                    index = 0;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }
        //__________________________________________________>
        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index = index - 1;
                    id_box.Text = arid[index].ToString();
                    button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }
        //__________________________________________________<
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < countid - 1)
                {
                    index = index + 1;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }
        //__________________________________________________<<
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (countid != 0)
                {
                    index = countid - 1;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }
        //_____________________________________________________________________________________________________________________________________
        private void id_box_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    button17_Click(null, null);
                    comboBox1.Text = "";
                    id_box.Focus();
                    id_box.SelectAll();
                }
                else if (e.KeyData == Keys.Up)
                {
                    if (index > 0)
                    {
                        index = index - 1;
                        id_box.Text = arid[index].ToString();
                        button17_Click(null, null);
                    }
                    comboBox1.Text = "";
                    id_box.Focus();
                    id_box.SelectAll();
                }
                else if (e.KeyData == Keys.Down)
                {
                    if (index < countid - 1)
                    {
                        index = index + 1;
                        //MessageBox.Show(dtid.Rows.Count.ToString());
                        id_box.Text = arid[index].ToString();
                        button17_Click(null, null);
                    }
                    comboBox1.Text = "";
                    id_box.Focus();
                    id_box.SelectAll();
                }
                else if (e.KeyData == Keys.End)
                {
                    if (countid != 0)
                    {
                        index = countid - 1;
                        //MessageBox.Show(dtid.Rows.Count.ToString());
                        id_box.Text = arid[index].ToString();
                        button17_Click(null, null);
                    }
                    comboBox1.Text = "";
                    id_box.Focus();
                    id_box.SelectAll();
                }
                else if (e.KeyData == Keys.Home)
                {
                    if (countid != 0)
                    {
                        index = 0;
                        //MessageBox.Show(dtid.Rows.Count.ToString());
                        id_box.Text = arid[index].ToString();
                        button17_Click(null, null);
                    }
                    comboBox1.Text = "";
                    id_box.Focus();
                    id_box.SelectAll();
                }
            }
            catch { }
        }

        private void textBox26_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.GetCultureInfo("ar-Sy"));
            textBox26.SelectAll();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            button14.Enabled = !button14.Enabled;//زر حساب الراتب مع قطع القروض والاقساط
            dateTimePicker24.Enabled = !dateTimePicker24.Enabled;
            label29.Enabled = !label29.Enabled;
            //button24.Enabled = !button24.Enabled;
        }

        //############ This is perfict

        //search for employee data
        private void button17_Click(object sender, EventArgs e)
        {
                if (id_box.Text.Trim() != "")
                {
                    string id = id_box.Text;
                    DataTable dt = mycon.myselect_ds("select * from Employees where id=" + id + " ");

                    clearalltools();

                    if (dt.Rows.Count > 0)
                    {
                        textBox60.Text = dt.Rows[0]["seq"].ToString().Trim();
                        if (dt.Rows[0]["stopsal"].ToString().Trim() == "1")
                            checkBox20.Checked = true;
                        dbed1.Text = dt.Rows[0]["id"].ToString().Trim();
                        dbed2.Text = dt.Rows[0]["shatp"].ToString().Trim();
                        dbed3.Text = dt.Rows[0]["zati"].ToString().Trim();
                        dbed4.Text = dt.Rows[0]["edpara"].ToString().Trim();
                        dbed5.Text = dt.Rows[0]["fname"].ToString().Trim();
                        dbed6.Text = dt.Rows[0]["father"].ToString().Trim();
                        dbed7.Text = dt.Rows[0]["mother"].ToString().Trim();
                        dbed8.Text = dt.Rows[0]["lname"].ToString().Trim();

                        if (dt.Rows[0]["motkaed"].ToString().Trim() == "1")
                            checkBox2.Checked = true;
                        else
                            checkBox2.Checked = false;

                        if (dt.Rows[0]["visacard"].ToString().Trim() != "no")
                        {
                            checkBox3.Checked = true;
                            textBox25.Text = dt.Rows[0]["visacard"].ToString().Trim();
                        }
                        else
                            checkBox3.Checked = false;

                        dbed10.Text = dt.Rows[0]["salarycut"].ToString().Trim();
                        //////////////////////////////////////
                        //dbed11.Text = dt.Rows[0]["savingcut"].ToString().Trim();
                        if (dbed1.Text.Trim() != "")
                        {
                            double d = Convert.ToInt32(dbed10.Text) * 7 / 100;
                            dbed11.Text = Math.Round(d).ToString();
                        }
                        //////////////////////////////////////
                        cbox1.Text = dt.Rows[0]["paymaster"].ToString().Trim();
                        cbox2.Text = dt.Rows[0]["nowwork"].ToString().Trim();
                        cbox3.Text = dt.Rows[0]["work"].ToString().Trim();
                        cbox4.Text = dt.Rows[0]["familystate"].ToString().Trim();
                        cbox5.Text = dt.Rows[0]["workplace"].ToString().Trim();
                        cbox6.Text = dt.Rows[0]["usersubject"].ToString().Trim();
                        cbox7.Text = dt.Rows[0]["savingsystem"].ToString().Trim();
                        cbox8.Text = dt.Rows[0]["feah"].ToString().Trim();
                        cbox9.Text = dt.Rows[0]["level"].ToString().Trim();
                        cbox10.Text = dt.Rows[0]["degree"].ToString().Trim();
                        cboxk.Text = dt.Rows[0]["department"].ToString().Trim();
                        textBox1.Text = dt.Rows[0]["note"].ToString().Trim();
                        //MessageBox.Show("1");
                        //dbed1.Text = dt.Rows[0]["seq"].ToString().Trim();

                        DataTable dt1 = mycon.myselect_ds("select * from Hasmcut where idemployee=" + id + "");
                        if (dt1.Rows.Count > 0)
                        {
                            dbed24.Text = dt1.Rows[0]["nakaptamalishare"].ToString().Trim();
                            dbed25.Text = dt1.Rows[0]["nakaptentefa"].ToString().Trim();
                            dbed23.Text = dt1.Rows[0]["nakaptzerai"].ToString().Trim();
                            dbed22.Text = dt1.Rows[0]["nakaptmohands"].ToString().Trim();
                            dbed17.Text = dt1.Rows[0]["estemartamali"].ToString().Trim();
                            dbed18.Text = dt1.Rows[0]["estemartbaladi"].ToString().Trim();
                            dbed19.Text = dt1.Rows[0]["jeshtahrer"].ToString().Trim();
                            dbed21.Text = dt1.Rows[0]["tabeaamali"].ToString().Trim();
                            dbed20.Text = dt1.Rows[0]["tabeamali"].ToString().Trim();
                            //dbed32.Text = dt1.Rows[0]["deferenthasm"].ToString().Trim();
                            dbed31.Text = dt1.Rows[0]["frokat"].ToString().Trim();
                            //string total = dt1.Rows[0]["total"].ToString().Trim();
                        }
                        //MessageBox.Show("2");

                        DataTable dt2 = mycon.myselect_ds("select * from Tawed where idemployee=" + id + "");
                        if (dt2.Rows.Count > 0)
                        {
                            dbed33.Text = dt2.Rows[0]["tawedekhtesas"].ToString().Trim();
                            //MessageBox.Show(dt2.Rows[0]["tawedekhtesas"].ToString().Trim());
                            dbed34.Text = dt2.Rows[0]["tawedtabeah"].ToString().Trim();
                            dbed35.Text = dt2.Rows[0]["tawedmasol"].ToString().Trim();
                            dbed43.Text = dt2.Rows[0]["tawedother"].ToString().Trim();
                            dbed444.Text = dt2.Rows[0]["forokat"].ToString().Trim();
                            int totalfamily111 = 0;
                            if (Convert.ToBoolean(dt2.Rows[0]["child1"]))
                            {
                                checkBox36.Checked = true;
                                totalfamily111 += 200;
                            }
                            if (Convert.ToBoolean(dt2.Rows[0]["child2"]))
                            {
                                checkBox37.Checked = true;
                                totalfamily111 += 150;
                            }
                            if (Convert.ToBoolean(dt2.Rows[0]["child3"]))
                            {
                                checkBox38.Checked = true;
                                totalfamily111 += 100;
                            }
                            if (Convert.ToBoolean(dt2.Rows[0]["wife"]))
                            {
                                checkBox40.Checked = true;
                                totalfamily111 += 300;
                            }
                            textBox2.Text = dt2.Rows[0]["numberchild"].ToString().Trim();
                            totalfamily111 += 25 * Convert.ToInt32(textBox2.Text);
                            textBox59.Text = totalfamily111.ToString();

                            dbed44.Text = dt2.Rows[0]["numberday"].ToString().Trim();
                            dbed45.Text = dt2.Rows[0]["valueedafi"].ToString().Trim();
                            dbed46.Text = dt2.Rows[0]["tax"].ToString().Trim();
                            //string total = dt2.Rows[0]["total"].ToString().Trim();
                        }
                        //MessageBox.Show("3");
                        //loan ###########

                        DataTable dt3 = mycon.myselect_ds("select * from Loan where idemployee=" + id + " and finish=0 ");
                        if (dt3.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt3.Rows.Count; i++)
                            {
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "kardakari")//kardakari
                                {
                                    checkBox41.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dbed47.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dbed69.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed53.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    dbed61.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox16.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    dbed57.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    dbed51.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "taslefshabi")//taslefshabi
                                {
                                    checkBox42.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dbed48.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dbed70.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed54.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    dbed62.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox15.Text = dt3.Rows[i]["restvalue"].ToString().Trim();
                                    dbed58.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    cbox11.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "toferbareed")//toferbareed
                                {
                                    checkBox43.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dbed49.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dbed71.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed55.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    dbed63.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox14.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    dbed59.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    cbox12.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "kardnakaba")//kardnakaba
                                {
                                    checkBox44.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dbed50.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dbed72.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed56.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    dbed64.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox13.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    dbed60.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    dbed52.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "tejary")//tejary
                                {
                                    checkBox10.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker26.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker25.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    textBox31.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    textBox29.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox27.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    textBox30.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    textBox32.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "zwaj")//zwaj
                                {
                                    checkBox11.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker28.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker27.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    textBox37.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    textBox35.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox33.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    textBox36.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    textBox38.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                                if (dt3.Rows[i]["typeloan"].ToString().Trim() == "sulfa")//sulfa
                                {
                                    checkBox17.Checked = true;
                                    string month1 = dt3.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt3.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker30.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt3.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt3.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker29.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    textBox43.Text = dt3.Rows[i]["idloan"].ToString().Trim();
                                    textBox41.Text = dt3.Rows[i]["payvalue"].ToString().Trim();
                                    textBox39.Text = dt3.Rows[i]["restvalue"].ToString().Trim();//select from loan+++++++++++++++++++++
                                    textBox42.Text = dt3.Rows[i]["loanvalue"].ToString().Trim();
                                    textBox44.Text = dt3.Rows[i]["placeloan"].ToString().Trim();
                                }
                            }//for
                        }
                        //hasmeat##########
                        //MessageBox.Show("hasmeat");
                        
                        DataTable dt4 = mycon.myselect_ds("select * from Hasmeat where idemployee=" + id + " and finish=0 ");
                        if (dt4.Rows.Count > 0)
                        {
                            //MessageBox.Show("hasmeat");
                            for (int i = 0; i < dt4.Rows.Count; i++)
                            {
                                if (dt4.Rows[i]["typehasm"].ToString().Trim() == "thema")//thema
                                {
                                    checkBox45.Checked = true;
                                    string month1 = dt4.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt4.Rows[i]["year1"].ToString().Trim().Trim();
                                    dateTimePicker1.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt4.Rows[i]["month2"].ToString().Trim().Trim();
                                    string year2 = dt4.Rows[i]["year2"].ToString().Trim().Trim();
                                    dateTimePicker4.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed77.Text = dt4.Rows[i]["payvalue"].ToString().Trim();
                                    textBox9.Text = dt4.Rows[i]["restvalue"].ToString().Trim();//select from hasmeat 
                                    dbed80.Text = dt4.Rows[i]["totalvalue"].ToString().Trim();
                                    //string krartext = "";
                                }
                                if (dt4.Rows[i]["typehasm"].ToString().Trim() == "khedma")//khedma
                                {
                                    checkBox46.Checked = true;
                                    string month1 = dt4.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt4.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker2.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt4.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt4.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker5.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed78.Text = dt4.Rows[i]["payvalue"].ToString().Trim();
                                    textBox11.Text = dt4.Rows[i]["restvalue"].ToString().Trim();//select from hasmeat 
                                    dbed81.Text = dt4.Rows[i]["totalvalue"].ToString().Trim();
                                    textBox24.Text = dt4.Rows[i]["krartext"].ToString().Trim();
                                    //MessageBox.Show(dt4.Rows[i]["krartext"].ToString().Trim());
                                }
                                if (dt4.Rows[i]["typehasm"].ToString().Trim() == "tanfiz")//tanfiz
                                {
                                    checkBox47.Checked = true;
                                    string month1 = dt4.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt4.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker3.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt4.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt4.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker6.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed79.Text = dt4.Rows[i]["payvalue"].ToString().Trim();
                                    textBox12.Text = dt4.Rows[i]["restvalue"].ToString().Trim();//select from hasmeat 
                                    dbed82.Text = dt4.Rows[i]["totalvalue"].ToString().Trim();
                                    //dbed777.Text = "";
                                }
                            }//for
                        }//if count
                        //-----------------------------------------------------------------------------------------
                        
                        DataTable dt5 = mycon.myselect_ds("select * from Okobaejaza where idemployee=" + id + "");
                        if (dt5.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt5.Rows.Count; i++)
                            {
                                if (dt5.Rows[i]["type"].ToString().Trim() == "okoba")//okoba
                                {
                                    checkBox48.Checked = true;
                                    string month1 = dt5.Rows[i]["month"].ToString().Trim();
                                    string year1 = dt5.Rows[i]["year"].ToString().Trim();
                                    dateTimePicker7.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    dbed89.Text = dt5.Rows[i]["percent1"].ToString().Trim();
                                    textBox45.Text = dt5.Rows[i]["daynumber"].ToString().Trim();
                                    dbed95.Text = dt5.Rows[i]["total"].ToString().Trim();
                                    //-----------------------------------------------------
                                }
                                if (dt5.Rows[i]["type"].ToString().Trim() == "ejaza")//ejaza
                                {
                                    checkBox49.Checked = true;
                                    string month1 = dt5.Rows[i]["month"].ToString().Trim();
                                    string year1 = dt5.Rows[i]["year"].ToString().Trim();
                                    dateTimePicker8.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    dbed90.Text = dt5.Rows[i]["percent1"].ToString().Trim();
                                    dbed93.Text = dt5.Rows[i]["daynumber"].ToString().Trim();
                                    dbed96.Text = dt5.Rows[i]["total"].ToString().Trim();
                                    //-----------------------------------------------------
                                }
                                if (dt5.Rows[i]["type"].ToString().Trim() == "sehea")//sehea
                                {
                                    checkBox50.Checked = true;
                                    string month1 = dt5.Rows[i]["month"].ToString().Trim();
                                    string year1 = dt5.Rows[i]["year"].ToString().Trim();
                                    dateTimePicker9.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    dbed91.Text = dt5.Rows[i]["percent1"].ToString().Trim();
                                    dbed94.Text = dt5.Rows[i]["daynumber"].ToString().Trim();
                                    dbed97.Text = dt5.Rows[i]["total"].ToString().Trim();
                                    //-----------------------------------------------------
                                }
                            }
                        }
                        //aksat##############
                        
                        DataTable dt6 = mycon.myselect_ds("select * from Kest where idemployee=" + id + " and finish=0 ");
                        if (dt6.Rows.Count > 0)
                        {
                            //MessageBox.Show("");
                            for (int i = 0; i < dt6.Rows.Count; i++)
                            {
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "salttajzea")//salttajzea
                                {
                                    checkBox51.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker10.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker17.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed112.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox17.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed119.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "wahdaershadia")//wahdaershadia
                                {
                                    checkBox52.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker11.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker18.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed113.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox18.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed120.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "jameaesthlaki")//jameaesthlaki
                                {
                                    checkBox53.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker12.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker19.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed114.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox19.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed121.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "saltsndos")//saltsndos
                                {
                                    checkBox54.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker13.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker20.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed115.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox20.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed122.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "jameasakania")//jameasakania
                                {
                                    checkBox55.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker14.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker21.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed116.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox21.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed123.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "estmlakbaladia")//estmlakbaladia
                                {
                                    checkBox56.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker15.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker22.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed117.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox22.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed124.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                                if (dt6.Rows[i]["typekest"].ToString().Trim() == "otherhasmeat")//hasmeat other
                                {
                                    checkBox57.Checked = true;
                                    string month1 = dt6.Rows[i]["month1"].ToString().Trim();
                                    string year1 = dt6.Rows[i]["year1"].ToString().Trim();
                                    dateTimePicker16.Value = Convert.ToDateTime("1/" + month1 + "/" + year1);
                                    string month2 = dt6.Rows[i]["month2"].ToString().Trim();
                                    string year2 = dt6.Rows[i]["year2"].ToString().Trim();
                                    dateTimePicker23.Value = Convert.ToDateTime("1/" + month2 + "/" + year2);
                                    //-----------------------------------------------------
                                    dbed118.Text = dt6.Rows[i]["payvalue"].ToString().Trim();
                                    textBox23.Text = dt6.Rows[i]["restvalue"].ToString().Trim();//select from kest
                                    dbed125.Text = dt6.Rows[i]["kestvalue"].ToString().Trim();
                                    //dt6.Rows[i]["placekest"].ToString().Trim();
                                }
                            }//for
                            //button11_Click(null, null);//total sal
                        }//if

                        id_box.Focus();
                        id_box.SelectAll();
                    }
                    else
                    {
                        id_box.Text = "لايوجد بيانات بهذا الرقم";
                        id_box.SelectAll();
                    }
                }//id_box.text==""
        }

        //update Employee
        private void button19_Click(object sender, EventArgs e)
        {
                if (dbed1.Text.Trim() != "")
                {
                    string motkaed = "0";
                    if (checkBox2.Checked)
                        motkaed = "1";
                    string seq = "0";

                    if (textBox60.Text.Trim() != "")
                        seq = textBox60.Text;

                    string stopsal = "0";
                    if (checkBox20.Checked)
                        stopsal = "1";
                    //MessageBox.Show("asas");
                    string q1 = "update Employees set seq=" + seq + ",stopsal=" + stopsal + ", shatp='" + dbed2.Text + "', zati='" + dbed3.Text + "', edpara='" + dbed4.Text + "',fname='" + dbed5.Text + "'," +
                               "father='" + dbed6.Text + "',mother='" + dbed7.Text + "',lname='" + dbed8.Text + "',visacard='" + textBox25.Text + "',familystate='" + cbox4.Text + "'," +
                               "workplace='" + cbox5.Text + "',usersubject='" + cbox6.Text + "',motkaed=" + motkaed + ",paymaster='" + cbox1.Text + "', salarycut=" + dbed10.Text + "," +
                               "nowwork='" + cbox2.Text + "',department='" + cboxk.Text + "',work='" + cbox3.Text + "' ,savingsystem='" + cbox7.Text + "'," +
                               "feah='" + cbox8.Text + "',level='" + cbox9.Text + "',degree='" + cbox10.Text + "',note='" + textBox1.Text + "' where id=" + dbed1.Text + "  ";
                    mycon.Commoand(q1);
                    searchbyname();
                    textBox26.Text = "تم التعديل";
                }
        }

        //insert and update hasmcut__________________________________________________________________________________________________________________________
        private void button7_Click(object sender, EventArgs e)
        {
                //datetimenow  for all *

                int sal = Convert.ToInt32(dbed10.Text);//الراتب المقطوع
                string empid = dbed1.Text;
                //#####################################
                //int dareptdakhl = collect_dareptdakhl(sal, year, month);
                //#########################################
                //int saving = Convert.ToInt32(Math.Round(Convert.ToDouble(dbed29.Text) * sal / 100, MidpointRounding.AwayFromZero));
                //#########################################
                int count_motkaed = Convert.ToInt32(mycon.getonevalue("select motkaedCount from Options where id=1"));
                int nakaptamalishare1 = Convert.ToInt32(mycon.getonevalue("select omaleshtrak1 from Options where id=1"));
                int nakaptamalishare2 = Convert.ToInt32(mycon.getonevalue("select omaleshtrak2 from Options where id=1"));
                int nakaptamalishare_1_2 =
                   Convert.ToInt32(Math.Round(Convert.ToDouble(dbed24.Text) * sal / 100)) + nakaptamalishare1 + nakaptamalishare2 + count_motkaed * 15;
                //#########################################
                int nakaptentefa = Convert.ToInt32(Math.Round(Convert.ToDouble(dbed25.Text) * sal / 100));
                //#########################################
                int nakaptzerai = Convert.ToInt32(Math.Round(Convert.ToDouble(dbed23.Text) * sal / 100));
                //#########################################
                int nakaptmohands = Convert.ToInt32(Math.Round(Convert.ToDouble(dbed22.Text) * sal / 100));
                //#########################################
                int estemartamali = Convert.ToInt32(dbed17.Text);
                int estemartbaladi = Convert.ToInt32(dbed18.Text);
                int jeshtahrer = Convert.ToInt32(dbed19.Text);
                int tabeaamali = Convert.ToInt32(dbed21.Text);
                int tabeamali = Convert.ToInt32(dbed20.Text);
                //int takafolbox = Convert.ToInt32(dbed28.Text);
                //int helpbox = Convert.ToInt32(dbed26.Text);
                //int deferenthasm = Convert.ToInt32(dbed32.Text);
                int frokat = Convert.ToInt32(dbed31.Text);
                ////estemartamali==sknamali  estemartbaladi==majlesmadenh
                int total = nakaptamalishare_1_2 + nakaptentefa + nakaptmohands + nakaptzerai + estemartamali + estemartbaladi
                           + jeshtahrer + tabeaamali + tabeamali + frokat;
                //MessageBox.Show("مجموع الحسميات : " + total.ToString().Trim());
                textBox47.Text = total.ToString();
                //--------------------------------------
                string res = mycon.getonevalue("select count(*) from Hasmcut where idemployee=" + empid + " ");
                if (res == "0")
                {
                    string q = "insert into Hasmcut (estemartamali,estemartbaladi,jeshtahrer,tabeamali,tabeaamali" +
                                                 ",nakaptmohands,nakaptzerai,nakaptamalishare,nakaptentefa,frokat," +
                                                 "idemployee )" +
                                   "values (" + estemartamali.ToString().Trim() + "," + estemartbaladi.ToString().Trim() + 
                                   "," + jeshtahrer.ToString().Trim() + "," + tabeamali.ToString().Trim() + "," + tabeaamali.ToString().Trim() + " ," +
                                   " " + dbed22.Text.Trim() + "," + dbed23.Text.Trim() + "," + dbed24.Text + ", " +
                                   " " + dbed25.Text.Trim() + "," + frokat.ToString().Trim() + "" +
                                   "," + empid.ToString().Trim() + ")";

                    mycon.Commoand(q);
                    //MessageBox.Show("تمت عملية الاضافة بنجاح");
                }
                else
                {
                        string q = "update hasmcut set estemartamali=" + estemartamali.ToString().Trim() + ",estemartbaladi=" + estemartbaladi.ToString().Trim() + ",jeshtahrer=" + jeshtahrer.ToString().Trim() + "," +
                                   " tabeamali=" + tabeamali.ToString().Trim() + ",tabeaamali=" + tabeaamali.ToString().Trim() + " , " +
                                   " nakaptmohands=" + dbed22.Text.Trim() + ",nakaptzerai=" + dbed23.Text.Trim() + ",nakaptamalishare=" + dbed24.Text + ", " +
                                   " nakaptentefa=" + dbed25.Text.Trim() + ",frokat=" + frokat.ToString().Trim() + " " +
                                   " where idemployee=" + empid.ToString().Trim() + " ";
                        mycon.Commoand(q);
                        //MessageBox.Show("تمت عملية التعديل بنجاح");
                }
        }

        //insert and update tawed -----------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
                //datetimenow  for all *
                //int sal = Convert.ToInt32(dbed10.Text);//الراتب المقطوع
                string empid = dbed1.Text;
                ////////
                int tawedekhtesas = Convert.ToInt32(dbed33.Text);
                //tawedekhtesas = collect_darept_TawedTabeah(sal, tawedekhtesas, 2);//حساب الضريبة عليه
                ////////
                int tawedtabeah = Convert.ToInt32(dbed34.Text);
                //tawedtabeah = collect_darept_TawedTabeah(sal, tawedtabeah, 1);//حساب الضريبة عليه
                ///////
                int tawedmasoleah =  Convert.ToInt32(dbed35.Text);
                //tawedmasoleah = collect_darept_TawedTabeah(sal, tawedmasoleah, 3);//حساب الضريبة عليه
                //------
                int othertawed = Convert.ToInt32(dbed43.Text);
                int forokat = Convert.ToInt32(dbed444.Text);
                /////////
                int tawedfamily = 0;
                string child1 = "0"; string child2 = "0"; string child3 = "0"; string child4 = "0"; string wife = "0";
                if (checkBox36.Checked)//child1
                {
                    tawedfamily += 200;
                    child1 = "1";
                }
                if (checkBox37.Checked)
                {
                    tawedfamily += 150;
                    child2 = "1";
                }
                if (checkBox38.Checked)
                {
                    tawedfamily += 100;
                    child3 = "1";
                }
                if (checkBox40.Checked)//wife
                {
                    tawedfamily += 300;
                    wife = "1";
                }
                tawedfamily += Convert.ToInt32(textBox2.Text) * 25;//other children

                textBox59.Text = tawedfamily.ToString();
                //###################################################################
                int addedwork = Convert.ToInt32(dbed44.Text) * Convert.ToInt32(dbed45.Text)
                              - Convert.ToInt32(dbed44.Text) * Convert.ToInt32(dbed46.Text);
                //###################################################################
                int total = tawedmasoleah + tawedfamily + tawedekhtesas + tawedtabeah + addedwork + othertawed + forokat;
                //MessageBox.Show(total.ToString().Trim());
                textBox46.Text = total.ToString();

                string res = mycon.getonevalue("select id from Tawed where idemployee=" + empid + " ");
                //MessageBox.Show(empid+"   "+res);
                if (res == "no")
                {
                    string q = "insert into Tawed(tawedekhtesas,tawedtabeah,tawedmasol,forokat,tawedother,numberday," +
                          "tax,valueedafi,child1,child2,child3,wife,numberchild,idemployee )" +
                          " values(" + dbed33.Text + "," + dbed34.Text + "," + tawedmasoleah.ToString().Trim() + "," +
                                 " " + forokat.ToString().Trim() + "," + othertawed.ToString().Trim() + "," + dbed44.Text + "," + dbed46.Text + "," + dbed45.Text + "," +
                                 " " + child1 + "," + child2 + "," + child3 + "," +
                                 " " + wife + "," + textBox2.Text + "," + empid + ")";
                    int i = mycon.Commoand(q);
                    // MessageBox.Show("تمت عملية الاضافة بنجاح"+i.ToString());
                }
                else
                {
                    string q = "update Tawed set tawedekhtesas=" + dbed33.Text + ",tawedtabeah=" + dbed34.Text + ",tawedmasol=" + tawedmasoleah.ToString().Trim() + "," +
                               " forokat=" + forokat.ToString().Trim() + ",tawedother=" + othertawed.ToString().Trim() + ",numberday=" + dbed44.Text + ",tax=" + dbed46.Text + ",valueedafi=" + dbed45.Text + "," +
                               " child1=" + child1 + ",child2=" + child2 + ",child3=" + child3 + ",wife=" + wife + ",numberchild=" + textBox2.Text + " where idemployee=" + empid + "";
                    mycon.Commoand(q);
                }
        }

        //insert and update loan _________________________________________________________________________________________________________________________________
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string empid = dbed1.Text;
                //string month = dateTimePicker24.Value.Month.ToString();
                //string year = dateTimePicker24.Value.Year.ToString();
                if (checkBox41.Checked)//kardakari
                {
                    string month1 = dbed47.Value.Month.ToString().Trim();
                    string year1 = dbed47.Value.Year.ToString().Trim();
                    string month2 = dbed69.Value.Month.ToString().Trim();
                    string year2 = dbed69.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = dbed53.Text;
                    string payvalue = dbed61.Text;
                    string restvalue = textBox16.Text;//select from loan
                    string type = "kardakari";
                    string loanvalue = dbed57.Text;
                    string place = dbed51.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%kardakari%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox42.Checked)//taslefshabi
                {
                    string month1 = dbed48.Value.Month.ToString().Trim();
                    string year1 = dbed48.Value.Year.ToString().Trim();
                    string month2 = dbed70.Value.Month.ToString().Trim();
                    string year2 = dbed70.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = dbed54.Text;
                    string payvalue = dbed62.Text;
                    string restvalue = textBox15.Text;//select from loan
                    string type = "taslefshabi";
                    string loanvalue = dbed58.Text;
                    string place = cbox11.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%taslefshabi%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox43.Checked)//toferbareed
                {
                    string month1 = dbed49.Value.Month.ToString().Trim();
                    string year1 = dbed49.Value.Year.ToString().Trim();
                    string month2 = dbed71.Value.Month.ToString().Trim();
                    string year2 = dbed71.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = dbed55.Text;
                    string payvalue = dbed63.Text;
                    string restvalue = textBox14.Text;//select from loan
                    string type = "toferbareed";
                    string loanvalue = dbed59.Text;
                    string place = cbox12.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%toferbareed%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox44.Checked)//kardnakaba
                {
                    string month1 = dbed50.Value.Month.ToString().Trim();
                    string year1 = dbed50.Value.Year.ToString().Trim();
                    string month2 = dbed72.Value.Month.ToString().Trim();
                    string year2 = dbed72.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = dbed56.Text;
                    string payvalue = dbed64.Text;
                    string restvalue = textBox13.Text;//select from loan
                    string type = "kardnakaba";
                    string loanvalue = dbed60.Text;
                    string place = dbed52.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%kardnakaba%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox10.Checked)//tejary
                {
                    string month1 = dateTimePicker26.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker26.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker25.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker25.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = textBox31.Text;
                    string payvalue = textBox29.Text;
                    string restvalue = textBox27.Text;//select from loan
                    string type = "tejary";
                    string loanvalue = textBox30.Text;
                    string place = textBox32.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%tejary%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox11.Checked)//zwaj
                {
                    string month1 = dateTimePicker28.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker28.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker27.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker27.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = textBox37.Text;
                    string payvalue = textBox35.Text;
                    string restvalue = textBox33.Text;//select from loan
                    string type = "zwaj";
                    string loanvalue = textBox36.Text;
                    string place = textBox38.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%zwaj%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }

                if (checkBox17.Checked)//sulfa
                {
                    string month1 = dateTimePicker30.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker30.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker29.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker29.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string loannumber = textBox43.Text;
                    string payvalue = textBox41.Text;
                    string restvalue = textBox39.Text;//select from loan
                    string type = "sulfa";
                    string loanvalue = textBox42.Text;
                    string place = textBox44.Text;

                    string res = mycon.getonevalue("select id from Loan where idemployee=" + empid + " and finish=0 and typeloan like '%sulfa%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Loan(idloan,idemployee,typeloan,placeloan,month1,year1,month2,year2,loanvalue,payvalue,restvalue,finish)" +
                                   " values (" + loannumber + "," + empid + ",'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + loanvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Loan set idloan=" + loannumber + ",placeloan='" + place + "',month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",loanvalue=" + loanvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }
            }
            catch (Exception exp) { MessageBox.Show("يوجد خلل في المدخلات"); }
        }

        //insert and update Hasmeat_______________________________________________________________________________________________________________________________
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string empid = dbed1.Text;
                //string month111 = dateTimePicker24.Value.Month.ToString().Trim();
                //string year111 = dateTimePicker24.Value.Year.ToString().Trim();

                if (checkBox45.Checked)//thema
                {
                    string month1 = dateTimePicker1.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker1.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker4.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker4.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed77.Text;
                    string restvalue = textBox9.Text;//select from hasmeat
                    string typehasm = "thema";
                    string totalvalue = dbed80.Text;
                    string krartext = "";

                    string res = mycon.getonevalue("select id from Hasmeat where idemployee=" + empid + " and finish=0 and typehasm like '%thema%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        //MessageBox.Show("1");
                        string q = "insert into Hasmeat(idemployee,typehasm,month1,year1,month2,year2,totalvalue,payvalue,restvalue,krartext,finish)" +
                                   " values (" + empid + ",'" + typehasm + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + totalvalue + "," + payvalue + "," + restvalue + ",'" + krartext + "',0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Hasmeat set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",totalvalue=" + totalvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " ,krartext='" + krartext + "' where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }
                if (checkBox46.Checked)//khedma
                {
                    string month1 = dateTimePicker2.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker2.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker5.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker5.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed78.Text;
                    string restvalue = textBox11.Text;//select from hasmeat
                    string typehasm = "khedma";
                    string totalvalue = dbed81.Text;
                    string krartext = textBox24.Text;

                    string res = mycon.getonevalue("select id from Hasmeat where idemployee=" + empid + " and finish=0 and typehasm like '%khedma%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Hasmeat(idemployee,typehasm,month1,year1,month2,year2,totalvalue,payvalue,restvalue,krartext,finish)" +
                                   " values (" + empid + ",'" + typehasm + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + totalvalue + "," + payvalue + "," + restvalue + ",'" + krartext + "',0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Hasmeat set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",totalvalue=" + totalvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " ,krartext='" + krartext + "' where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                    //collect_dareptdakhl(Convert.ToInt32(dbed10.ToString()), month111, year111);
                    //button7_Click(null, null);//refress hasmcut for dareptdahkl ++++++++++++++++++++++++++++++++++++++++++++++++++++

                }
                if (checkBox47.Checked)//tanfiz
                {
                    string month1 = dateTimePicker3.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker3.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker6.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker6.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed79.Text;
                    string restvalue = textBox12.Text;//select from hasmeat
                    string typehasm = "tanfiz";
                    string totalvalue = dbed82.Text;
                    string krartext = "";

                    string res = mycon.getonevalue("select id from Hasmeat where idemployee=" + empid + " and finish=0 and typehasm like '%tanfiz%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Hasmeat(idemployee,typehasm,month1,year1,month2,year2,totalvalue,payvalue,restvalue,krartext,finish)" +
                                   " values (" + empid + ",'" + typehasm + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + totalvalue + "," + payvalue + "," + restvalue + ",'" + krartext + "',0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Hasmeat set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",totalvalue=" + totalvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " ,krartext='" + krartext + "' where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت التعديل بنجاح");
                    }
                }
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=
                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //===================================================================================================
                string empid1 = dbed1.Text;
                //string month111 = dateTimePicker24.Value.Month.ToString().Trim();
                //string year111 = dateTimePicker24.Value.Year.ToString().Trim();
                if (checkBox48.Checked)//okoba
                {
                    string month = dateTimePicker7.Value.Month.ToString().Trim();
                    string year = dateTimePicker7.Value.Year.ToString().Trim();
                    string percent1 = dbed89.Text;
                    string daynumber = textBox45.Text;//here means number of month
                    string type = "okoba";
                    int total = 0;//after collect put it in dbed95

                    string sal1 = mycon.getonevalue("select salaycut from Salarys where id=" + empid + " and month=" + month + " and year=" + year + " ");
                    if (sal1 == "no")
                    {
                        string sal2 = mycon.getonevalue("select salaycut from Employee where id=" + empid + " ");
                        total = 1 * Convert.ToInt32(sal2) * Convert.ToInt32(percent1) / 100; //for one month
                    }
                    else
                    {
                        total = 1 * Convert.ToInt32(sal1) * Convert.ToInt32(percent1) / 100; //for one month
                    }
                    //-----------------------------------------------------
                    dbed95.Text = total.ToString();
                    //-----------------------------------------------------
                    //string res = mycon.getonevalue("select stopedit from Okobaejaza where month=" + month111 + "  and year=" + year111 + " and idemployee=" + empid1 + " and type like '%okoba%' ");
                    string resid = mycon.getonevalue("select id from Okobaejaza where stopedit=0 and idemployee=" + empid1 + " and year=" + year + " and month=" + month + " type like '%okoba%' ");
                    if (resid == "no")
                    {
                        string q = "insert into Okobaejaza (percent1,type,daynumber,idemployee,month,year,total,stopedit)" +
                              " values(" + percent1 + ",'" + type + "'," + daynumber + "," +
                                     " " + empid1 + "," + month + "," + year + "," + total + ",0 ) ";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت عملية الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Okobaejaza set percent1=" + percent1 + ",daynumber=" + daynumber + " ," +
                                   " total=" + total + " where id=" + resid + "  ";
                        int iii = mycon.Commoand(q);
                        MessageBox.Show("تمت عملية التعديل للعقوبة بنجاح");
                        //MessageBox.Show("لايمكن التعديل");
                    }
                }
                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //=======================================================================================================
                //if (checkBox49.Checked)//ejaza
                //{
                //    string month = dateTimePicker8.Value.Month.ToString().Trim();
                //    string year = dateTimePicker8.Value.Year.ToString().Trim();
                //    string percent1 = dbed90.Text;
                //    string daynumber = dbed93.Text;
                //    string type = "ejaza";
                //    int total = 0;//after collect put it in dbed96
                //    int salarycut1 = Convert.ToInt32(dbed10.Text);
                //    int tawedfamily = 0;
                //    if (textBox59.Text.Trim() == "no yet")
                //        MessageBox.Show("عليك ادخال بيانات التعويضات سلفا");
                //    else
                //    {
                //        tawedfamily = Convert.ToInt32(textBox59.Text);
                //    }
                //    total = (salarycut1 + tawedfamily - Convert.ToInt32(dbed14.Text)) / (30 * Convert.ToInt32(daynumber));
                //    //-----------------------------------------------------
                //    dbed96.Text = total.ToString();
                //    string res = mycon.getonevalue("select stopedit from Okobaejaza where month=" + month111 + "  and year=" + year111 + " and idemployee=" + empid1 + " and type like '%ejaza%' ");
                //    string resid = mycon.getonevalue("select id from Okobaejaza where month=" + month111 + "  and year=" + year111 + " and idemployee=" + empid1 + " and type like '%ejaza%' ");
                //    if (res == "no")
                //    {
                //        string q = "insert into Okobaejaza (percent1,type,daynumber,idemployee,month,year,total,stopedit)" +
                //              " values(" + percent1 + ",'" + type + "'," + daynumber + "," +
                //                     " " + empid1 + "," + month111 + "," + year111 + "," + total + ",0 ) ";
                //        mycon.Commoand(q);
                //        MessageBox.Show("تمت عملية الاضافة بنجاح");
                //    }
                //    else
                //    {
                //        if (res == "0")
                //        {
                //            string q = "update Okobaejaza set percent1=" + percent1 + ",daynumber=" + daynumber + " ," +
                //                       " total=" + total + " where id=" + resid + "  ";
                //            mycon.Commoand(q);
                //            MessageBox.Show("تمت عملية التعديل للاجازة بنجاح");
                //        }
                //        else
                //            MessageBox.Show("لايمكن التعديل");
                //    }
                //}
                //if (checkBox50.Checked)//sehea
                //{
                //    string month = dateTimePicker9.Value.Month.ToString().Trim();
                //    string year = dateTimePicker9.Value.Year.ToString().Trim();
                //    string percent1 = dbed91.Text;
                //    string daynumber = dbed94.Text;
                //    string type = "sehea";
                //    int total = 0;//after collect put it in dbed97
                //    total = Convert.ToInt32(daynumber) * Convert.ToInt32(dbed10.Text) * Convert.ToInt32(percent1) / 100;
                //    //-----------------------------------------------------
                //    dbed97.Text = total.ToString();
                //    string res = mycon.getonevalue("select stopedit from Okobaejaza where month=" + month111 + "  and year=" + year111 + " and idemployee=" + empid1 + " and type like '%sehea%' ");
                //    string resid = mycon.getonevalue("select id from Okobaejaza where month=" + month111 + "  and year=" + year111 + " and idemployee=" + empid1 + " and type like '%sehea%' ");
                //    if (res == "no")
                //    {
                //        string q = "insert into Okobaejaza (percent1,type,daynumber,idemployee,month,year,total,stopedit)" +
                //              " values(" + percent1 + ",'" + type + "'," + daynumber + "," +
                //                     " " + empid1 + "," + month111 + "," + year111 + "," + total + ",0 ) ";
                //        mycon.Commoand(q);
                //        MessageBox.Show("تمت عملية الاضافة بنجاح");
                //    }
                //    else
                //    {
                //        if (res == "0")
                //        {
                //            string q = "update Okobaejaza set percent1=" + percent1 + ",daynumber=" + daynumber + " ," +
                //                       " total=" + total + " where id=" + resid + "  ";
                //            mycon.Commoand(q);
                //            MessageBox.Show("تمت عملية التعديل للصحية بنجاح");
                //        }
                //        else
                //            MessageBox.Show("لايمكن التعديل");
                //    }
                //    //stopedit=2 ******************************************
                //}
                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++=
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            }
            catch (Exception exp) { MessageBox.Show("يوجد خلل في المدخلات"); }
        }


        //insert and update aksat __________________________________________________________________________________________________________________________________
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string empid = dbed1.Text;
                //string month = dateTimePicker24.Value.Month.ToString();
                //string year = dateTimePicker24.Value.Year.ToString();

                if (checkBox51.Checked)//salttajzea
                {
                    string month1 = dateTimePicker10.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker10.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker17.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker17.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed112.Text;
                    string restvalue = textBox17.Text;//select from kest
                    string type = "salttajzea";
                    string kestvalue = dbed119.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%salttajzea%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {

                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox52.Checked)//wahdaershadia
                {
                    string month1 = dateTimePicker11.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker11.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker18.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker18.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed113.Text;
                    string restvalue = textBox18.Text;//select from kest
                    string type = "wahdaershadia";
                    string kestvalue = dbed120.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%wahdaershadia%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox53.Checked)//jameaesthlaki
                {
                    string month1 = dateTimePicker12.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker12.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker19.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker19.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed114.Text;
                    string restvalue = textBox19.Text;//select from kest
                    string type = "jameaesthlaki";
                    string kestvalue = dbed121.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%jameaesthlaki%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox54.Checked)//saltsndos
                {
                    string month1 = dateTimePicker13.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker13.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker20.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker20.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed115.Text;
                    string type = "saltsndos";
                    string restvalue = textBox20.Text;//select from kest
                    string kestvalue = dbed122.Text;
                    string place = "";
                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%saltsndos%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox55.Checked)//jameasakania
                {
                    string month1 = dateTimePicker14.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker14.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker21.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker21.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed116.Text;
                    string restvalue = textBox21.Text;//select from kest
                    string type = "jameasakania";
                    string kestvalue = dbed123.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%jameasakania%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox56.Checked)//estmlakbaladia
                {
                    string month1 = dateTimePicker15.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker15.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker22.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker22.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed117.Text;
                    string restvalue = textBox22.Text;//select from kest
                    string type = "estmlakbaladia";
                    string kestvalue = dbed124.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%estmlakbaladia%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
                if (checkBox57.Checked)//hasmeat other
                {
                    string month1 = dateTimePicker16.Value.Month.ToString().Trim();
                    string year1 = dateTimePicker16.Value.Year.ToString().Trim();
                    string month2 = dateTimePicker23.Value.Month.ToString().Trim();
                    string year2 = dateTimePicker23.Value.Year.ToString().Trim();
                    //-----------------------------------------------------
                    string payvalue = dbed118.Text;
                    string restvalue = textBox23.Text;//select from kest
                    string type = "otherhasmeat";
                    string kestvalue = dbed125.Text;
                    string place = "";

                    string res = mycon.getonevalue("select id from Kest where idemployee=" + empid + " and finish=0 and typekest like '%otherhasmeat%'  ");//id <==> idloan in truth
                    if (res == "no")
                    {
                        string q = "insert into Kest(idemployee,idkest,typekest,placekest,month1,year1,month2,year2,kestvalue,payvalue,restvalue,finish)" +
                                   " values (" + empid + ", 1 ,'" + type + "','" + place + "'," + month1 + "," + year1 + "," + month2 + "," + year2 + "," + kestvalue + "," + payvalue + "," + restvalue + ",0)";
                        mycon.Commoand(q);
                        MessageBox.Show("تمت الاضافة بنجاح");
                    }
                    else
                    {
                        string q = "update Kest set month1=" + month1 + ",year1=" + year1 + "" +
                                   ",month2=" + month2 + ",year2=" + year2 + ",kestvalue=" + kestvalue + ",payvalue=" + payvalue + ",restvalue=" + restvalue + " where id=" + res + "";
                        mycon.Commoand(q);
                        MessageBox.Show("تم التعديل بنجاح");
                    }
                }
            }
            catch (Exception exp) { MessageBox.Show("يوجد خلل في المدخلات"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Process_f  == 1)
            {
                Process_Form = new ProsessingForm(this);
                Process_Form.MdiParent = prnt;
                Process_Form.Show();
                Process_f = 0;
            }
            else
            {
                Process_Form.Activate();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SalaryCuting cut = new SalaryCuting();
            cut.do_calc(id_box.Text,dateTimePicker24.Value.Month.ToString().Trim(),dateTimePicker24.Value.Year.ToString().Trim());
        }

        private void collectDataTime_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = mycon.myselect_ds("SELECT * FROM salarys WHERE id="+ id_box.Text +" AND month="+ collectDataTime.Value.Month +" AND year ="+ collectDataTime.Value.Year);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                cut.Text = dr["salarycut"].ToString();
                hasem.Text = dr["totalhasem"].ToString();
                tawed.Text = dr["totaltawed"].ToString();
                kard.Text = dr["totalkared"].ToString();
                kest.Text = dr["totalaksat"].ToString();
                safe.Text = dr["lastsalary"].ToString();
            }
        }

    }
}

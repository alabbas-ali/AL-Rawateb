using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AL_Rawateb
{
    public partial class EsalCutForm : Form
    {
        Master_form part;
        string usingsubject = "";
        int month;
        int year;

        ArrayList id_name_arr;
        ArrayList arid;
        DataTable dtid;
        int index = 0; int countid = 0;

        public EsalCutForm(Master_form master)
        {
            InitializeComponent();
            part = master;
        }

        private void EsalCutForm_Load(object sender, EventArgs e)
        {
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            cbox6.SelectedIndex = 0;
            fill();

            comboBox1.SelectedIndex = 0;

            arid = new ArrayList();
            id_name_arr = new ArrayList();
            fillarrayid();
            if (countid > 0)
            {
                id_box.Text = arid[index].ToString();
            }
            //searchbyname();
            id_box.Focus();
            //id_box.SelectAll();
        }

        private void EsalCutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            part.Esal_f = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            fill();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            fill();
        }

        private void cbox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox6.SelectedIndex == 0)
            {
                this.usingsubject = "";
            }
            else if (cbox6.SelectedIndex == 1)
            {
                this.usingsubject = "مثبت";
            }
            else if (cbox6.SelectedIndex == 2)
            {
                this.usingsubject = "عقد";
            }
            else
            {
                this.usingsubject = "مكلف";
            }
            fill();
        }
        private void fill()
        {
            if (cbox6.SelectedIndex == 0)
            {
                if (radioButton1.Checked == true)
                {
                    this.salarysTableAdapter.FillForAllForVisa(this.salarysDS.salarys, month, year);
                }
                else
                {
                    this.salarysTableAdapter.FillForAllNoVisa(this.salarysDS.salarys, month, year);
                }
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    this.salarysTableAdapter.FillForVisa(this.salarysDS.salarys, usingsubject, month, year);
                }
                else
                {
                    this.salarysTableAdapter.FillForNoVisa(this.salarysDS.salarys, usingsubject, month, year);
                }
            }
            fillarrayid();
        }

        private void id_box_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    id_box.Focus();
                    id_box.SelectAll();
                }
                else if (e.KeyData == Keys.Up)
                {
                    button21_Click(null, null);
                }
                else if (e.KeyData == Keys.Down)
                {
                    button18_Click(null, null);
                }
                else if (e.KeyData == Keys.End)
                {
                    button22_Click(null, null);
                }
                else if (e.KeyData == Keys.Home)
                {
                    button20_Click(null, null);
                }
            }
            catch { }
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {
            if (id_box.Text != "")
            {
                for (int x = 0; x < arid.Count; x++)
                    if (int.Parse(arid[x].ToString()) == int.Parse(id_box.Text))
                    {
                       index = x;
                       selectcard();
                    }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (countid != 0)
                {
                    index = 0;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    //button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index = index - 1;
                    id_box.Text = arid[index].ToString();
                    //button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < countid - 1)
                {
                    index = index + 1;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    //button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (countid != 0)
                {
                    index = countid - 1;
                    //MessageBox.Show(dtid.Rows.Count.ToString());
                    id_box.Text = arid[index].ToString();
                    //button17_Click(null, null);
                }
                id_box.Focus();
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                index = comboBox1.SelectedIndex;
                id_box.Text = arid[index].ToString();
            }
        }


        public void fillarrayid()
        {
            try
            {
                dtid = this.salarysDS.Tables[0];
                countid = dtid.Rows.Count;
                int total = 0;
                arid.Clear();
                index = 0;
                for (int i = 0; i < countid; i++)
                {
                    arid.Add(dtid.Rows[i]["id"].ToString());
                    total += (int)dtid.Rows[i]["lastsalary"];
                }
                if (countid == 0)
                {
                    id_box.Text = "لا يوجد أي موظف بعد";
                    //button17_Click(null, null);
                    id_box.Focus();
                }
                else
                {
                    id_box.Text = arid[0].ToString();
                }
                totalbox.Text = total + "";
            }
            catch { }
        }


        private void selectcard()
        {
            DataTable dt = this.salarysDS.Tables[0];
            DataRow dr = dt.Rows[index];
            
            //MessageBox.Show( dr["name"].ToString() );
            label51.Text = dr["name"].ToString();
            label52.Text = dr["zati"].ToString();
            label53.Text = dr["year"].ToString() + "/" + dr["month"].ToString();
            label54.Text = dr["salarycut"].ToString();
            if ((int)dr["tabeaamal"] > 0) { label55.Text = dr["tabeaamal"].ToString(); } else { label55.Text = ""; }
            if ((int)dr["darepatapea"] > 0)  {   label56.Text = dr["darepatapea"].ToString(); }else{label56.Text = ""; }
            if ((int)dr["darepadakel"] > 0)   {  label57.Text = dr["darepadakel"].ToString();}else{label57.Text = ""; }
            if ((int)dr["seha"] > 0)           { label58.Text = dr["seha"].ToString();}else{label58.Text = ""; }
            if ((int)dr["okoba"] > 0)     {      label59.Text = dr["okoba"].ToString();}else{label59.Text = ""; }
            if ((int)dr["omal"] > 0)       {     label60.Text = dr["omal"].ToString();}else{label60.Text = ""; }
            if ((int)dr["nakabtmohands"] > 0){   label61.Text = dr["nakabtmohands"].ToString();}else{label61.Text = ""; }
            if ((int)dr["taslef"] > 0)     {     label62.Text = dr["taslef"].ToString();}else{label62.Text = ""; }
            if ((int)dr["thema"] > 0)      {     label63.Text = dr["thema"].ToString();}else{label63.Text = ""; }
            if ((int)dr["totaltawed"] > 0)  {    label64.Text = dr["totaltawed"].ToString();}else{label64.Text = ""; }
            if ((int)dr["family"] > 0)      {    label65.Text = dr["family"].ToString();}else{label65.Text = ""; }
            if ((int)dr["ektesas"] > 0)      {   label66.Text = dr["ektesas"].ToString();}else{label66.Text = ""; }
            if ((int)dr["darepaektesas"] > 0) {  label67.Text = dr["darepaektesas"].ToString();}else{label67.Text = ""; }
            if ((int)dr["savingejtma"] > 0)  {   label68.Text = dr["savingejtma"].ToString();}else{label68.Text = ""; }
            if ((int)dr["ejaza"] > 0)      {     label69.Text = dr["ejaza"].ToString();}else{label69.Text = ""; }
            if ((int)dr["tanfiz"] > 0)     {     label70.Text = dr["tanfiz"].ToString();}else{label70.Text = ""; }
            if ((int)dr["solfa"] > 0)      {     label71.Text = dr["solfa"].ToString();}else{label71.Text = ""; }
            if ((int)dr["nakabazeraee"] > 0){    label72.Text = dr["nakabazeraee"].ToString();}else{label72.Text = ""; }
            if ((int)dr["kardakare"] > 0)    {   label73.Text = dr["kardakare"].ToString();}else{label73.Text = ""; }
            if ((int)dr["tawfer"] > 0)  {        label74.Text = dr["tawfer"].ToString();}else{label74.Text = ""; }
            label75.Text = ((int)dr["totalhasem"] + (int)dr["otherhasem"] + (int)dr["totalaksat"] + (int)dr["totalkared"]).ToString();
            if ((int)dr["forokattawed"] > 0){    label76.Text = dr["forokattawed"].ToString();}else{label76.Text = ""; }
            if ((int)dr["maseolea"] > 0)     {   label77.Text = dr["maseolea"].ToString();}else{label77.Text = ""; }
            if ((int)dr["darepamaseolea"] > 0){  label78.Text = dr["darepamaseolea"].ToString();}else{label78.Text = ""; }
            if ((int)dr["kedma"] > 0)       {    label79.Text = dr["kedma"].ToString();}else{label79.Text = ""; }
            if ((int)dr["otherhasem"] > 0)   {   label80.Text = dr["otherhasem"].ToString();}else{label80.Text = ""; }
            if ((int)dr["estmlakbalade"] > 0) {  label81.Text = dr["estmlakbalade"].ToString();}else{label81.Text = ""; }
            if ((int)dr["madena"] > 0)       {   label82.Text = dr["madena"].ToString();}else{label82.Text = ""; }
            if ((int)dr["tahrer"] > 0)       {   label83.Text = dr["tahrer"].ToString();}else{label83.Text = ""; }
            if ((int)dr["sakan"] > 0)         {  label84.Text = dr["sakan"].ToString();}else{label84.Text = ""; }
            if ((int)dr["tabeamali"] > 0)  {     label85.Text = dr["tabeamali"].ToString();}else{label85.Text = ""; }
            if ((int)dr["tabeaamali"] > 0)  {    label86.Text = dr["tabeaamali"].ToString();}else{label86.Text = ""; }
            if ((int)dr["lastsalary"] > 0)  {    label87.Text = dr["lastsalary"].ToString();}else{label87.Text = ""; }
            if ((int)dr["tejare"] > 0)      {    label88.Text = dr["tejare"].ToString();}else{label88.Text = ""; }
            if ((int)dr["nakaba"] > 0)      {    label89.Text = dr["nakaba"].ToString();}else{label89.Text = ""; }
            if ((int)dr["zawaj"] > 0)       {    label90.Text = dr["zawaj"].ToString();}else{label90.Text = ""; }
            if ((int)dr["sondos"] > 0)      {    label91.Text = dr["sondos"].ToString();}else{label91.Text = ""; }
            if ((int)dr["esthlake"] > 0)    {    label92.Text = dr["esthlake"].ToString();}else{label92.Text = ""; }
            if ((int)dr["sharkttajzea"] > 0) {   label93.Text = dr["sharkttajzea"].ToString();}else{label93.Text = ""; }
            if ((int)dr["salttajze"] > 0) { label94.Text = dr["salttajze"].ToString(); } else { label94.Text = ""; }
            label95.Text = dr["visacard"].ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
                    index = 0;
                    timer1.Enabled = true;
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int sheft = 0;
            Boolean shr = false;
            for (int x = 0; x < 2; x++)
            {
                id_box.Text = arid[index].ToString();
                for (int i = 0; i < 2; i++)
                {
                    shr = !shr;
                    if (shr == true) { label99.Text = "نسخة معتمد"; } else { label99.Text = "نسخة موظف"; }
                    e.Graphics.DrawString(label99.Text, label99.Font, Brushes.Black, label99.Location.X, label99.Location.Y + sheft);

                    e.Graphics.DrawLine(new Pen(Brushes.Black), label7.Location.X + label7.Width, label7.Location.Y + sheft + tableLayoutPanel1.Location.Y, label17.Location.X, label17.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label18.Location.X + label18.Width, label18.Location.Y + sheft + tableLayoutPanel1.Location.Y, label28.Location.X, label28.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label29.Location.X + label29.Width, label29.Location.Y + sheft + tableLayoutPanel1.Location.Y, label39.Location.X, label39.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label96.Location.X + label96.Width, label96.Location.Y + sheft + tableLayoutPanel1.Location.Y, label50.Location.X, label50.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label54.Location.X + label54.Width, label54.Location.Y + sheft + tableLayoutPanel1.Location.Y, label64.Location.X, label64.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label65.Location.X + label65.Width, label65.Location.Y + sheft + tableLayoutPanel1.Location.Y, label75.Location.X, label75.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label98.Location.X + label98.Width, label98.Location.Y + sheft + tableLayoutPanel1.Location.Y, label41.Location.X, label41.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label76.Location.X + label76.Width, label76.Location.Y + sheft + tableLayoutPanel1.Location.Y, label87.Location.X, label87.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label98.Location.X + label98.Width, label98.Location.Y + sheft + tableLayoutPanel1.Location.Y + label98.Height, label41.Location.X, label41.Location.Y + sheft + tableLayoutPanel1.Location.Y + label98.Height);

                    e.Graphics.DrawLine(new Pen(Brushes.Black), label7.Location.X + label7.Width, label7.Location.Y + sheft + tableLayoutPanel1.Location.Y, label98.Location.X + label98.Width, label98.Location.Y + sheft + tableLayoutPanel1.Location.Y + label98.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label7.Location.X, label7.Location.Y + sheft + tableLayoutPanel1.Location.Y, label98.Location.X, label98.Location.Y + sheft + tableLayoutPanel1.Location.Y + label98.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label9.Location.X, label9.Location.Y + sheft + tableLayoutPanel1.Location.Y, label88.Location.X, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y + label88.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label9.Location.X + label9.Width, label9.Location.Y + sheft + tableLayoutPanel1.Location.Y, label88.Location.X + label88.Width, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y + label88.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label10.Location.X, label10.Location.Y + sheft + tableLayoutPanel1.Location.Y, label89.Location.X, label89.Location.Y + sheft + tableLayoutPanel1.Location.Y + label89.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label11.Location.X, label11.Location.Y + sheft + tableLayoutPanel1.Location.Y, label90.Location.X, label90.Location.Y + sheft + tableLayoutPanel1.Location.Y + label90.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label12.Location.X, label12.Location.Y + sheft + tableLayoutPanel1.Location.Y, label91.Location.X, label91.Location.Y + sheft + tableLayoutPanel1.Location.Y + label91.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label13.Location.X, label13.Location.Y + sheft + tableLayoutPanel1.Location.Y, label92.Location.X, label92.Location.Y + sheft + tableLayoutPanel1.Location.Y + label92.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label14.Location.X, label14.Location.Y + sheft + tableLayoutPanel1.Location.Y, label93.Location.X, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y + label93.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label15.Location.X, label15.Location.Y + sheft + tableLayoutPanel1.Location.Y, label94.Location.X, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y + label94.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label16.Location.X, label16.Location.Y + sheft + tableLayoutPanel1.Location.Y, label95.Location.X, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y + label95.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Black), label17.Location.X, label17.Location.Y + sheft + tableLayoutPanel1.Location.Y, label41.Location.X, label41.Location.Y + sheft + tableLayoutPanel1.Location.Y + label41.Height);


                    e.Graphics.DrawString(label3.Text, label3.Font, Brushes.Black, label3.Location.X, label3.Location.Y + sheft);
                    e.Graphics.DrawString(label4.Text, label4.Font, Brushes.Black, label4.Location.X, label4.Location.Y + sheft);
                    e.Graphics.DrawString(label5.Text, label5.Font, Brushes.Black, label5.Location.X, label5.Location.Y + sheft);
                    e.Graphics.DrawString(label6.Text, label6.Font, Brushes.Black, label6.Location.X, label6.Location.Y + sheft);
                    e.Graphics.DrawString(label7.Text, label7.Font, Brushes.Black, label7.Location.X, label7.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label8.Text, label8.Font, Brushes.Black, label8.Location.X, label8.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label9.Text, label9.Font, Brushes.Black, label9.Location.X, label9.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label10.Text, label10.Font, Brushes.Black, label10.Location.X, label10.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label11.Text, label11.Font, Brushes.Black, label11.Location.X, label11.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label12.Text, label12.Font, Brushes.Black, label12.Location.X, label12.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label13.Text, label13.Font, Brushes.Black, label13.Location.X, label13.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label14.Text, label14.Font, Brushes.Black, label14.Location.X, label14.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label15.Text, label15.Font, Brushes.Black, label15.Location.X, label15.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label16.Text, label16.Font, Brushes.Black, label16.Location.X, label16.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label17.Text, label17.Font, Brushes.Black, label17.Location.X, label17.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label18.Text, label18.Font, Brushes.Black, label18.Location.X, label18.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label19.Text, label19.Font, Brushes.Black, label19.Location.X, label19.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label20.Text, label20.Font, Brushes.Black, label20.Location.X, label20.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label21.Text, label21.Font, Brushes.Black, label21.Location.X, label21.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label22.Text, label22.Font, Brushes.Black, label22.Location.X, label22.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label23.Text, label23.Font, Brushes.Black, label23.Location.X, label23.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label24.Text, label24.Font, Brushes.Black, label24.Location.X, label24.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label25.Text, label25.Font, Brushes.Black, label25.Location.X, label25.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label26.Text, label26.Font, Brushes.Black, label26.Location.X, label26.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label27.Text, label27.Font, Brushes.Black, label27.Location.X, label27.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label28.Text, label28.Font, Brushes.Black, label28.Location.X, label28.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label29.Text, label29.Font, Brushes.Black, label29.Location.X, label29.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label30.Text, label30.Font, Brushes.Black, label30.Location.X, label30.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label31.Text, label31.Font, Brushes.Black, label31.Location.X, label31.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label32.Text, label32.Font, Brushes.Black, label32.Location.X, label32.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label33.Text, label33.Font, Brushes.Black, label33.Location.X, label33.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label34.Text, label34.Font, Brushes.Black, label34.Location.X, label34.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label35.Text, label35.Font, Brushes.Black, label35.Location.X, label35.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label36.Text, label36.Font, Brushes.Black, label36.Location.X, label36.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label37.Text, label37.Font, Brushes.Black, label37.Location.X, label37.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label38.Text, label38.Font, Brushes.Black, label38.Location.X + splitContainer1.Location.X, label38.Location.Y + sheft + tableLayoutPanel1.Location.Y + splitContainer1.Location.Y);
                    e.Graphics.DrawString(label39.Text, label39.Font, Brushes.Black, label39.Location.X, label39.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label40.Text, label40.Font, Brushes.Black, label40.Location.X + splitContainer1.Location.X + 40, label40.Location.Y + sheft + tableLayoutPanel1.Location.Y + splitContainer1.Location.Y);
                    e.Graphics.DrawString(label42.Text, label42.Font, Brushes.Black, label42.Location.X, label42.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label43.Text, label43.Font, Brushes.Black, label43.Location.X, label43.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label44.Text, label44.Font, Brushes.Black, label44.Location.X, label44.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label45.Text, label45.Font, Brushes.Black, label45.Location.X, label45.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label46.Text, label46.Font, Brushes.Black, label46.Location.X, label46.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label47.Text, label47.Font, Brushes.Black, label47.Location.X, label47.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label48.Text, label48.Font, Brushes.Black, label48.Location.X, label48.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label49.Text, label49.Font, Brushes.Black, label49.Location.X, label49.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label50.Text, label50.Font, Brushes.Black, label50.Location.X, label50.Location.Y + sheft + tableLayoutPanel1.Location.Y);


                    e.Graphics.DrawString(label51.Text, label51.Font, Brushes.Black, label51.Location.X, label51.Location.Y + sheft);
                    e.Graphics.DrawString(label52.Text, label52.Font, Brushes.Black, label52.Location.X, label52.Location.Y + sheft);
                    e.Graphics.DrawString(label53.Text, label53.Font, Brushes.Black, label53.Location.X, label53.Location.Y + sheft);
                    e.Graphics.DrawString(label54.Text, label54.Font, Brushes.Black, label54.Location.X, label54.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label55.Text, label55.Font, Brushes.Black, label55.Location.X, label55.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label56.Text, label56.Font, Brushes.Black, label56.Location.X, label56.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label57.Text, label57.Font, Brushes.Black, label57.Location.X, label57.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label58.Text, label58.Font, Brushes.Black, label58.Location.X, label58.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label59.Text, label59.Font, Brushes.Black, label59.Location.X, label59.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label60.Text, label60.Font, Brushes.Black, label60.Location.X, label60.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label61.Text, label61.Font, Brushes.Black, label61.Location.X, label61.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label62.Text, label62.Font, Brushes.Black, label62.Location.X, label62.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label63.Text, label63.Font, Brushes.Black, label63.Location.X, label63.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label64.Text, label64.Font, Brushes.Black, label64.Location.X, label64.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label65.Text, label65.Font, Brushes.Black, label65.Location.X, label65.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label66.Text, label66.Font, Brushes.Black, label66.Location.X, label66.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label67.Text, label67.Font, Brushes.Black, label67.Location.X, label67.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label68.Text, label68.Font, Brushes.Black, label68.Location.X, label68.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label69.Text, label69.Font, Brushes.Black, label69.Location.X, label69.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label70.Text, label70.Font, Brushes.Black, label70.Location.X, label70.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label71.Text, label71.Font, Brushes.Black, label71.Location.X, label71.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label72.Text, label72.Font, Brushes.Black, label72.Location.X, label72.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label73.Text, label73.Font, Brushes.Black, label73.Location.X, label73.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label74.Text, label74.Font, Brushes.Black, label74.Location.X, label74.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label75.Text, label75.Font, Brushes.Black, label75.Location.X, label75.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label76.Text, label76.Font, Brushes.Black, label76.Location.X, label76.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label77.Text, label77.Font, Brushes.Black, label77.Location.X, label77.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label78.Text, label78.Font, Brushes.Black, label78.Location.X, label78.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label79.Text, label79.Font, Brushes.Black, label79.Location.X, label79.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label80.Text, label80.Font, Brushes.Black, label80.Location.X, label80.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label81.Text, label81.Font, Brushes.Black, label81.Location.X, label81.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label82.Text, label82.Font, Brushes.Black, label82.Location.X, label82.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label83.Text, label83.Font, Brushes.Black, label83.Location.X, label83.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label84.Text, label84.Font, Brushes.Black, label84.Location.X, label84.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label85.Text, label85.Font, Brushes.Black, label85.Location.X + splitContainer2.Location.X, label85.Location.Y + sheft + tableLayoutPanel1.Location.Y + splitContainer2.Location.Y);
                    e.Graphics.DrawString(label86.Text, label86.Font, Brushes.Black, label86.Location.X + splitContainer2.Location.X + 40, label86.Location.Y + sheft + tableLayoutPanel1.Location.Y + splitContainer2.Location.Y);
                    e.Graphics.DrawString(label87.Text, label87.Font, Brushes.Black, label87.Location.X, label87.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label88.Text, label88.Font, Brushes.Black, label88.Location.X, label88.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label89.Text, label89.Font, Brushes.Black, label89.Location.X, label89.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label90.Text, label90.Font, Brushes.Black, label90.Location.X, label90.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label91.Text, label91.Font, Brushes.Black, label91.Location.X, label91.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label92.Text, label92.Font, Brushes.Black, label92.Location.X, label92.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label93.Text, label93.Font, Brushes.Black, label93.Location.X, label93.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label94.Text, label94.Font, Brushes.Black, label94.Location.X, label94.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    e.Graphics.DrawString(label95.Text, label95.Font, Brushes.Black, label95.Location.X, label95.Location.Y + sheft + tableLayoutPanel1.Location.Y);
                    sheft += 270;
                }
                index++;
                if (index == arid.Count)
                {
                    e.Graphics.DrawString(totalbox.Text, totalbox.Font, Brushes.Black, totalbox.Location.X, totalbox.Location.Y + sheft + 50);
                    e.Graphics.DrawString(label100.Text, label100.Font, Brushes.Black, label100.Location.X, label100.Location.Y + sheft + 50);
                    this.Enabled = true;
                    timer1.Enabled = false;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
      
    }
}

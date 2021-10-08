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
    public partial class ProsessingForm : Form
    {
        int i = 0;
        Salary_form part;
        Thread th;
        Myconnection mycon;
        

        public ProsessingForm( Salary_form master )
        {
            InitializeComponent();
            part = master;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProsessingForm_Load(object sender, EventArgs e)
        {
            mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
            pictureBox1.Image = imageList1.Images[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
            pictureBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "جاري معالجة البيانات , قد يستغرق ذلك بضعة دقائق";
            ThreadStart f = new ThreadStart(full);
            th = new Thread(f);
            th.Name = "yes";
            th.Start();
        }

        public void full()
        {
            SalaryCuting cut = new SalaryCuting();;

            string month = dateTimePicker1.Value.Month.ToString().Trim();
            string year = dateTimePicker1.Value.Year.ToString().Trim();

            DataTable dtemployees = mycon.myselect_ds("select id from Employees");

            progressBar1.Invoke(new EventHandler(delegate { this.progressBar1.Maximum = dtemployees.Rows.Count; }));

            foreach(DataRow dr in dtemployees.Rows)
            {
                this.Invoke(new EventHandler(delegate { this.i++; if (i > 7) i = 0; pictureBox1.Image = imageList1.Images[i]; }));
                progressBar1.Invoke(new EventHandler(delegate { this.progressBar1.Increment(1); }));
                cut.do_calc(dr["id"].ToString(), month, year);
            }

            progressBar1.Invoke(new EventHandler(delegate { this.progressBar1.Value = 0; }));
            button1.Invoke(new EventHandler(delegate { this.button1.Enabled = true; }));
            button2.Invoke(new EventHandler(delegate { this.button2.Enabled = true; }));
            button3.Invoke(new EventHandler(delegate { this.button3.Enabled = true; }));
            dateTimePicker1.Invoke(new EventHandler(delegate { dateTimePicker1.Enabled = false; }));
            pictureBox1.Invoke(new EventHandler(delegate { pictureBox1.Visible = false; }));
            label2.Invoke(new EventHandler(delegate { label2.Text="تم الإنتهاء من القطع بنجاح"; }));
            th.Abort();
        }


        private void ProsessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            part.Process_f = 1;
        }
    }
}

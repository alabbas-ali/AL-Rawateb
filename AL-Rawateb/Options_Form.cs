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
    public partial class Options_Form : Form
    {
        private Master_form prnt;
        public Myconnection mycon;

        public Options_Form(Master_form prnt)
        {
            InitializeComponent();
            this.prnt = prnt;
        }

        private void Options_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usareDS.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.usareDS.users);
            mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
            DataTable dt = mycon.myselect_ds("select * from Options WHERE id=1");
            DataRow dr = dt.Rows[0];
            tbmotakaednum.Text= dr["motkaedCount"].ToString();
            tbomalmontafe.Text = dr["omalentfae"].ToString();
            tbomalmoshtarek1.Text = dr["omaleshtrak"].ToString();
            tbomalmoshtarek2.Text = dr["omaleshtrak1"].ToString();
            tbomalmoshtarek3.Text = dr["omaleshtrak2"].ToString();
            comboBox1.SelectedIndex = (int)dr["stopektsas"];
            comboBox2.SelectedIndex = (int)dr["stoptabea"];
            comboBox3.SelectedIndex = (int)dr["stopmasol"];
            dt = mycon.myselect_ds("select * from users WHERE id=1");
            dr = dt.Rows[0];
            uname.Text = dr["user_name"].ToString();
        }

        private void Options_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.Option_f = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Commoand("update Options set motkaedCount=" + tbmotakaednum.Text + ",omalentfae=" + tbomalmontafe.Text
                                + ",omaleshtrak=" + tbomalmoshtarek1.Text + ",omaleshtrak1="
                                + tbomalmoshtarek2.Text + ",omaleshtrak2=" + tbomalmoshtarek3.Text + ",stopektsas=" 
                                + comboBox1.SelectedIndex + ",stoptabea=" + comboBox2.SelectedIndex  + ",stopmasol=" 
                                + comboBox3.SelectedIndex + " where id=1");
                String u_pass = upass.Text;
                System.Security.Cryptography.MD5 md = System.Security.Cryptography.MD5.Create();
                byte[] u_data = md.ComputeHash(Encoding.Default.GetBytes(u_pass));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < u_data.Length; i++)
                {
                    sb.Append(u_data[i].ToString());
                }
                u_pass = sb.ToString();
                mycon.Commoand("update users set user_name = '" + uname.Text + "' , user_pass='" + u_pass + "' WHERE id=1");
                Close();
            }
            catch (Exception exp) { MessageBox.Show("يرجا التحقق من صحة البيانات المدخلة"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Commoand("update Options set motkaedCount=" + tbmotakaednum.Text + ",omalentfae=" + tbomalmontafe.Text
                                + ",omaleshtrak=" + tbomalmoshtarek1.Text + ",omaleshtrak1="
                                + tbomalmoshtarek2.Text + ",omaleshtrak2=" + tbomalmoshtarek3.Text + ",stopektsas="
                                + comboBox1.SelectedIndex + ",stoptabea=" + comboBox2.SelectedIndex + ",stopmasol="
                                + comboBox3.SelectedIndex + " where id=1");
                String u_pass = upass.Text;
                System.Security.Cryptography.MD5 md = System.Security.Cryptography.MD5.Create();
                byte[] u_data = md.ComputeHash(Encoding.Default.GetBytes(u_pass));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < u_data.Length; i++)
                {
                    sb.Append(u_data[i].ToString());
                }
                u_pass = sb.ToString();
                mycon.Commoand("update users set user_name = '" + uname.Text + "' , user_pass='" + u_pass + "' WHERE id=1");
                //Close();
            }
            catch (Exception exp) { MessageBox.Show("يرجا التحقق من صحة البيانات المدخلة"); }
        }
    }
}

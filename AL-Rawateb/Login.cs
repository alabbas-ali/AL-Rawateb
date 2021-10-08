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
    public partial class Login : Form
    {
        Master_form prnt;
        Boolean loged = false;

        public Login(Master_form master)
        {
            InitializeComponent();
            prnt = master;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            String u_name = uname.Text;
            String u_pass = upass.Text;
            System.Security.Cryptography.MD5 md = System.Security.Cryptography.MD5.Create();
            byte[] u_data = md.ComputeHash(Encoding.Default.GetBytes(u_pass));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < u_data.Length; i++)
            {
                sb.Append(u_data[i].ToString());
            }
            u_pass = sb.ToString();
            //Regex myRegex = new Regex(@"^\w{6}\w*$", RegexOptions.Singleline);
            if (u_name != "" && u_pass != "")
            {
                DataSet ds = new DataSet();
                //DataAccess.DBConnection con = DataAccess.DBConnection.GetInstance();
                Myconnection mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
                DataTable dataTable = mycon.myselect_ds("select * from users where user_name='" + u_name + "' and user_pass='" + u_pass + "'");
                int n;
                n = dataTable.Rows.Count;
                if (n > 0)
                {
                    prnt.Enabled = true;
                    loged = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("كلمة المرور خاطئة !!");
                }

            }
            else
            {
                MessageBox.Show("لتسجيب الدخول يرجى إدخال الاسم وكلمة المرور !!");
            }  
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usareDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usareDS.users);
            prnt.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!loged){
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}

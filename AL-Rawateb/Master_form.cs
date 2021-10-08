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
    public partial class Master_form : Form
    {
        public int card_f=1;
        public int salary_f = 1;
        public int sort_f = 1;
        public int statistic_f = 1;
        public int Option_f = 1;
        public int upgrad_f = 1;
        public int x_f = 1;
        public int RowatepShow_f = 1;
        public int Esal_f = 1;
        public int Tawed_f = 1;
        public int Hasem_f = 1;
        public int Hasem_f2 = 1;
        public int NakabtOmal_f = 1;
        public int Nakabt_f = 1;
        public int Menha_f = 1;
        public int About_F = 1;

        Card_form card_form;
        Salary_form salary_form;
        Sort_form sort_form;
        Statistic_form statistic_form;
        Options_Form option_form;
        Upgrad_form upgrad_form;
        X_form x_form;
        RawatepShowForm RowatepShow_form;
        EsalCutForm Esal_form;
        TawedShowForm Tawed_form;
        HasemShowForm Hasem_form;
        HasemShowForm2 Hasem_form2;
        NakabtOmalForm NakabtOmal_Form;
        NakabatForm Nakabt_Form;
        MenhaForm Menha_Form;
        About About_Form;
        //Login login_Form;

        public Master_form()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("y");
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(null,"هل تريد اغلاق التطبيق؟", "تأكيد", MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void بطاقةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton15_Click(sender, e);
        }

        private void إحصاءاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton20_Click(sender, e);
        }

        private void رواتبموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton16_Click(sender, e);
        }

        private void فرزواستعلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton19_Click(sender, e);

        }

        private void الترفيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton17_Click(sender, e);
        }

        private void شطبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton18_Click(sender, e);
        }

        private void خياراتمتقدمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton21_Click(sender, e);
        }

        private void جدولالرواتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click_1(null, null);
        }

        private void قسائمالراتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(null, null);
        }

        private void جدولطبيعةالعملToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton9_Click(null, null);
        }

        private void جدولالحسمياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(null, null);
        }

        private void تفابةالعمالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton4_Click(null, null);
        }

        private void نقابةالمهندسينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click(null, null);
        }

        private void نقابةالزراعيينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click(null, null);
        }

        private void جداولالغياباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(null, null);
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد اغلاق التطبيق؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (card_f == 1)
            {
                card_form = new Card_form(this);
                card_form.MdiParent = this;
                card_form.Show();
                card_f = 0;
            }
            else
            {
                card_form.Activate();
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            if (salary_f == 1)
            {
                salary_form = new Salary_form(this);
                salary_form.MdiParent = this;
                salary_form.Show();
                salary_f = 0;
            }
            else
            {
                salary_form.Activate();
            }

        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            if (upgrad_f == 1)
            {
                upgrad_form = new Upgrad_form(this);
                upgrad_form.MdiParent = this;
                upgrad_form.Show();
                upgrad_f = 0;
            }
            else
            {
                upgrad_form.Activate();
            }

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            if (x_f == 1)
            {
                x_form = new X_form(this);
                x_form.MdiParent = this;
                x_form.Show();
                x_f = 0;
            }
            else
            {
                x_form.Activate();
            }

        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            if (sort_f == 1)
            {
                sort_form = new Sort_form(this);
                sort_form.MdiParent = this;
                sort_form.Show();
                sort_f = 0;
            }
            else
            {
                sort_form.Activate();
            }

        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            if (statistic_f == 1)
            {
                statistic_form = new Statistic_form(this);
                statistic_form.MdiParent = this;
                statistic_form.Show();
                statistic_f = 0;
            }
            else
            {
                statistic_form.Activate();
            }
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            if (Option_f == 1)
            {
                option_form = new Options_Form(this);
                option_form.MdiParent = this;
                option_form.Show();
                Option_f = 0;
            }
            else
            {
                option_form.Activate();
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (RowatepShow_f == 1)
            {
                RowatepShow_form = new RawatepShowForm(this);
                RowatepShow_form.MdiParent = this;
                RowatepShow_form.Show();
                RowatepShow_f = 0;
            }
            else
            {
                RowatepShow_form.Activate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Esal_f == 1)
            {
                Esal_form = new EsalCutForm(this);
                Esal_form.MdiParent = this;
                Esal_form.Show();
                Esal_f = 0;
            }
            else
            {
                Esal_form.Activate();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (Tawed_f == 1)
            {
                Tawed_form = new TawedShowForm(this);
                Tawed_form.MdiParent = this;
                Tawed_form.Show();
                Tawed_f = 0;
            }
            else
            {
                Tawed_form.Activate();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Hasem_f == 1)
            {
                Hasem_form = new HasemShowForm(this);
                Hasem_form.MdiParent = this;
                Hasem_form.Show();
                Hasem_f = 0;
            }
            else
            {
                Hasem_form.Activate();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Hasem_f2 == 1)
            {
                Hasem_form2 = new HasemShowForm2(this);
                Hasem_form2.MdiParent = this;
                Hasem_form2.Show();
                Hasem_f2 = 0;
            }
            else
            {
                Hasem_form2.Activate();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (NakabtOmal_f == 1)
            {
                NakabtOmal_Form = new NakabtOmalForm(this);
                NakabtOmal_Form.MdiParent = this;
                NakabtOmal_Form.Show();
                NakabtOmal_f = 0;
            }
            else
            {
                NakabtOmal_Form.Activate();
            }
        }

        private void Master_form_Load(object sender, EventArgs e)
        {
            new Login(this).Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Nakabt_f == 1)
            {
                Nakabt_Form = new NakabatForm(this);
                Nakabt_Form.MdiParent = this;
                Nakabt_Form.Show();
                Nakabt_f = 0;
            }
            else
            {
                Nakabt_Form.Activate();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (Menha_f == 1)
            {
                Menha_Form = new MenhaForm(this);
                Menha_Form.MdiParent = this;
                Menha_Form.Show();
                Menha_f = 0;
            }
            else
            {
                Menha_Form.Activate();
            }
        }

        private void حولالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (About_F == 1)
            {
                About_Form = new About(this);
                About_Form.MdiParent = this;
                About_Form.Show();
                About_F = 0;
            }
            else
            {
                About_Form.Activate();
            }
        }

        
    }
}

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
    public partial class About : Form
    {
        private Master_form prnt;
        public About(Master_form pr)
        {
            InitializeComponent();
            this.prnt = pr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.About_F = 1;
        }

        
    }
}

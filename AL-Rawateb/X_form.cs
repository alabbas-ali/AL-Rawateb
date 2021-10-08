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
    public partial class X_form : Form
    {
        private Master_form prnt;
        public X_form(Master_form pr)
        {
            InitializeComponent();
            this.prnt = pr;
        }

        private void X_form_Load(object sender, EventArgs e)
        {

        }

        private void X_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.x_f = 1;
        }
    }
}

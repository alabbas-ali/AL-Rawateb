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
    public partial class Sort_form : Form
    {
        private Master_form prnt;
        public Sort_form(Master_form prnt)
        {
            InitializeComponent();
            this.prnt = prnt;
        }

        private void Sort_form_Load(object sender, EventArgs e)
        {

        }

        private void Sort_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.sort_f = 1;
        }
    }
}

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
    public partial class Card_form : Form
    {
        private Master_form prnt;
        private bool new_Employee=false;
        //private DataAccess.DBConnection con;
        private bool new_or_update = false;
        private int current_id=1;
        public Card_form(Master_form master)
        {
            InitializeComponent();
            this.prnt = master;
        }

        private void Card_form_Load(object sender, EventArgs e)
        {
           

        }
        private void Card_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            prnt.card_f = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}

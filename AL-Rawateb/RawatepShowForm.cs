using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Office.Interop;

namespace AL_Rawateb
{
    public partial class RawatepShowForm : Form
    {
        private Master_form prnt;
        string usingsubject = "";
        int month;
        int year;

        public RawatepShowForm(Master_form master)
        {
            InitializeComponent();
            prnt = master;
        }

        private void RawatepShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.prnt.RowatepShow_f = 1;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            radioButton3.Checked = true;
            fill();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            fill();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                RawatepReportForm repo = new RawatepReportForm(radioButton1.Checked,month,year,usingsubject);
                repo.MdiParent = prnt;
                repo.Show();
            }
            else
            {
                SarafRawatepForm repo = new SarafRawatepForm(month,year,usingsubject);
                repo.MdiParent = prnt;
                repo.Show();
            }
        }


        private void RawatepShowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarysDS.salarys' table. You can move, or remove it, as needed.
            //this.salarysTableAdapter.Fill(this.salarysDS.salarys);
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            cbox6.SelectedIndex = 0;
            fill();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false)
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                //button1.Enabled = true;
            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                //button1.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false)
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                //button1.Enabled = true;
            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                //button1.Enabled = false;
            }
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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            fill();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //// Export all the details
            try
            {
                
                DialogResult res =  saveFileDialog1.ShowDialog(this);
                //MessageBox.Show (saveFileDialog1.FileName);
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                // Change properties of the Workbook 
                ExcelApp.Columns.ColumnWidth = 20;

                // Storing header part in Excel
                for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                }

                // Storing Each row and column value to excel sheet
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName);
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}



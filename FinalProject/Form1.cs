using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (my.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
                Visible = false;
               
            }
            else if (postgre.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
                Visible = false;


            }
            else
            {
                lbl3.Text = "Lütfen Seçim Yapınız!!!";    
            }
        }

        private void postgre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

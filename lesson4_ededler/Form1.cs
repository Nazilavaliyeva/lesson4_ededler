using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson4_ededler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string ters = "";
            for (int i = eded.ToString().Length - 1; i >= 0; i--)
            {
                ters += eded.ToString()[i];
            }
            label1.Text = ters;

        }

        private void kvadratkub_Click(object sender, EventArgs e)
        {
           
        }

        private void bolunen5_Click(object sender, EventArgs e)
        {

        }
    }
}

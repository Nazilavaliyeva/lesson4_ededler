﻿using System;
using System.Windows.Forms;

namespace lesson4_ededler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int eli = 0;
        int Eli = 1;

        private void button4_Click(object sender, EventArgs e)
        {
            // Ədədləri ters çevirir    
            try
            {
                int eded = Convert.ToInt32(textBox1.Text);
                string ters = "";
                for (int i = eded.ToString().Length - 1; i >= 0; i--)
                {
                    ters += eded.ToString()[i];
                }
                label1.Text = ters;

            }
            catch (Exception ali)
            {

                MessageBox.Show($"Xəta baş verdi: {ali.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void kvadratkub_Click(object sender, EventArgs e)
        {
            //Kvadrat və kubunu tapır






        }

        private void bolunen5_Click(object sender, EventArgs e)
        {
            //5-ə bölünən ədədləri tapır    
            try
            {
                int eded = Convert.ToInt32(textBox1.Text);
                string netice = "";
                if (eded % 5 == 0)
                {
                    netice = "5-ə bölünür";
                }
                else
                {
                    netice = "5-ə bölünmür";

                }
                label1.Text = netice;

            }
            catch (Exception)
            {
                MessageBox.Show("Xeta");

            }
        }

        private void faktorial_Click(object sender, EventArgs e)
        {
            //Faktorial hesablayir  
            try
            {
                int eded = Convert.ToInt32(textBox1.Text);
                int fakt = 1;
                for (int i = 1; i <= eded; i++)
                {
                    fakt *= i;
                }
                label1.Text = fakt.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Xeta", "Ədəd daxil edin.");
            }


        }

        private void sade_Click(object sender, EventArgs e)
        {
            //sade ədəd olub olmadığını tapır
            try
            {
                int eded = Convert.ToInt32(textBox1.Text);
                string netice = "";
                for (int i = 1; i <= eded; i++)
                {
                    if (i == 1 || i == eded)
                    {
                        netice = "Sadə ədəddir";
                    }
                    else if (eded % i == 0)
                    {
                        netice = "Mürəkkəb ədəddir";
                        break;
                    }
                }
                label1.Text = netice;
            }
            catch
            {

                MessageBox.Show("Xeta", " Zehmet olmasa eded daxil edin.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ReqemCemi_Click(object sender, EventArgs e)
        {
            //Reqemlerin cemini tapir   
            try
            {
                int eded = Convert.ToInt32(textBox1.Text);
                int cem = 0;
                while (eded > 0)
                {
                    cem = cem + (eded % 10);    // cem += eded % 10;
                    eded = eded / 10;
                }
                label1.Text = cem.ToString();

            }
            catch
            {

                MessageBox.Show("Xeta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

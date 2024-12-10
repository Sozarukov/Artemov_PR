using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int[] Mas = new int[20];

        private void button1_Click(object sender, EventArgs e)
        {
            st1.Items.Clear();
            st2.Items.Clear();

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {

                Mas[i] = rand.Next(1, 50);

                st1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());

            }

            int max = Mas[0];

            for (int j = 0; j < 20; j++)
            {
                if (Mas[j] > max)
                {
                    max = Mas[j];

                }
                textBox1.Text = ("max = " + max.ToString());

            }
            st2.Items.Add("Mas[" + 0.ToString() + "] = " + max.ToString());
            for (int u = 1; u < 20; u++)
            {

                st2.Items.Add("Mas[" + u.ToString() + "] = " + Mas[u].ToString());

            }




        }

      

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

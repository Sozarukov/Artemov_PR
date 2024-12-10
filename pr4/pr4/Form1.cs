namespace pr4
{
    public partial class st2 : Form
    {
        public st2()
        {
            InitializeComponent();
        }
        int a = 20;
        double[] Mas = new double[20];
        double max = -100;
        double tmp;

        private void button1_Click(object sender, EventArgs e)
        {
            st1.Items.Clear();
            st.Items.Clear();


            Random rand = new Random();

            for (int i = 0; i < a; i++)
            {

                Mas[i] = Math.Round(rand.Next(-1000, 1000) * 0.020, 2);

                st1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());

                

            }
            max = -100;

            int otr = 0;

            for (int j = 0; j < a; j++)
            {
                double x = Convert.ToDouble(textBox2.Text);

                if (Mas[j] < x)
                {
                    otr++;

                }
                textBox1.Text = ("otr = " + otr.ToString());

            }

            int last = a - 1;

            for (int n = 0; n < a; n++)
            {

                if (Mas[n] < 0) last = n;


            }
            int sum = 0;

            for (int n = last + 1; n < a; n++)
            {

                sum += (int)Mas[n];

            }

            textBox3.Text = (sum.ToString());



            for (int i = 0; i < a; i++)
            {
                if (Mas[i] > max)
                {
                    max = Mas[i];
                    textBox4.Text = ("max = " + max.ToString());
                }

                tmp = Math.Round(max - (max * 0.2), 2);
                textBox5.Text = ("tmp = " + tmp.ToString());
            }
                for (int j = 0; j < a; j++)
                {

                    if (Mas[j] >= tmp)
                    {
                        st.Items.Add("Mas[" + j.ToString() + "] = " + Mas[j].ToString());
                    }
                }
                for (int j = 0; j < a; j++)
                {
                    if (Mas[j] < tmp)
                    {
                        st.Items.Add("Mas[" + j.ToString() + "] = " + Mas[j].ToString());
                    }
                }
            

            
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

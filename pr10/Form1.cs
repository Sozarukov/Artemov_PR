using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зк10
{
    public partial class Form1 : Form
    {
        public int leafSpeed = 2;
        public int horizontalOffset = 0;
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Width = 650;
            this.Height = 600;

            Timer animationTimer = new Timer
            {
                Interval = 20 // Скорость обновления (мс)
            };
            animationTimer.Tick +=timer1_Tick;
            animationTimer.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            bool movingRight = random.Next(0, 2) == 0;
            // Листы:
            var newLocation1 = pictureBox1.Location;

            var newLocation2 = pictureBox2.Location;

            var newLocation3 = pictureBox3.Location;
            
            if (movingRight) //вправо
            {
                horizontalOffset++;
                if (horizontalOffset > 5) 
                {
                    movingRight = false;
                }
            }
            else //влево
            {
                horizontalOffset--;
                if (horizontalOffset < -5) 
                {
                    movingRight = true;
                }
            }

            

            //проверка на позицию листов до пола и задаем новую позицию
            if (newLocation1.Y <= this.Height-100)
            {
                newLocation1.Y += leafSpeed;

                newLocation1.X += horizontalOffset / 5;
                

            }
            if (newLocation2.Y <= this.Height - 100)
            {
                newLocation2.Y += leafSpeed;

                newLocation2.X += horizontalOffset / 5;
                

            }
            if (newLocation3.Y <= this.Height - 100)
            {
                newLocation3.Y += leafSpeed;

                newLocation3.X += horizontalOffset / 5;
                

            }

            pictureBox2.Location = newLocation2;
            pictureBox3.Location = newLocation3;
            pictureBox1.Location = newLocation1;

        }

    }
}

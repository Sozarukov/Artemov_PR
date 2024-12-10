using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11
{
    public partial class Form1 : Form
    { 
        private Point PreviousPoint, point; 
        private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;

        private Rectangle randomRectangle;
        private Random random = new Random();
        private Brush color = new SolidBrush(Color.FromArgb(255, 255, 255));
        public int sizeX;
        public int sizeY;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4); 
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            OpenFileDialog dialog = new OpenFileDialog(); // объект dialog класса OpenFileDialog
                                                          
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF," +
           "*.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName); 
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                bmp = new Bitmap(image, width, height); // переводим в бмп
                pictureBox1.Image = bmp; 
                g = Graphics.FromImage(pictureBox1.Image); 
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { 
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //проверка нажата ли пкм
            { 
                point.X = e.X;
                point.Y = e.Y;
                g.DrawLine(blackPen, PreviousPoint, point);
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            sizeX = pictureBox1.Width;
            sizeY = pictureBox1.Height;
            for (int i = 0; i < 1000; i++) 
            {
                
                randomRectangle = new Rectangle(random.Next(0,sizeX),random.Next(0,sizeY),5,5);
                color = new SolidBrush(Color.FromArgb(
                    random.Next(0, 255),
                    random.Next(0, 255),
                    random.Next(0, 255)));
                g.FillRectangle(color,randomRectangle);
                pictureBox1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "GIF File(*.gif)|*.gif|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
  
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn =
                fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

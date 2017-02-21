using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap buffer;
        Graphics bufferg;

        void szal()
        {
            
            int h, w;
            
                h = buffer.Height;
                w = buffer.Width;
            

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if ((h * w + x) % 8 == 1)
                        buffer.SetPixel(x, y, Color.Black);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buffer = new Bitmap(panel2.Width, panel2.Height);
            lock (buffer)
                bufferg = Graphics.FromImage(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
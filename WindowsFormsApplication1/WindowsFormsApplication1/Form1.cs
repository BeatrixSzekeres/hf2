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

namespace festegeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap buffer;
        Graphics bufferg;


        Thread t;

      /*  private void button1_Click(object sender, EventArgs e)
        {
          //  button1.Enabled = false;

            t = new Thread(new ThreadStart(szal));
            t.Start();
        }*/

        void szal()
        {
            bufferg.Clear(Color.White);

            int h, w;

            
                h = Height;
                w = Width;
            

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if ((y * w + x) % 8 == 1)
                        buffer.SetPixel(x, y, Color.Black);

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buffer == null)
                return;

            using (Graphics g = panel2.CreateGraphics())
            {
               
                    g.DrawImage(buffer, 0, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
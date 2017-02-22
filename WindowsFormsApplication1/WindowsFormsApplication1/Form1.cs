﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        Thread t;
        Bitmap buffer;
        Graphics bufferg;

        
        void szal()
        {

            bufferg.Clear(Color.White);

            int h, w;
            int szam = 1;

            lock (buffer)
            {
                h = buffer.Height;
                w = buffer.Width;
            }

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    szam++;
                    if (PrimeSearcher.PrimeS(szam) == ("Prím"))
                        lock (buffer)
                            buffer.SetPixel(x, y, Color.Black);


                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buffer == null)
                return;

            using (Graphics g = panel2.CreateGraphics())
            {
                lock (buffer)
                    g.DrawImage(buffer, 0, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buffer = new Bitmap(panel2.Width, panel2.Height);
            lock (buffer)
                bufferg = Graphics.FromImage(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            t = new Thread(new ThreadStart(szal));
            t.Start();
        }
    }
}
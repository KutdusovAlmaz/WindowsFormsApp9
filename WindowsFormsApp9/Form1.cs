using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 2);

            int startX = 50;
            int startY = 50;
            int width = 100;
            int height = 100;

            for (int i = 0; i < 5; i++)
            {
                g.DrawRectangle(blackPen, startX + i * 120, startY, width, height);
            }

            blackPen.Dispose();
            g.Dispose();
        }

    }
    }


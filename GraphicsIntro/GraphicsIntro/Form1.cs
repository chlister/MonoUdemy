using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Graphics g1;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            g1 = panel2.CreateGraphics();
        }

        private void GrapTest1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);

            // Pens are a built in C#. They are 1 pixel wide pens
            g.DrawLine(Pens.Red, 0, 0, panel1.Width, panel1.Height);

            Pen p = new Pen(Color.FromArgb(245,202,65), 10);
            g.DrawRectangle(p, 100, 50, 50,100);
        }

        private void GrapTest2_Click(object sender, EventArgs e)
        {
            g1.Clear(panel2.BackColor);
            SolidBrush deep = new SolidBrush(Color.FromArgb(51, 51, 255));
            SolidBrush trans = new SolidBrush(Color.FromArgb(80,153, 153, 255)); // Alpha can be set at the beginning of Argb() selector
            Pen p = new Pen(Color.FromArgb(245,202,65), 10);
            g1.DrawRectangle(p, 100, 50, 50,100);

            g1.FillRectangle(deep, 75,50,50,120);
            g1.FillRectangle(trans, 75+50,50,50,120);
        }
    }
}

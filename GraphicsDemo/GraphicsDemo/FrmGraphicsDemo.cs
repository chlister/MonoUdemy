using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class FrmGraphicsDemo : Form
    {
        public FrmGraphicsDemo()
        {
            InitializeComponent();
        }

        private void FrmGraphicsDemo_Load(object sender, EventArgs e)
        {

        }

        private void FrmGraphicsDemo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Create a font
            Font f = new Font("Verdana", 30);
            // Create brush
            SolidBrush b = new SolidBrush(Color.Blue);
            // Draw the string
            g.DrawString("Hello", f, b, 40,40);

            // Create a pen
            Pen p = new Pen(Color.Red, 4);
            // Draw a Line
            g.DrawLine(p, 0,0, 100, 100);

            // Draw rectangle
            g.DrawRectangle(p, 50, 50, 20, 20);

            // The brush class is used to fill shapes
            SolidBrush s = new SolidBrush(Color.Purple);
            g.FillRectangle(s, 120, 40, 50, 50);

            // Create a circle
            SolidBrush snew = new SolidBrush(Color.DarkBlue);
            g.FillEllipse(snew, 200, 40, 20,20);

        }
    }
}

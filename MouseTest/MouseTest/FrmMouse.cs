using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTest
{
    public partial class FrmMouse : Form
    {
        public FrmMouse()
        {
            InitializeComponent();
        }
        Graphics g;
        Pen p;

        private void FrmMouse_Load(object sender, EventArgs e)
        {
            Text = "Using the Mouse";
            g = CreateGraphics();
            p = new Pen(Color.Red);
        }

        private void FrmMouse_MouseMove(object sender, MouseEventArgs e)
        {
            //g.DrawEllipse(p, e.X,e.Y,5,5);
            pointerPos.Text = Convert.ToString(e.X) + " " + Convert.ToString(e.Y);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You clicked the " + e.Button + " at position: " + e.X + ", " + e.Y);
        }
    }
}

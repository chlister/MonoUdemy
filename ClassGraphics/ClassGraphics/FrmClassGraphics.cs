using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassGraphics
{
    public partial class FrmClassGraphics : Form
    {
        public FrmClassGraphics()
        {
            InitializeComponent();
        }
        Graphics g;
        private void FrmClassGraphics_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void BtnCreateFaces(object sender, EventArgs e)
        {
            Face face1 = new Face(10,10,Color.Black, Color.Green);
            Face face2 = new Face(100,40,Color.Purple, Color.Yellow);
            Face face3 = new Face(10,200,Color.Violet, Color.Red);
            Face face4 = new Face(200,70,Color.Aqua, Color.DeepPink);

            face1.PaintFace(g);
            face2.PaintFace(g);
            face3.PaintFace(g);
            face4.PaintFace(g);

        }

        private void DoubleClickFace(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            Face f = new Face(m.Location.X, m.Location.Y, Color.Green, Color.Yellow);
            f.PaintFace(g);
        }
    }
}

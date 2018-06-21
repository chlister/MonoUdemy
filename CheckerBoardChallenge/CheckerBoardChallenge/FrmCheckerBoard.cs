using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoardChallenge
{
    public partial class FrmCheckerBoard : Form
    {
        Graphics g;
        public FrmCheckerBoard()
        {
            InitializeComponent();
        }

        private void FrmCheckerBoard_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            Height = 900;
            Width = 900;
            this.Text = "Checker Board Challenge";
            panel1.Width = 800;
            panel1.Height = 800;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(panel1.BackColor);
            int recSide = panel1.Width / 8; // We're making squares, only one side needed
            // Define a pen for drawing
            Pen pen = new Pen(Color.Gray, 4); // For a small line between all squares
            SolidBrush bBrush = new SolidBrush(Color.Black);
            SolidBrush rBrush = new SolidBrush(Color.Red);
            // Create method for drawing these rects in 8x8 plain
            int num = 0;
            for (int c = 0; c < panel1.Width; c += 100) // Coloum
            {
                for (int r = 0; r < panel1.Height; r += 100) // Row
                {
                    if (num % 2 == 0)
                        g.FillRectangle(bBrush, new Rectangle(c, r, recSide, recSide));
                    else
                        g.FillRectangle(rBrush, new Rectangle(c, r, recSide, recSide));
                    g.DrawRectangle(pen, new Rectangle(c, r, recSide, recSide));
                    num++;
                }
                num++;
            }
        }
    }
}

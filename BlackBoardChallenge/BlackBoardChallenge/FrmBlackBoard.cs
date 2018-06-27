using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoardChallenge
{
    public partial class FrmBlackBoard : Form
    {
        Font f;
        Pen p;
        Graphics g;
        SolidBrush b;
        bool mousePressed;
        int xLast;
        int yLast;

        public FrmBlackBoard()
        {
            InitializeComponent();
        }


        private void FrmBlackBoard_Load(object sender, EventArgs e)
        {
            f = new Font("Verdena", 20F);
            p = new Pen(Color.Black, 4);
            b = new SolidBrush(Color.Black);
            g = BlackBoardPanel.CreateGraphics();
            mousePressed = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ColorPanel_Paint(object sender, PaintEventArgs e)
        {
            radioBlack.BackColor = Color.Black;
            radioBlack.ForeColor = Color.White;
            radioBlack.Select();
            radioBlue.BackColor = Color.Blue;
            radioGreen.BackColor = Color.Green;
            radioYellow.BackColor = Color.Yellow;
            radioRed.BackColor = Color.Red;
        }

        private void BlackBoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BlackBoardPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePressed = true;
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void BlackBoardPanel_MouseHover(object sender, EventArgs e)
        {
        }

        private void BlackBoardPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, xLast, yLast, e.X, e.Y);
                mousePressed = false;
            }
        }

        private void BlackBoardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                g.DrawLine(p, xLast, yLast, e.X, e.Y);
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void radioWhite_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void radioYellow_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            g.Clear(BlackBoardPanel.BackColor);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (int)numericUpDown1.Value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollProblem
{
    public partial class FrmDiceRollProb : Form
    {
        public FrmDiceRollProb()
        {
            InitializeComponent();
        }

        Random rNum = new Random();
        
        private void FrmDiceRollProb_Load(object sender, EventArgs e)
        {

        }
        private void BtnDiceRoll(object sender, EventArgs e)
        {
            // First load graphics 
            Graphics g = CreateGraphics();
            g.Clear(FrmDiceRollProb.DefaultBackColor);

            // First Dice roll
            int die1 = rNum.Next(1, 7);
            // construct the string
            string dImgStr1 = Application.StartupPath + @"\Dice" + die1.ToString() + ".gif";
            Image img1 = Image.FromFile(dImgStr1);
            g.DrawImage(img1, 16, 24, 96, 96);

            // Second dice
            int die2 = rNum.Next(1, 7);
            string dImgStr2 = Application.StartupPath + @"\Dice" + die2.ToString() + ".gif";
            Image img2 = Image.FromFile(dImgStr2);
            g.DrawImage(img2, 144, 24, 96, 96);

            // Print the result
            int sum = die1 + die2;

            Font f = new Font("Verdana", 10);
            SolidBrush s = new SolidBrush(Color.Blue);
            g.DrawString(sum.ToString(), f, s, 88, 140);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBPicker
{
    public partial class RGB : Form
    {
        Graphics g;
        int redVal;
        int greenVal;
        int blueVal;
        int alphaVal;
        public RGB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            redVal = (int)numRedUD.Value;
            greenVal = (int)numGreenUD.Value;
            blueVal = (int)numBlueUD.Value;
            alphaVal = (int)numHue.Value;
            panel1.BackColor = Color.FromArgb(alphaVal, redVal, greenVal, blueVal);
            numHue.Value = (int)panel1.BackColor.A;
            numSaturation.Value = (int)Math.Ceiling(panel1.BackColor.GetSaturation());
        }
        private void numRedUD_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb((int)numRedUD.Value, (int)numGreenUD.Value, (int)numBlueUD.Value);
            redVal = (int)numRedUD.Value;
            SetColor();

        }

        private void numGreenUD_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb((int)numRedUD.Value, (int)numGreenUD.Value, (int)numBlueUD.Value);
            greenVal = (int)numGreenUD.Value;
            SetColor();

        }

        private void numBlueUD_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb((int)numRedUD.Value, (int)numGreenUD.Value, (int)numBlueUD.Value);
            blueVal = (int)numBlueUD.Value;
            SetColor();

        }

        private void numHue_ValueChanged(object sender, EventArgs e)
        {
            alphaVal = (int)numHue.Value;
            SetColor();
        }
        private void SetColor()
        {
            panel1.BackColor = Color.FromArgb(alphaVal, redVal, greenVal, blueVal);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        { 
        }
    }
}

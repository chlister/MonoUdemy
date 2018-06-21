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
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            panel1.BackColor = Color.FromArgb((int)numRedUD.Value,(int)numGreenUD.Value,(int)numBlueUD.Value);
        }
        private void numRedUD_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb((int)numRedUD.Value,(int)numGreenUD.Value,(int)numBlueUD.Value);
        }

        private void numGreenUD_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb((int)numRedUD.Value,(int)numGreenUD.Value,(int)numBlueUD.Value);
        }

        private void numBlueUD_ValueChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb((int)numRedUD.Value,(int)numGreenUD.Value,(int)numBlueUD.Value);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGraphics
{
    public class Face
    {
        private int _xpos;
        private int _ypos;
        private Color _faceColor;
        private Color _smileColor;


        public int Xpos { get => _xpos; set => _xpos = value; }
        public int Ypos { get => _ypos; set => _ypos = value; }
        public Color FaceColor { get => _faceColor; set => _faceColor = value; }
        public Color SmileColor { get => _smileColor; set => _smileColor = value; }

        public Face(int xpos, int ypos, Color faceColor, Color smileColor)
        {
            Xpos = xpos;
            Ypos = ypos;
            FaceColor = faceColor;
            SmileColor = smileColor;
        }

        public void PaintFace(Graphics gr)
        {
            SolidBrush fBrush = new SolidBrush(FaceColor);
            SolidBrush sBrush = new SolidBrush(SmileColor);
            Pen pen = new Pen(SmileColor, 2);

            gr.FillEllipse(fBrush, Xpos, Ypos, 80, 80); // Head
            gr.DrawEllipse(pen, Xpos + 20, Ypos + 30, 15, 7); // Eyes
            gr.DrawEllipse(pen, Xpos + 45, Ypos + 30, 15, 7);
            gr.FillEllipse(sBrush, Xpos + 25, Ypos + 31, 5, 5); // Pupils
            gr.FillEllipse(sBrush, Xpos + 50, Ypos + 31, 5, 5);
            gr.DrawArc(pen, Xpos + 20, Ypos + 50, 40, 15, 0, 180); // Mouth
        }
    }
}

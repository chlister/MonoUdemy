using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoAnimator
{
    public partial class FrmAnimation : Form
    {
        public FrmAnimation()
        {
            InitializeComponent();
        }
        Image[] images;
        int count = 0;
        bool goRight = true;
        private void FrmAnimation_Load(object sender, EventArgs e)
        {
            images = GetImage(Image.FromFile(@".\Assets\SnailRight.png"));
            picture_Box.Image = images[0];
            picture_Box.Size = picture_Box.Image.Size;
        }

        private void startStop_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picture_Box.Image = images[count];
            count++;
            if (count >= images.Length)
                count = 0;

        }
        /// <summary>
        /// Converts a single image og multiple frames to an array of image frames
        /// </summary>
        /// <param name="img"></param>
        /// <returns>Image[]</returns>
        private Image[] GetImage(Image img)
        {
            // Get the number of frames in image
            int cropNum = img.Width / img.Height;

            Bitmap[] bits = new Bitmap[cropNum];
            Bitmap bit = (Bitmap)img;

            // put the frames in the array
            for (int i = 0; i < cropNum; i++)
            {
                bits[i] = bit.Clone(new Rectangle((img.Height * i), 0, img.Height, img.Height), bit.PixelFormat);
            }

            return bits;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (goRight)
            {
                picture_Box.Location = new Point(picture_Box.Location.X + 1, picture_Box.Location.Y);
                if (picture_Box.Location.X == this.Width)
                {
                    goRight = false;
                    images = GetImage(Image.FromFile(@".\Assets\SnailLeft.png"));

                }
            }

            else
            {
                picture_Box.Location = new Point(picture_Box.Location.X - 1, picture_Box.Location.Y);
                if (picture_Box.Location.X == 0)
                {
                    goRight = true;
                    images = GetImage(Image.FromFile(@".\Assets\SnailRight.png"));
                }
            }

        }
    }
}

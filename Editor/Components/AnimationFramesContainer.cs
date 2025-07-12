using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Components
{
    public partial class AnimationFramesContainer : UserControl
    {
        List<PictureBox> frames = [];

        public AnimationFramesContainer()
        {
            InitializeComponent();
        }



        public void AddFrame(Bitmap frame)
        {
            var pictureBox = new PictureBox();
            pictureBox.Image = frame;
            pictureBox.Width = 30;
            pictureBox.Height = 30;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            
            frames.Add(pictureBox);

            flowLayoutPanel1.Controls.Add(pictureBox);

            if (frames.Count * 30 > flowLayoutPanel1.Width * 0.8)
                flowLayoutPanel1.Width += 200;
        }
    }
}

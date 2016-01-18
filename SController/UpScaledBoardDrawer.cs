using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SController
{
    class UpScaledBoardDrawer: AbstractBoardDrawer
    {


        public Bitmap RedrawCallback(Bitmap original, Rectangle rect)
        {
            var cropped = original.Clone(rect, original.PixelFormat);

            this.pBox.Image = new Bitmap(cropped, new Size(original.Width * 4, original.Height * 4));

            return original;
        }


        public UpScaledBoardDrawer(PictureBox pBox)
            : base(pBox)
        {



        }


    }
}

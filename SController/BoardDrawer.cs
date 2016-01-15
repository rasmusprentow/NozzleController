using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SController
{
    class BoardDrawer
    {

        private int height;
        private int width; 
        public BoardDrawer(int height, int width) {
            this.height = height;
            this.width = width; 
        }

          
        public Bitmap DrawBoard() {
            Bitmap bmp = new Bitmap(this.pBox.Width, this.pBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(new Pen(Color.Black), this.pBox.Width / 2, 0, this.pBox.Width / 2, pBox.Height);
                g.DrawLine(new Pen(Color.Black), 0, this.pBox.Width / 2, pBox.Width, this.pBox.Width / 2);

            }

            return bmp;
        }

    }
}

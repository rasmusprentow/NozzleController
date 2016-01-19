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
        public UpScaledBoardDrawer(PictureBox pBox) : base(pBox)
        {
            
        }

        protected override void _drawBoard(Graphics g)
        {
            DrawGrid(g);

            g.DrawLine(new Pen(Color.Black, 2), this.markerPosition.X, 0, this.markerPosition.X, Height);
            g.DrawLine(new Pen(Color.Black, 2), 0, this.markerPosition.Y, Width, this.markerPosition.Y);
        }
    }
}

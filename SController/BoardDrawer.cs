using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SController
{

    abstract class AbstractBoardDrawer
    {
         public int Height { 
            get { 
                return this.pBox.Height; 
            }
            private set { }
        }

        public int Width { get { return this.pBox.Width; } private set { } }
        protected PictureBox pBox;

        protected abstract void _drawBoard(Graphics g);

        protected AbstractBoardDrawer(PictureBox pBox) {

            this.pBox = pBox;

            this.markerPosition = new Point(Width / 2, Height / 2);
        }

        protected int lines = 10;
        protected Point markerPosition;


        protected Func<Bitmap, Rectangle, Bitmap> onRedrawListener;


        public void SetOnRedraw(Func<Bitmap, Rectangle, Bitmap> func)
        {
            this.onRedrawListener = func;
        }

        protected void CallRedrawListener(Bitmap bm, Rectangle rect)
        {
            if (this.onRedrawListener != null)
            {
                this.onRedrawListener.Invoke(bm, rect);
            }
        }



        public Bitmap DrawBoard()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                _drawBoard(g);
            }

            //this.CallRedrawListener(bmp, rect);

            this.pBox.Image = bmp;
            return bmp;
        }

        public Point MarkerPosition
        {
            get { return markerPosition; }

            set
            {
                this.markerPosition = value;
                this.DrawBoard();
            }

        }


        protected void DrawGrid(Graphics g)
        {
            int lineHeight = Height / lines;

            for (int i = 1; i <= lines; i++)
            {
                // Horizontal lines
                g.DrawLine(new Pen(Color.Gray), i * lineHeight, 0, i * lineHeight, Height);


                // Vertical lines                    
                g.DrawLine(new Pen(Color.Gray), 0, i * lineHeight, Width, i * lineHeight);
            }
        }
    }
    
    class BoardDrawer : AbstractBoardDrawer
    {

       
        
    
        public BoardDrawer(PictureBox pBox, Size innerBoxSize): base(pBox)
        {
            _rectS = innerBoxSize.Height;

        }


       

        protected int _rectS;



        protected override void _drawBoard(Graphics g)
        {
            DrawGrid(g);


            // Draw Rect
            var rect = new Rectangle(new Point(this.markerPosition.X - _rectS/2, this.MarkerPosition.Y - _rectS/2),
                new Size(_rectS, _rectS));
            g.DrawRectangle(new Pen(Color.Black, 2), rect);

            // Draw Marker

            g.DrawLine(new Pen(Color.Black, 2), this.markerPosition.X, 0, this.markerPosition.X, rect.Top);
            g.DrawLine(new Pen(Color.Black, 2), this.markerPosition.X, rect.Bottom, this.markerPosition.X, Height);
            g.DrawLine(new Pen(Color.Black, 2), 0, this.markerPosition.Y, rect.Left, this.markerPosition.Y);
            g.DrawLine(new Pen(Color.Black, 2), rect.Right, this.markerPosition.Y, Width, this.markerPosition.Y);
        }

       


        


    }
}

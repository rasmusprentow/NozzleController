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


        public AbstractBoardDrawer(PictureBox pBox) {

            this.pBox = pBox;
           
        }
    }
    
    class BoardDrawer : AbstractBoardDrawer
    {

       
        
        private int lines = 10;
        private Point markerPosition; 

       
        private Func<Bitmap, Rectangle, Bitmap> onRedrawListener;
        private int _rectS = 100;


        public BoardDrawer(PictureBox pBox): base(pBox) {

         
            this.markerPosition = new Point(Width / 2, Height / 2);
        }


        public void SetOnRedraw(Func<Bitmap, Rectangle, Bitmap> func)
        {
            this.onRedrawListener = func;
        }

        private void CallRedrawListener(Bitmap bm, Rectangle rect)
        {
            if(this.onRedrawListener != null ) {
                this.onRedrawListener.Invoke(bm, rect);
            }
        }
          
        public Bitmap DrawBoard() {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                int lineHeight = Height / lines; 

                for (int i = 1; i <= lines; i++ )
                {

                   // Horizontal lines
                   g.DrawLine(new Pen(Color.Gray), i * lineHeight, 0, i * lineHeight, Height);


                   // Vertical lines                    
                   g.DrawLine(new Pen(Color.Gray), 0, i * lineHeight, Width, i * lineHeight);
                }


                g.DrawLine(new Pen(Color.Black, 2), this.markerPosition.X, 0, this.markerPosition.X, Height);
                g.DrawLine(new Pen(Color.Black, 2), 0, this.markerPosition.Y, Width, this.markerPosition.Y);


             
                var rect = new Rectangle(new Point( this.markerPosition.X - _rectS/2, this.MarkerPosition.Y - _rectS / 2 ) , new Size(_rectS, _rectS));
                g.DrawRectangle(new Pen(Color.Black, 2), rect);
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


    }
}

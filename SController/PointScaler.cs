using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SController
{
    class PointScaler
    {

        private float scale = 0;

        public PointScaler(float scale)
        {
            this.scale = scale;
        }

        public Point ToRealPoint(Point point  ) {
            return new Point((int)(point.X * scale), (int) (point.Y * scale));
        }

    }
}

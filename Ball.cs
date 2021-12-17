using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    class Ball : IComparable,IFigure
    {
        private int r;
        public double volume;
        public int R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0) r = value;
            }
        }

        public string Show()
        {
            string inf = "Радиус:" + " " + R;
            return inf;
        }
        public int CompareTo(object obj)
        {

            Ball temp = (Ball)obj;

            if (this.volume > temp.volume) return 1;
            if (this.volume < temp.volume) return -1;
            return 0;
        }

        public double V()
        {
            return Math.Pow(r, 3) * 4 * 3.14 / 3;
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    class Ball : IComparable
    {
        public int volume, r;
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


    }
}
    


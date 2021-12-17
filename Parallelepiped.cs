using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_8
{
    class Parallelepiped : IComparable
    {
        public int volume, a, b, c;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0) a = value;
                else a = 0;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0) b = value;
                else b = 0;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0) c = value;
                else c = 0;
            }
        }
        public string Show()
        {
            string inf = "Длина:" + A + "\n" + "Ширина:" + B + "\n " + "Высота:" + C + "\n ";
            return inf;
        }
       
        
        
        public int CompareTo(object obj)// реализация интерфейса
        {

            Parallelepiped temp = (Parallelepiped)obj;

            if (this.volume > temp.volume) return 1;
            if (this.volume < temp.volume) return -1;
            return 0;
        }
    }
}

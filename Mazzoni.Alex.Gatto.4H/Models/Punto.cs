using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazzoni.Alex.Gatto._4H.Models
{
    class Punto
    {
        int _x;
        int _y;

        public int X
        {
            get
            {
                return _x;
            }

            set

            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set

            {
                _y = value;
            }
        }



        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Punto Trasla(int tx, int ty)
        {
            Punto z = new Punto(this.X + tx, this.Y + ty);

            return z;
        }

        public Punto Scala(int sx, int sy)
        {
            Punto z = new Punto(this.X * sx, this.Y * sy);

            return z;
        }
    }
}

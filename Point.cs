using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_AdvanceOOP
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Point(int x, int y) {
          X = x;                //  small و  Capital هنا   X  علشان ال  this  مش محتاج هنا 
          Y = y;
        }
        public override string ToString()  =>  $"({X},{Y})";
       

    }
}

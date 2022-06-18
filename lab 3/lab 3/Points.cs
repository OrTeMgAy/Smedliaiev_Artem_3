using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Points
    {
        public double X;
        public double Y;
        public Points()
        {
            X = 0;
            Y = 0;
        }
        public override bool Equals(object? obj)//переоприділяємо метод Equals
        {
            if (obj == null)
            {
                return false;
            }
            Points p = obj as Points;
            if (p as Points == null)
            {
                return false;
            }
            return p.X == this.X && p.Y == this.Y;
        }
        public override int GetHashCode()//переоприділяємо метод GetHashCode
        {
            return Convert.ToInt32((X+Y)*10000);
        }
        public override string ToString()//переоприділяємо метод ToString
        {
            {
                return base.ToString() + ": " + X + " " + Y;
            }
        }
    }
}

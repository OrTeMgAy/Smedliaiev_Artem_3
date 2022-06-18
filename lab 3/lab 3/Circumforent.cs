using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal abstract class Circumforent//окружність
    {
        protected double length { get; set; }
        public  Circumforent()//задаємо початкове значення
        {
            length = 1;
        }
        public override bool Equals(object? obj)//переоприділяємо метод Equals
        {
            if (obj == null)
            {
                return false;
            }
            Circumforent c = obj as Circumforent;
            if (c as Circumforent == null)
            {
                return false;
            }
            return c.length == this.length;
        }
        public override int GetHashCode()//переоприділяємо метод GetHashCode
        {
            return Convert.ToInt32(3.14*10000);
        }
        public override string ToString()//переоприділяємо метод ToString
        {
            return base.ToString() + ": " + length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Circle : Circumforent//коло наслідує окружність бо в колі є окружність
    {
        private double radius;
        private double diametr;
        Points center = new Points();//об'єкт класу точка - центр кола

        public Circle()//задаємо значення пр створенні об'єкту
        {
            length= 3.14;
            radius = 1;
            diametr = 2;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Радiус:{radius} координати центру:X:{center.X} Y:{center.Y} довжина кола:{length}");
        }
        public void Setting()//метод встановлює значення
        {
            Console.Clear();
            Console.WriteLine("Задайте розмiри");
            Console.WriteLine("Введiть радiус");
            radius = Convert.ToDouble(Console.ReadLine());
            diametr = radius * 2;
            length = diametr * 3.14;
            Console.WriteLine("Введiть координату Х центра кола");
            center.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть координату У центра кола");
            center.Y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();            
        }
        public void RadiusChange()//метод міняє радіус
        {
            Console.Clear();
            Console.WriteLine("Змiнiть радiус");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            GetInfo();
        }
        public void PointCheck()//метод перевіряє чи належить (обєкт класу) точка до кола
        {
            Console.Clear();
            Points check = new Points();
            Console.WriteLine("Введiть координату Х ");
            check.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть координату Y ");
            check.Y = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if(radius == Math.Sqrt(Math.Pow((check.X+center.X), 2))+ Math.Pow((check.Y + center.Y), 2))
            {
                Console.WriteLine($"Точка з кординатами X = {check.X}, Y = {check.Y} належить колу");
            }
            else
            {
                Console.WriteLine("Точка не належить колу");
            }
        }
        public override bool Equals(object? obj)//переоприділяємо метод Equals
        {
            if(obj == null)
            {
                return false;
            }
            Circle c = obj as Circle;
            if(c as Circle == null)
            {
                return false;
            }
            return c.radius == this.radius && c.center == this.center; //порівняємо за значеннями радіусу і координат центру        
        }
        public override int GetHashCode()//переоприділяємо метод GetHashCode
        {
            return Convert.ToInt32(center.Y+center.X+radius);
        }
        public override string ToString()//переоприділяємо метод ToString
        {
            return base.ToString() + " " + radius.ToString() + " " + center.X.ToString() + " " + center.Y.ToString() + " " + diametr.ToString();
        }
    }
}

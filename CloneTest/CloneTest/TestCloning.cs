using System;
using System.Collections.Generic;
using System.Text;

namespace CloneTest
{
    class TestCloning
    {
        static void Main(string[] args)
        {
            var s1 = new Square(10);
            Console.WriteLine($"Square1 has side:{s1.Side}, Perimeter:{s1.Permimeter}, Area:{s1.Area}");

            var s2 = (Square)Copy(s1);
            Console.WriteLine($"Square copy has side:{s2.Side}, Perimeter:{s2.Permimeter}, Area:{s2.Area}");

            s1.Side = 15;
            Console.WriteLine($"Square1 has side:{s1.Side}, Perimeter:{s1.Permimeter}, Area:{s1.Area}");
            Console.WriteLine($"Square copy has side:{s2.Side}, Perimeter:{s2.Permimeter}, Area:{s2.Area}");

            var c1 = new Circle(5);
            Console.WriteLine($"Circle1 has radius:{c1.Radius}, Circumference:{c1.Circumference}, Area:{c1.Area}");
            var c2 = (Circle)Copy(c1);
            Console.WriteLine($"Circle copy has radius:{c2.Radius}, Circumference:{c2.Circumference}, Area:{c2.Area}");

            c2.Radius = 8;
            Console.WriteLine($"Circle1 has radius:{c1.Radius}, Circumference:{c1.Circumference}, Area:{c1.Area}");
            Console.WriteLine($"Circle copy has radius:{c2.Radius}, Circumference:{c2.Circumference}, Area:{c2.Area}");


        }

        private static object Copy(ICloneable objecty)
        {
            return objecty.Clone();
        }



    }
}

using System;

namespace CSharpTutorial
{

    //instance class
    class Circle
    {
         float _pi = 3.141f;
         int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public float CalculateArea()
        {
            return _pi * _radius * _radius;
        }
    }

    class Program
    {
        static void Main()
        {
         
            Circle c1 = new Circle(5);
            float area = c1.CalculateArea();
            Console.WriteLine("Area is {0}", area);

            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();
            Console.WriteLine("Area is {0}", area2);

        }
    }
}


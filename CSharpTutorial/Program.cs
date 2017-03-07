using System;

namespace CSharpTutorial
{

    //instance class
    class Circle
    {
         static float _pi; // marking this static means that it will be shared across all instances.
                                    // _pi does not change on a per object basis so it makes sense to make it static
         int _radius;

        static Circle()
        {
            //use static constructor to initialize static fields
            _pi = 3.141f;
        }

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


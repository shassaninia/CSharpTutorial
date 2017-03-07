using System;

namespace CSharpTutorial
{

    //instance class
    class Circle
    {
         public static float _pi; // marking this static means that it will be shared across all instances.
                                    // _pi does not change on a per object basis so it makes sense to make it static
         int _radius;

        static Circle()
        {
            Console.WriteLine("static constructor called once");
            //use static constructor to initialize static fields
            _pi = 3.141f;
        }

        public Circle(int radius)
        {
            Console.WriteLine("instance construstor called for every instance");
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
         
            Console.WriteLine(Circle._pi);

        }
    }
}


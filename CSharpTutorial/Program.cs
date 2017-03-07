using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main()
        {
            string name = null; //refrence types can be set to null

           // int i = null; //This will not compile because a value type can't be set to null

            int? i2 = null; //This can be set to null because it is a nullable int (? after the type)


        }
    }
}


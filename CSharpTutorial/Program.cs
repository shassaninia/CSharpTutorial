using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main()
        {
            //Built-in types

            bool b = true; //true or false

            sbyte sb = 55; //-128 to 127

            byte by = 5; //0 to 255

            char c = 'C'; //U+0000 to U+ffff

            short s = 200; // -32,768 to 32,767

            ushort us = 100; // 0 to 65,535

            int i = 300; // -2,147,483,648 to 2,147,483,647

            uint ui = 400; // 0 to 4,294,967,295

            long l = 500; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ulong ul = 10000; // 0 to 18,446,744,073,709,551,615

            float f = 4.5f; //+/- 1.5e-45 to +/- 3.4e38 (7 digits precision)

            double d = 7.233; //+/- 5.0e-324 to +/1.7e308 (15 - 16 digists precision)

            decimal dec = 7.39393939204823048209428094m; // (-7.9x10^28 to 7.9 x 10^28) / (10^0 to 28 ) - Precison is 28 - 29 digits

            string str = "This is a string"; //string is a reference type stored on the heap

            str = "\"Escape a quote\""; //escape double quotes so it is part of the string

            str = "Print\nnewline"; // = \n - new line

            // \\ escape to show \ in string or you can precede the string with a @ like:

            str = @"c:\verbatim-literal";




        }
    }
}


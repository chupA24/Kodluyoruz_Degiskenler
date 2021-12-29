using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool b1 = true;
            bool b2 = false;

            byte byte1 = new byte();
            Console.WriteLine(byte1.ToString());

            byte byte2 = 255;
            Console.WriteLine(byte2.ToString());

            sbyte sb1 = 8;

            Int16 i16 =255;
            Int32 i32 =23;

            float fl = 2.5f;
            double d1 = 9d;
            Console.WriteLine(fl.ToString());
            Console.WriteLine(d1.ToString()); 

        }
    }
}

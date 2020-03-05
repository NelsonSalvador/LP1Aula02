using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            uint j = uint.MaxValue;
            int i = short.MaxValue;
            float f1, f2;

            Console.WriteLine((uint)(j + 1));
            Console.WriteLine((short)(i+1));
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0004f);
              
        }
    }
}

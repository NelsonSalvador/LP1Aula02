﻿using System;

namespace Incdec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            a = (a++ + a++);
            Console.WriteLine(a);

        }
    }
}

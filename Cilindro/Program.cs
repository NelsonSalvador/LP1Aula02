using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string a_s, rs;
            float v, s, a, r;

            Console.Write("Altura: ");
            a_s = Console.ReadLine();

            Console.Write("Raio: ");
            rs = Console.ReadLine();

            a = float.Parse(a_s);
            r = float.Parse(rs);

            v = (float)Math.PI* (float)Math.Pow(r, 2) * a;
            s = 2*(float)Math.PI*r*(r+a);
            Console.WriteLine($"Volume = {v,8:f2}");
            Console.WriteLine($"Area = {s,8:f2}");
        }
    }
}

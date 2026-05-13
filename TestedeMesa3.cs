using System;

namespace TestedeMesa03
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] v = new int[8];
            int a = 7;
            int b = a - 6;

            while (b < a)
            {
                v[b] = b + a;
                Console.WriteLine(v[b]);
                b = b + 2;
            }
        }
    }
}

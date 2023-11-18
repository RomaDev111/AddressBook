using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int steps = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                System.Console.WriteLine(n + ">>");
                steps++;
            }
            //Agar 1 ga teng bulsa 1 ni chiqar degan joyi qayerda

        }
    }
}




using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = Convert.ToInt32(Console.ReadLine());
            double i = 0.15;
            double VAT = price * i;
            Console.WriteLine(VAT + price);
        }
    }
}

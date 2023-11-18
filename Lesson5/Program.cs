
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = random.Next(1, 100);
            int attempts = 0;

            System.Console.WriteLine("Sirli raqamni topadigan o'yinga xush kelibsiz!");
            System.Console.WriteLine("Man 1 dan 100 gacha son o'laganman, ushbu sonni toping");

            while (true)
            {
                System.Console.Write("Sonni kiriting: ");
                if (string userGuess = Convert.ToInt32(Console.ReadLine()))
                    {
                    attempts++;
                    if (userGuess < secretNumber)
                    {
                        System.Console.WriteLine("Siz kiritgan son o'langan sondan kichik, Boshqatdan urinib ko'ring");
                    }
                    else if (userGuess > secretNumber)
                    {
                        System.Console.WriteLine("Siz kiritgan son o'langan sondan katta, Boshqatdan urinib ko'ring");
                    }
                    else
                    {
                        System.Console.WriteLine("Tabriklaymiz siz to'ri topdingiz!!!");
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Iltomos son kiriting!");
                }

            }
            Console.ReadLine();
        }
    }
}

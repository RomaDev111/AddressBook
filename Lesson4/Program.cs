using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fanlar = { "Ingliz tili", "Matematika", "Fizika", "Ona tili", "Informatika", "Tarix", "Kimyo", "Biologiya", "Rus tili", "Chizmachilik" };
            string[] tanlanganFanlar = new string[5];
            Console.WriteLine("Quyidagi fanlarni birinchi tanlang:  ");
            for (int i = 0; i < fanlar.Length; i++)
            {
                Console.Write(fanlar[i] + ", ");
            }
            for (int l = 0; l < 5; l++)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                tanlanganFanlar[l] = fanlar[s];
            }
            foreach (string l in tanlanganFanlar)
            {
                Console.WriteLine(l);
            }
        }
    }
}


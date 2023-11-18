using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 6;
            string message = choice switch
            {
                1 => "Mercury",

                2 => "Venus",

                3 => "Earth",

                4 => "Mars",

                5 => "Jupiter",

                6 => "Saturn",

                7 => "Uranus",

                8 => "Neptune",
                _ => "default"

            };
            Console.WriteLine(message);
        }
    }
}

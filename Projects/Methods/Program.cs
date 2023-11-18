using System;

    namespace MyFirstProgram
    {  
    class Program 
        {
            static void Main(string[] args)
            {
                string name = "Dilshod";
                int age = 23;

                SingHappyBirthday(name, age);
            
            }
            static void SingHappyBirthday(string name, int age)
            {
                Console.WriteLine("Hello, " + name);
                Console.WriteLine("Hi how you doing?");
                Console.WriteLine("Your age is " + age);

            }
        }
    }

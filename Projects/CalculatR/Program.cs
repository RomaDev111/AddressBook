using System;
using CalculatR.Classes;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetics arithmetics = new Arithmetics();
            ComplexMath complexMath = new ComplexMath();
            Logger logger = new Logger();

            logger.Print("***********************************************");
            logger.Print("Assalomu alaykum kalykulatorga xush kelibsiz!!!");
            logger.Print("Quyidagi arifmetik amallardan birini tanlang:\n 1. Sodda amallar: (+, -, *, /, %) \n 2. Murakkab amallar: Ildiz");
            Program.Print1(">> ");
            string userChoice = GetUserInput();

            if (userChoice == "1")
            {
                logger.Print("Sodda amallar quyidagilar (+, -, *, /, %): ");
                float firstNumber;
                float secondNumber;
                string operation;

                Program.Print1("Birinchi sonni kiriting: ");
                string firstNumberInput = GetUserInput();
                firstNumber = Convert.ToSingle(firstNumberInput);

                Program.Print1("Amalni kiriting (+, -, /, *, %): ");
                operation = GetUserInput();

                Program.Print1("Ikkinchi sonni kiriting: ");
                string secondNumberInput = GetUserInput();
                secondNumber = Convert.ToSingle(secondNumberInput);

                if (operation == "+")
                {
                    logger.Print($"{firstNumber} + {secondNumber} = {arithmetics.Sum(firstNumber, secondNumber)}");
                }
                else if (operation == "-")
                {
                    logger.Print($"{firstNumber} - {secondNumber} = {arithmetics.Substruct(firstNumber, secondNumber)}");
                }
                else if (operation == "*")
                {
                    logger.Print($"{firstNumber} * {secondNumber} = {arithmetics.Multiply(firstNumber, secondNumber)}");
                }
                else if (operation == "/")
                {
                    logger.Print($"{firstNumber} / {secondNumber} = {arithmetics.Divide(firstNumber, secondNumber)}");
                }
                else if (operation == "%")
                {
                    logger.Print($"{firstNumber} % {secondNumber} = {complexMath.Persentage(firstNumber, secondNumber)}");
                }
                else
                {
                    logger.Print("Notanish qiymat kiritildi. Dasturni qayta ishga tushiring!");
                }
                logger.Print("Dasturimizni ishlatganingiz uchun rahmat!");
                logger.Print("*****************************************");

            }
            else if (userChoice == "2")
            {
                logger.Print("Siz Ildiz amalini tanladingiz!");
                float firstNumber1;
                Program.Print1("Sonni kiriting: ");
                string firstNumberInput = GetUserInput();
                firstNumber1 = Convert.ToSingle(firstNumberInput);
                logger.Print($"{firstNumberInput} ning ildizi {complexMath.Sqrt(firstNumber1)}");
                logger.Print("Dasturimizni ishlatganingiz uchun rahmat!");
                logger.Print("*****************************************");
            }
            else
            {
                logger.Print("Notanish qiymat kiritildi. Dasturni qayta ishga tushiring!");
            }
        }
        static void Print1(string text)
        {
            Console.WriteLine(text);
        }
        static string GetUserInput()
        {
            return Console.ReadLine();
        }

    }
}
using System;
using Lesson10.Classes;
namespace Hangman
{
    class Program
    { 
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Print("Hangman uyiniga hush kelibsiz!");
            logger.Print("Guess a word:");
            string[] word = { "H", "E", "L", "L", "O" };
            string[] hiddenLetters = { "-", "-", "-", "-", "-" };
            string[] explanations = {"Sirli so'zning birinchi harfi Ingliz tilidagi OT so'zining birinchi harfi", "Ikkinchi harf Ingliz tilidagi QULOQ so'zining birinchi harfi ", "Uchinchi harf Ingliz tilidagi SHER(hayvon) so'zining birinchi harfi ", "To'rtinchi harf Ingliz tilidagi HAYOT so'zining birinchi harfi ", "Beshinchi harf Ingliz tilidagi OBYEKT so'zining birinchi harfi" };

            foreach (string letter in hiddenLetters) 
            {
                Console.Write(letter);
                
            }
            for (int i = 0; i < word.Length; i++)
            {
                logger.Print($"\nThe {i + 1} letter is: {explanations[i]}");
                Console.Write("Enter your guess:");
                string userInput = Console.ReadLine();
                if (userInput == word[i])
                {
                    logger.Print("You have guessed a Letter!!!\nPlease move to the second letter.");
                    hiddenLetters[i] = userInput;
                }
                else
                {
                    logger.Print("Incorrect guess. Please reenter the letter.");
                    i--;
                }

                foreach (string  letter in hiddenLetters)
                {
                    Console.Write(letter);
                }
            }

            logger.Print("\nCongratulations! You have guessed a word!!!");

        }
    }
}

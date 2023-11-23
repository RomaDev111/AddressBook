namespace Lesson12.Classes
{
    public class Division
    {
        public static double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
    }
}

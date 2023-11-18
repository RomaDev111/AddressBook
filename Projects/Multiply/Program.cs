namespace   MyFisrtProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;
            Console.Write("Please, enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please, enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            System.Console.WriteLine(result);
            
        }
        static double Multiply(double x, double y)
        {
            
              return x * y;
        }
    }
}
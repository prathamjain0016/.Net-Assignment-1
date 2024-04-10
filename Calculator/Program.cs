namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            double sum = Add.Addition(number1, number2);
            Console.WriteLine("The sum is " + sum);



        }
    }
}

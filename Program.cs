namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 number = -1;

        // Check For A number Or A String
        askNumInput:
            Console.Write("Enter a number: ");
            bool isNum = Int32.TryParse(Console.ReadLine(), out number);
            if (!isNum)
            {
                Console.WriteLine("Invalid Input!");
                goto askNumInput;
            }

            // Check For isPrime Or Not
            if (number < 2)
            {
                Console.WriteLine($"{number} is not a prime!");
                return;     // Exit The Program
            }

            int milestone = 2;
            bool isPrime = true;

            while (milestone <= Math.Sqrt(number))
            {
                if (number % milestone == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            // Print Out Message
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime!");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime!");
            }
        }
    }
}
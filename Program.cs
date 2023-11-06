namespace nov3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("to check divisibility by 2, please enter a number:"); // initial prompt: number for divisibility by 2 to be checked.
            if (int.TryParse(Console.ReadLine(), out int number))
            {                Console.WriteLine($"you entered {number}.");
                CheckDivisibilityByTwo(number); // < CheckDivisibilityByTwo method below.

                Console.WriteLine("do you want to check divisibility by another number? (Y/N)"); // asks if user wants to check custom divisibility.
                string choice = Console.ReadLine();
                if (choice.Trim().ToUpper() == "Y") // if user responds "y" (yes)
                {
                    Console.WriteLine("please enter another number:"); // code proceeds, prompts for first number.
                    string number2 = Console.ReadLine(); 
                    if (int.TryParse(number2, out int intNumber2)) // if input number is able to be converted to an int:
                    {
                        Console.WriteLine("enter another number to divide the previous number by:"); // prompts user for second number
                        string divisor2 = Console.ReadLine(); // divisor2 init/assignment
                        if (int.TryParse(divisor2, out int intDivisor2)) // if input number is able to be converted to an int:
                        {
                            Console.WriteLine($"you entered {intDivisor2}.");
                            CheckDivisibility(intNumber2, intDivisor2); // checks custom divisibility using the CheckDivisibility method below.
                        }
                        else
                        {
                            Console.WriteLine("invalid input for the second number."); // if user inputs a non-int
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid input for the second number."); // if user inputs another non-int
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid input for the first number.");
            }
        }

        static void CheckDivisibilityByTwo(int number) // CheckDivisibilityByTwo method:
        {
            if (number % 2 == 0) // checks if number mod 2 == 0
            {
                Console.WriteLine($"{number} is divisible by 2."); // if true, number is divisible by 2.
            }
            else
            {
                Console.WriteLine($"{number} is NOT divisible by 2."); // if false, number is not divisible by 2.
            }
        }

        static void CheckDivisibility(int intNumber2, int intDivisor2) // CheckDivisibility method:
        {
            if (intDivisor2 == 0) // checks if intDivisor2 == 0
            {
                Console.WriteLine("cannot divide by zero."); // (if true, cannot divide by zero)
            }
            else if (intNumber2 % intDivisor2 == 0) // checks if intNumber2 mod intDivisor2 == 0
            {
                Console.WriteLine($"{intNumber2} is divisible by {intDivisor2}."); // if true, intNumber2 is divisible by intDivisor2
            }
            else
            {
                Console.WriteLine($"{intNumber2} is NOT divisible by {intDivisor2}."); // if false, intNumber2 is not divisible by intDivisor2.
            }
        }
    }
}

using System;

namespace Bonus01
{
    class Program
    {
        static void Main(string[] args)
        {   
            string userContinue = "y";

            do
            {
                Console.Write("Please enter a numerical grade from 1 - 100:");

                int.TryParse(Console.ReadLine(), out int intGrade);
                var getGrade = new GetGrade();


                Console.WriteLine($"Your grade is: {getGrade.GetGradeLetter(intGrade)}");
                Console.Write("Would you like to continue? y/n: ");
                userContinue = Console.ReadLine();
            } while (userContinue.ToLower() == "y");

            Console.WriteLine("Thanks! Have a nice day!");
        }
    }
}

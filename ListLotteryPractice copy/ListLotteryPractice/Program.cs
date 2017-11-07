using System;
using System.Collections.Generic;
namespace ListLotteryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottery lottery = new Lottery();
            Console.WriteLine("Welcome to the lottery program!");
            char choice = '0';
            // main loop
            while (choice != 3)
            {
                //options list
                Console.WriteLine("1 - Lot the next number please!");
                Console.WriteLine("2 - Print the list please!");
                Console.WriteLine("3 - Quit the program!");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reaction to the choice
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("You got a: {0}", lottery.Lot());
                        break;
                    case '2':
                        Console.WriteLine("Numbers Drawn: {0}", lottery.print());
                        break;
                    case '3':
                        Console.WriteLine("Thanks for using the lottery program!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again!");
                        break;
                }
            }
        }
    }
}

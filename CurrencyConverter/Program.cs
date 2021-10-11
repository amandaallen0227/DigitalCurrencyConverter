using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyLibrary;

namespace CurrencyConverter
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal bitcoin;
            decimal litecoin;
            decimal cash = 5000;
            decimal etherium;

            bool exitMain = false;
            do
            {
                Console.WriteLine("Welcome to the Digital Currency party!!\n\nPlease select an option below: ");
                Console.WriteLine("Press 'A' to check all accounts");
                Console.WriteLine("Press 'T' to transfer funds bewtween currencies.");
                ConsoleKey choice = Console.ReadKey().Key;

                switch (choice)
                {
                    case ConsoleKey.A:
                        Console.WriteLine();
                        break;

                    case ConsoleKey.T:
                        break;
                    default:
                        break;
                }
            } while (!exitMain);
        }
    }
}

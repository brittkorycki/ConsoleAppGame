using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleGame
{
    
    public class ProgramUI
    {
        private CasinoRoyale.Program1 program1 = new CasinoRoyale.Program1();

        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to Casino Royale.\n" +
                    "Would you like to play BlackJack?");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "y":
                    case "yes":
                        program1.Deal();
                        break;

                    case "n":
                    case "no":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}

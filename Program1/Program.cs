using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoRoyale
{
    public class Program1
    {
        public void Deal()
        {


            int playerHand = 0;
            int dealerHand = 0;

            

                Random random = new Random();

                playerHand += random.Next(1, 12);
                playerHand += random.Next(1, 12);
                dealerHand += random.Next(1, 12);
                dealerHand += random.Next(1, 12);

                if (playerHand > 21)
                {
                    playerHand -= 10;
                }
            if (dealerHand == 21)
            {
                dealerHand += 0;
            }

                while (true)
                {
                    if (playerHand == 21)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (playerHand < 21)
                    {
                        Console.WriteLine("Would you like to hit? 'y' or 'n'");

                    }
                    Console.WriteLine("Current Score:" + playerHand);

                    string reply = Console.ReadLine();

                    if (reply == "n")

                    {
                        dealerHand += random.Next(1, 12);

                        if (dealerHand > 21)
                        {
                            Console.WriteLine("The dealer busted! You've won!\n" +
                                "Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }

                        else if (dealerHand < playerHand)
                        {
                            Console.WriteLine("You had the better hand! Congratulations!\n" +
                                "Press any key to continue...");
                            Console.ReadLine();
                        }

                        else if (playerHand < dealerHand)
                        {
                            Console.WriteLine("The dealer had the better hand! You've Lost!\n" +
                                "Press any key to continue...");
                            Console.ReadLine();
                            break;
                        }
                        else if (playerHand == dealerHand)
                        {
                            Console.WriteLine("It appears theres been a tie!\n" +
                                "Press any key to continue...");
                            Console.WriteLine("Current Score:" + playerHand);
                            Console.WriteLine("Dealer's Score:" + dealerHand);
                            Console.ReadLine();
                            break;
                        }
                    }

                    if (reply == "y")
                    {
                        playerHand += random.Next(1, 12);
                        dealerHand += random.Next(1, 12);

                        if (playerHand > 21)
                        {
                            Console.WriteLine("You Busted!\n" +
                                "Press any key to continue...");
                            Console.ReadLine();
                            break;

                        }
                        else if (playerHand < 21)
                        {
                            Console.WriteLine("Would you like a hit? 'y' or 'n' ");
                            Console.WriteLine("Current Score:" + playerHand);
                            string repliedYes = Console.ReadLine();

                            if (repliedYes == "y")
                            {
                                playerHand += random.Next(1, 12);
                                dealerHand += random.Next(1, 12);

                                if (dealerHand > 21)
                                {
                                    Console.WriteLine("The dealer Has busted\n" +
                                        "Press any key to continue...");
                                    break;
                                }
                                else if (playerHand > 21)
                                {
                                    Console.WriteLine("Oh no! You busted!\n" +
                                        "Press any key to continue...");
                                    break;
                                }
                                else if (playerHand < dealerHand)
                                {
                                    Console.WriteLine("You've Won!\n" +
                                        "Press any key to continue...");
                                    break;

                                }
                                else if (dealerHand > playerHand)
                                {
                                    Console.WriteLine("You've Lost. Better Luck Next Time!\n" +
                                        "Press any key to continue...");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            if (repliedYes == "n")


                            {
                                dealerHand += random.Next(1, 12);

                                if (dealerHand > 21)
                                {
                                    Console.WriteLine("The dealer busted! You've won!\n" +
                                        "Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (dealerHand < playerHand)
                                {
                                    Console.WriteLine("You had the better hand! Congratulations!\n" +
                                        "Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }



                                else if (playerHand < dealerHand)
                                {
                                    Console.WriteLine("The dealer had the better hand! You've Lost!\n" +
                                        "Press any key to continue...");
                                    Console.ReadLine();
                                    break;
                                }
                                else if (playerHand == dealerHand)
                                {
                                    Console.WriteLine("It appears theres been a tie!\n" +
                                        "Press any key to continue...");
                                    Console.WriteLine("Current Score:" + playerHand);
                                    Console.WriteLine("Dealer's Score:" + dealerHand);
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }
                    }
                }

            }

        }
    
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, you will be playing war.\n");

            //declare variables
            Random rand = new Random();
            int player1Wins = 0;
            int player2Wins = 0;
            int player1Score=0;
            int player2Score=0;

            //intro  message
            char choice = 'N';
            Console.WriteLine("Ready to play? (y/n)\n");
            choice = char.Parse(Console.ReadLine().ToUpper());

            // random value for dice roll
            rand = new Random();           
    
            //welcome message
            while (choice != 'N')
            {
                // loop for 21 rounds
                player1Wins = 0;
                player2Wins = 0;
                while (player1Wins + player2Wins < 21)
                {
                    //get score for players 1-13
                    player1Score = rand.Next(0, 14);   
                    player2Score = rand.Next(0, 14);
                   
                    // if tie - go to war
                    while (player1Score == player2Score)
                    {
                        Console.WriteLine("\nWar: " + "Player scores: " + player1Score+"\n");
                        player1Score = rand.Next(0, 14);
                        player2Score = rand.Next(0, 14);
                    }
                    
                    //check who won round and update the wins alue
                    if (player1Score > player2Score)
                    {
                        //clean up print out - check if p1 score is less than 10 - if so move the | over
                        if (player1Score < 10)
                        {
                            Console.WriteLine("Battle: player 1 score: " + player1Score + "  |  " + "player 2 score: " + player2Score + " => " + "Player 1 wins!");
                        }
                        else
                        {
                            Console.WriteLine("Battle: player 1 score: " + player1Score + " |  " + "player 2 score: " + player2Score + " => " + "Player 1 wins!");
                        }

                        player1Wins++;
                    }
                    else
                    {
                        //clean up print out - check if p1 score is less than 10 - if so move the | over
                        if (player1Score < 10)
                        {
                            Console.WriteLine("Battle: player 1 score: " + player1Score + "  |  " + "player 2 score: " + player2Score + " => " + "Player 2 wins!");
                        }
                        else
                        {
                            Console.WriteLine("Battle: player 1 score: " + player1Score + " |  " + "player 2 score: " + player2Score + " => " + "Player 2 wins!");
                        }
                        
                        player2Wins++;
                    }

                }
                
                //check who wins the 21 round game and print out results 
                if (player1Wins>player2Wins)
                {
                    Console.WriteLine("\nPlayer 1 wins, with " + player1Wins+" battels");
                }
                else 
                {
                    Console.WriteLine("\nPlayer 2 wins, with " + player2Wins+ " battels");
                }
                Console.WriteLine("\n___________________________________________________________________");
                Console.WriteLine("\nPlay again? (y/n)");
                Console.WriteLine("___________________________________________________________________\n");
                choice = char.Parse(Console.ReadLine().ToUpper());
            }
        }
    }
}

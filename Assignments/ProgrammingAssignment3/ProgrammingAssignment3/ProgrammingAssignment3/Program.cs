using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleCards;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// builds deck for blackjack
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //construct new deck
            Deck deck = new Deck();

            // create dealer and player hands
            BlackjackHand dealerHand = new BlackjackHand("dealer");
            BlackjackHand playerHand = new BlackjackHand("player");

            //print out welcome message
            Console.WriteLine("Welcome, this program plays a single hand of blackjack \n");

            //shuffle the deck
            deck.Shuffle();

            // deal 2 cards to each player 
            Card card1 = deck.TakeTopCard();
            Card card2 = deck.TakeTopCard();
            Card card3 = deck.TakeTopCard();
            Card card4 = deck.TakeTopCard();

            playerHand.AddCard(card1);
            playerHand.AddCard(card2);
            dealerHand.AddCard(card3);
            dealerHand.AddCard(card4);

            //make players cards face up
            playerHand.ShowAllCards();
            //make dealers first card face up
            dealerHand.ShowFirstCard();
            
            //print hands
            playerHand.Print();
            dealerHand.Print();

            //player hit or not
            playerHand.HitOrNot(deck);

            //turn over dealers other card
            dealerHand.ShowAllCards();

            //print both hands
            playerHand.Print();
            dealerHand.Print();

            // print scores
            Console.WriteLine("Player's score: "+playerHand.Score);
            Console.WriteLine("Dealer's score: " + dealerHand.Score);

            //find winner using score
            if (playerHand.Score > 21)
            {
                Console.WriteLine("\nPlayer busts, dealer wins");
            }
            else if (playerHand.Score>dealerHand.Score)
            {
                Console.WriteLine("\nPlayer wins!");
            }
            else if (playerHand.Score == dealerHand.Score ||
                (playerHand.Score>21 && dealerHand.Score>21))
            {
                Console.WriteLine("\nTie");
            }
            else
            {
                Console.WriteLine("\nDealer wins! \nPlay again.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {



            // want to try to implement suit deck loop
            // var deck = new List<string>() { };
            // var suit = new List<string>() { "Clubs", "Diamonds", "Hearts", "spades" };


            var deck = new List<string>() { "Ace of spades", "2 of spades", "3 of spades", "4 of spades", "5 of spades", "6 of spades", "7 of spades", "8 of spades",


             "9 of spades", "10 of spades", "Jack of spades", "Queen of spades", "King of spades" , "Ace of clubs", "2 of clubs", "3 of clubs", "4 of clubs", "5 of clubs",
             "6 of clubs", "7 of clubs", "8 of clubs", "9 of clubs", "10 of clubs", "Jack of clubs", "Queen of clubs", "King of clubs" , "Ace of hearts", "2 of hearts", "3 of hearts", "4 of hearts",
              "5 of hearts", "6 of hearts", "7 of hearts", "8 of hearts", "9 of hearts", "10 of hearts", "Jack of hearts", "Queen of hearts", "King of hearts" ,
               "Ace of diamonds", "2 of diamonds", "3 of diamonds", "4 of diamonds", "5 of diamonds", "6 of diamonds", "7 of diamonds", "8 of diamonds", "9 of diamonds",
                "10 of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds"
             };
            // had trouble with deck loop


            // deck.Add($"(rank) of (suit)");'




            var cardsInDeck = deck.Count;

            var randomNumber = new Random();

            for (var rightIndex = cardsInDeck - 1; rightIndex > 0; rightIndex--)
            {


                var leftIndex = randomNumber.Next(rightIndex);

                var leftCard = deck[rightIndex];

                var rightCard = deck[leftIndex];

                deck[rightIndex] = rightCard;

                deck[leftIndex] = leftCard;

            }

            Console.WriteLine(deck[0]);

            Console.WriteLine(deck[1]);


            // //  var King = rank[12];
            // // // var Ace = rank[5];

            // //  var swap = rank[12];
            // //  rank[12] = rank[5];
            // //  rank[5] = swap;


            // // Console.WriteLine(swap);



            // // for (var Right = n - 1; n > 1; n--)

            // for (var n = rank.Count - 1; n > 0; --n)

            // // for (var Right = n - 1; n > 0; n--)

            // {
            //     var left = r.Next(n + 1);


            //     var temp = rank[n];
            //     var rank[n] = rank[left];
            //     rank[Right] = rank[5];
            //     rank[5] = Left2;


            //     Console.WriteLine(n);


            // }
            // // Console.WriteLine();



        }
    }















    // var n = Diamonds.Count();



    // make n = number of cards in our deck

    // var n = deck.Count();


    // for rightIndex from n - 1 down to 1 do:
    // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex

    // Now swap the values at rightIndex and leftIndex by doing this:
    //     leftCard = the value from deck[rightIndex]
    //     rightChard = the value from deck[leftIndex]
    //     deck[rightIndex] = rightChard
    //     deck[leftIndex] = leftCard








}


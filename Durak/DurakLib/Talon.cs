/*  Talon.cs 
 *  Description - Represents a deck of cards in Durak, inherits from Deck class (Ch13CardLib)
 *                Talon
 *  Author  : Chris Calder     
 *  Version : 1.0    
 *  Since   : 1.0 , Feb 2017
 *  
 */
using Ch13CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGameLib
{
    class Talon : Deck
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Talon() { }

        /// <summary>
        /// Takes the supplied value and creates a deck of that size
        /// </summary>
        /// <param name="size">The size of the Deck</param>
        public void SetDeckSize(int size)
        {
            //// If deck size is 20....minimum rank is 10
            if (size == 20)
            {
                this.CreateDeck(Rank.Ten);
            }
            //// If deck size is 36....minimum rank is 6
            else if (size == 36)
            {
                this.CreateDeck(Rank.Six);
            }
            //// If deck size is 52....minimum rank is 2
            else if (size == 52)
            {
                this.CreateDeck(Rank.Deuce);
            }
            //// else throw exception invalid argument
            else
            {
                string errMsg = "The allowable deck sizes are 20, 36, 52";
                throw new ArgumentOutOfRangeException("paramName", errMsg);
            }
        }

        /// <summary>
        /// Creates a deck taht begins at the lowest card value given as parameter
        /// </summary>
        /// <param name="minRank">The lowest possible ranking card</param>
        public void CreateDeck(Rank minRank)
        {
            this.cards.Clear();         // Delete all card objects from deck if there are any inside

            for (Suit suitVal = Suit.Club; suitVal < Suit.Spade; suitVal++)
            {
                for (Rank rankVal = minRank; rankVal <= Rank.Ace; rankVal++)
                {
                    cards.Add(new Card(suitVal, rankVal));
                }
            }
        }
              
    }
}

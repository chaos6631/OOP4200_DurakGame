using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayingCardLib
{
    public class Card : ICloneable
    {
        #region STATIC MEMBERS
        
        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Club;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        #endregion

        #region MEMBERS AND PROPERTIES

        public readonly Suit suit;
        public readonly Rank rank;
        
        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="newSuit"></param>
        /// <param name="newRank"></param>
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        private Card()
        {
        }
        
        #endregion

        #region METHODS
        
        /// <summary>
        /// Clones the current card object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// OVERRIDE of ToString 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        /// <summary>
        /// An equality comparison between two card objects
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        /// <summary>
        /// A NOT equal comparison between two card objects
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        /// <summary>
        /// Checks if an object of basetype Object is equal to this Card object
        /// </summary>
        /// <param name="card">basetype Object</param>
        /// <returns></returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        /// <summary>
        /// Converts the card object to a hash code based on the numerical values of its members
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        /// <summary>
        /// Checks if the second card played is of higher value than the first
        /// </summary>
        /// <param name="card1">First card played</param>
        /// <param name="card2">Second card played</param>
        /// <returns></returns>
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else // If suits are not equal check if suit is trump
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// Checks if the second card played is of lesser value than the first
        /// </summary>
        /// <param name="card1">First card played</param>
        /// <param name="card2">Second card played</param>
        /// <returns></returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        /// <summary>
        /// Checks if the second card played is of equal or higher value than the first
        /// </summary>
        /// <param name="card1">First card played</param>
        /// <param name="card2">Second card played</param>
        /// <returns></returns>
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        /// <summary>
        /// Checks if the second card played is of equal or lesser value than the first
        /// </summary>
        /// <param name="card1">First card played</param>
        /// <param name="card2">Second card played</param>
        /// <returns></returns>
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        #endregion

    }
}

/**
 * TEST COMMENT  
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**Attribution
 * Cards provided by
 * Byron Knoll: http://code.google.com/p/vector-playing-cards/
 */

namespace Ch13CardLib
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
        public static Suit trump = Suit.Clubs;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        #endregion

        #region MEMBERS AND PROPERTIES

        /// <summary>
        /// Get/Set Suit
        /// </summary>
        protected Suit mySuit;
        public Suit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        /// <summary>
        /// Get/Set Rank
        /// </summary>
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        /// <summary>
        /// Flag that determines if the card is face-up or down
        /// </summary>
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="newSuit"></param>
        /// <param name="newRank"></param>
        public Card(Suit newSuit, Rank newRank)
        {
            mySuit = newSuit;
            myRank = newRank;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Card()
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
            string cardString; // holds card name
            //facing
            if (faceUp)
            {
                //if joker
                if (myRank == Rank.Joker)
                {
                    //Suit
                    if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                    {
                        cardString = "Black Joker";
                    }
                    else
                    {
                        cardString = "Red Joker";
                    }
                }
                //Not Joker
                else
                {
                    cardString = myRank.ToString() + " of " + mySuit.ToString();
                }
            }
            else //facedown
            {
                cardString = "Face Down";
            }
            return cardString;
        }

        /// <summary>
        /// An equality comparison between two card objects
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.Suit == card2.Suit) && (card1.Rank == card2.Rank);
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
            return 13 * (int)mySuit + (int)myRank;
        }

        /// <summary>
        /// Checks if the second card played is of higher value than the first
        /// </summary>
        /// <param name="card1">First card played</param>
        /// <param name="card2">Second card played</param>
        /// <returns></returns>
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.Suit == card2.Suit)
            {
                if (isAceHigh)
                {
                    if (card1.Rank == Rank.Ace)
                    {
                        if (card2.Rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.Rank == Rank.Ace)
                            return false;
                        else
                            return (card1.Rank > card2.Rank);
                    }
                }
                else
                {
                    return (card1.Rank > card2.Rank);
                }
            }
            else // If suits are not equal check if suit is trump
            {
                if (useTrumps && (card2.Suit == Card.trump))
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
            if (card1.Suit == card2.Suit)
            {
                if (isAceHigh)
                {
                    if (card1.Rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.Rank == Rank.Ace)
                            return false;
                        else
                            return (card1.Rank >= card2.Rank);
                    }
                }
                else
                {
                    return (card1.Rank >= card2.Rank);
                }
            }
            else
            {
                if (useTrumps && (card2.Suit == Card.trump))
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

        /// <summary>
        /// Gets the appropriate card image and returns it
        /// </summary>
        /// <returns></returns>
        public Image GetCardImage()
        {
            string imageName; // name of the image resource
            Image cardImage; //holds image

            //facedown
            if (!faceUp)
            {
                imageName = "Back";
            }
            else if (myRank == Rank.Joker) // joker
            {
                if (mySuit == Suit.Clubs || mySuit == Suit.Spades)
                {
                    imageName = "Black_Joker";
                }
                else
                {
                    imageName = "Red_Joker";
                }
            }
            else // faceup non-joker
            {
                imageName = mySuit.ToString() + "_" + myRank.ToString();
            }
            //Set the image to the appropriate image
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            return cardImage;
        }

        //DebugString
        public string DebugString()
        {
            string cardState = (string)(myRank.ToString() + " of " + mySuit.ToString()).PadLeft(20);
            cardState += (string)((FaceUp) ? "(Face Up)" : "(Face Down)").PadLeft(12);
            //cardState += ((altValue != null) ? "/" + altValue.ToString() : "");
            return cardState;
        }

        #endregion

    }
}

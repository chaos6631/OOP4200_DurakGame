/* Player.cs - The object for the user/player of the game,
 *  includes class and instance variables as well as default and paramaterized constructors.
 * 
 * Author : Cameron Fenton
 * Version : 1.1
 * Since : 1.0, Feb 2017
 */

using Ch13CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DurakGameLib
{
    public class Player
    {
        #region CLASS MEMBERS
        /// <summary>
        /// Class Members
        /// </summary>
        public const int MAX_PLAYER_NAME = 25;                          // Max length of the player name
        public const string DEFAULT_PLAYER_NAME = "DEFAULT PLAYER";     // The default player name
        public const int DEFAULT_GAMES_WON = 0;                         // The default number of games won by the player
        public const int DEFAULT_HANDS_WON = 0;                         // The default number of hands won by the player
        public const bool IS_DURAK = false;                             // The default DURAK value for the player

        #endregion              

        #region INSTANCE MEMBERS
        /// <summary>
        /// Instance Members
        /// </summary>
        private string playerName;          // The players name
        private Cards playerHand;           // The players cards as a hand
        private bool isDurak;               // IS PLAYER THE DURAK?
        private int gamesWon;               // The number of games won by this player
        private int handsWon;               // The number of hands won by this player

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor for the Player object
        /// </summary>
        public Player()
        {
            playerName = DEFAULT_PLAYER_NAME;      // Sets the players name to the default value
            playerHand = new Cards();              // Initializes the players cards
            isDurak = IS_DURAK;                    // Player is not durak by default
            gamesWon = DEFAULT_GAMES_WON;          // Assigns the default value for the number of games won 
            handsWon = DEFAULT_HANDS_WON;          // Assigns the default value for the number of hands won
        }

        /// <summary>
        /// Paramaterized constructor for Player, takes playerName as a string parameter
        /// </summary>
        /// <param name="playerName"></param>
        public Player(string playerName)
        {
            if (playerName.Length <= MAX_PLAYER_NAME && playerName.Length >= 1) // If the player name is less than or equal to max length of name
            {
                this.playerName = playerName; // Then set their name to the passed paramater
            }
            else
            {
                this.playerName = playerName.Substring(0, MAX_PLAYER_NAME); // else use the first characters of the string

                throw new NameOutOfRangeException(playerName); // Throws a new NameOutOfRangeException and passes the playerName
            }
            playerHand = new Cards();              // Initializes the players cards
            isDurak = IS_DURAK;                    // Player is not durak by default
            gamesWon = DEFAULT_GAMES_WON;          // Assigns the default value for the number of games won 
            handsWon = DEFAULT_HANDS_WON;          // Assigns the default value for the number of hands won
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Public method which plays a card from the players hand
        /// </summary>
        /// <param name="card"></param>
        public void PlayCard(Card card)
        {
            playerHand.Remove(card); // Removes the card played from the players hand
        }

        /// <summary>
        /// Picks up cards and adds them to the players hand
        /// </summary>
        /// <param name="cards"></param>
        public void PickUpCards(Cards cards)
        {
            foreach (Card card in cards) // For each card being picked up
            {
                playerHand.Add(card); // Add each to the players hand
            }
        }

        /// <summary>
        /// Takes a card from the deck as a parameter and adds it to the deck
        /// </summary>
        /// <param name="card"></param>
        public void TakeFromDeck(Card card)
        {
            playerHand.Add(card); // Adds the card from the deck to the players hand   
        }

        /// <summary>
        /// Getter & Setter for the player's name
        /// </summary>
        public string PlayerName
        {
            get { return playerName; } // Returns a string of the player's name
            set { playerName = value; } // Sets a string of the player's name
        }

        /// <summary>
        /// Getter & Setter for the player's hand
        /// </summary>
        public Cards PlayerHand
        {
            get { return playerHand; } // Returns the player's hand of cards
            set { playerHand = value; } // Sets the player's hand of cards
        }

        /// <summary>
        /// Getter & Setter for the boolean status of durak, if they have lost
        /// </summary>
        public bool IsDurak
        {
            get { return IsDurak; } // Returns the boolean status of the player is durak ( has lost ) 
            set { isDurak = value; } // Sets the boolean status of is durak
        }

        /// <summary>
        /// Getter & Setter for the player's number of games won
        /// </summary>
        public int GamesWon
        {
            get { return gamesWon; } // Returns the number of games won by the player
            set { gamesWon = value; } // Sets the number of games won by the player
        }

        /// <summary>
        /// Getter & Setter for the player's number of hands won
        /// </summary>
        public int HandsWon
        {
            get { return handsWon; } // Returns the number of hands won by the player
            set { handsWon = value; } // Sets the number of hands won by the player
        }
        #endregion
    }
}

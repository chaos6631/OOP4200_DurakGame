

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13CardLib;

namespace DurakGameLib
{
    class Game
    {
        #region CLASS MEMBERS
        // Max players
        // Min players
        static int[] DECK_SIZES = { 20, 36, 52 };        // Deck sizes
        static int INITIAL_PLAYER_CARD_COUNT = 6;       // Initial player card amount
        #endregion

        #region CONSTRUCTORS
        public Game()
        {
            //this.players = new Dictionary<string, Player>();

        }

        #endregion

        #region INSTANCE MEMBERS
        //private Dictionary<string, Player> players;
        private Player humanPlayer;
        private Player computerPlayer;
        private Talon gameDeck;
        private Card gameTrumpCard;

        #endregion

        #region ACCESSORS & MUTATORS
        /// <summary>
        /// Public property for humanPlayer
        /// </summary>
        public Player HumanPlayer
        {
            get
            {
                return humanPlayer;
            }

            set
            {
                humanPlayer = value;
            }
        }

        /// <summary>
        /// Public property for computerPlayer
        /// </summary>   
        public Player ComputerPlayer
        {
            get
            {
                return computerPlayer;
            }

            set
            {
                computerPlayer = value;
            }
        }

        /// <summary>
        /// Public property for gameTrumpCard
        /// </summary>
        public Card GameTrumpCard
        {
            get
            {
                return gameTrumpCard;
            }

            set
            {
                gameTrumpCard = value;
            }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// Commence the next round of the current game
        ///  - Should be called when PlayRound_event
        /// </summary>
        public void PlayNextRound()
        {
            //// Deal cards to players
            for (int i = 1; i <= INITIAL_PLAYER_CARD_COUNT; i++)
            {
                humanPlayer.TakeFromDeck(gameDeck.GetCard());
                computerPlayer.TakeFromDeck(gameDeck.GetCard());
            }
            //// Set trump card
            gameTrumpCard = gameDeck.GetCard();

            //// Decide which player goes first
            if (HumanIsAttacker())
            {
                // Get card(s) played by player
                    // If computer 
            }
            else
            {               
                // Get card(s) played by computer
            }

        }

        /// <summary>
        /// Individual players actions
        /// </summary>
        public void PlayerRound()
        {
            // select cards to play
            // play cards
            // opposite player chooses cards to play
                // if opposite player chooses to pass, opposite player picks up cards
        }

        /// <summary>
        /// Start the current game, string should be validated in the GUI
        /// </summary>
        public void StartGame(string playerName)
        {
            //// Initialize Players
            try
            {            
                //// Get choice of deck size from user
                int deckSize = 36;              // should come from event

                //// Initialize Deck and Deal cards
                this.gameDeck = new Talon();

                //// Set deck to required size                
                this.gameDeck.SetDeckSize(deckSize);
            }
            catch (Exception)
            {
                throw;
            }            
        }

        /// <summary>
        /// End the current game
        /// </summary>
        public void EndGame() { }
        
        /// <summary>
        /// Checks if the human player is the attacker
        /// </summary>
        /// <returns>True if human is attacker, false if not</returns>
        public bool HumanIsAttacker()
        {
            bool humanGoesFirst = true;
            if (humanPlayer.IsDurak == false && computerPlayer.IsDurak == false)
            {
                //// Player with lowest trump is the attacker                
                foreach (Card humanCard in humanPlayer.PlayerHand)
                {
                    if (humanCard.suit == gameTrumpCard.suit)
                    {
                        foreach (Card computerCard in computerPlayer.PlayerHand)
                        {
                            if (computerCard.suit == gameTrumpCard.suit
                                && computerCard.rank < humanCard.rank)
                            {
                                humanGoesFirst = false;
                            }
                        }
                    }
                }
            }
            else if (computerPlayer.IsDurak == false)
            {
                //// human plays as attacker
                humanGoesFirst = true;
            }
            else
            {
                //// computer plays as attacker
                humanGoesFirst = false;
            }
            return humanGoesFirst;
        }
        #endregion
    }
}

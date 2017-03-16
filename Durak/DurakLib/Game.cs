

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
        static int[] DECK_SIZES = { 20, 36, 52};        // Deck sizes
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
        private Player human;
        private Player computer;
        private Talon gameDeck;


        #endregion

        #region ACCESSORS & MUTATORS
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, Player> Players
        {
            get
            {
                return players;
            }

            set
            {
                players = value;
            }
        }
        

        #endregion

        #region METHODS
        /// <summary>
        /// Commence the next round of the current game
        /// </summary>
        public void PlayNextRound()
        {
            //// Deal cards to players

            //// Decide which player goes first
            //if(human)
            
        }

        /// <summary>
        /// Start the current game, string should be validated in the GUI
        /// </summary>
        public void StartGame(string playerName)
        {
            //// Initialize Players
            try
            {
                this.players.Add("Human", new Player(playerName));
                this.players.Add("Computer", new Player("Computer"));

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
        #endregion
    }
}

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
        // Deck sizes
        #endregion

        #region CONSTRUCTORS

        #endregion

        #region INSTANCE MEMBERS
        private Dictionary<string, Player> players;
        private Deck gameDeck;
        #endregion

        #region METHODS
        /// <summary>
        /// Commence the next round of the current game
        /// </summary>
        public void PlayNextRound() {  }

        /// <summary>
        /// Start the current game, string should be validated in the GUI
        /// </summary>
        public void StartGame(string playerName)
        {
            //// Initialize Players
            players.Add("Human", new Player(playerName));
            players.Add("Computer", new Player("Computer"));            

            //// Initializae Deck

            //// Decide which player goes first



        }

        /// <summary>
        /// End the current game
        /// </summary>
        public void EndGame() { }
        #endregion
    }
}

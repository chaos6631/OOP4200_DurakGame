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
        public const int MAX_PLAYER_NAME = 25;
        public const string DEFAULT_PLAYER_NAME = "DEFAULT PLAYER";
        #endregion              

        #region INSTANCE MEMBERS

        private string playerName;          // The players name
        private Cards playerHand;           // The players cards as a hand
        private bool isDurak;               // IS PLAYER THE DURAK?
        private int gamesWon;
        private int handsWon; 

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        { 
            // TODO 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerName"></param>
        public Player(string playerName)
        {
            // TODO
        }

        #endregion

        #region METHODS

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13CardLib;

namespace DurakGameLib
{
    class CardsPlayed : Cards
    {
        /// <summary>
        /// to be used by aiplayer to make decisions.
        /// this should be set when a human player plays a card, and it is added to the CardsPlayed object
        /// </summary>
        Card humanLastCardPlayed;        
        

        public Card HumanLastCardPlayed
        {
            get
            {
                return humanLastCardPlayed;
            }

            set
            {
                humanLastCardPlayed = value;
            }
        }
    }
}

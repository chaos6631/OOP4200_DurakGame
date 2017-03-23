/* NameOutOfRangeException.cs - The Exception for the user/player's when it is incorrectly provided
 * 
 * Author : Cameron Fenton
 * Version : 1.1
 * Since : 1.0, Feb 2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13CardLib
{
    /// <summary>
    /// Exception for when a name provided is out of range
    /// </summary>
    public class NameOutOfRangeException : Exception
    {
        /// <summary>
        /// String name for the name
        /// </summary>
        private string name;

        /// <summary>
        /// Returns the name passed
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Constructor for the exception
        /// </summary>
        /// <param name="playerName"></param>
        public NameOutOfRangeException(string playerName)
           : base("Player Name: " + playerName + " is not within 1 and 25 characters long!")
        {
            name = playerName;
        }
    }
}

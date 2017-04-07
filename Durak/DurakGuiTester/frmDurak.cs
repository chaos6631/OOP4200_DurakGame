using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakGuiTester
{
    public partial class frmDurak : Form
    {
        
        public frmDurak()
        {
            InitializeComponent();
        }

        private void frmDurak_Load(object sender, EventArgs e)
        {
            #region Get Player Name/Deck Size
            //Create frmStartup to retrieve player info
            Form playerDetails = new frmStartup();
            playerDetails.ShowDialog();
            #endregion
            
                       
            string name = frmStartup.playerName;
            int talonSize = frmStartup.talonSize;
            //THESE SHOULD BE HANDLED IN GAME 
            //Create Player
            DurakGameLib.Player playerOne = new DurakGameLib.Player(name);
            //Create Opponent
            DurakGameLib.Player opponent = new DurakGameLib.Player("cpu");

            //Create/Start Game
            DurakGameLib.Game myGame = new DurakGameLib.Game(playerOne, opponent);
            myGame.StartGame(talonSize);
            
            #region Populate Starting Display Controls
            //Names
            lblPlayerName.Text = name;
            lblOpponentName.Text = "CPU";
            //Roles
            if (playerOne.IsAttacker)
            {
                lblPlayerRole.Text = "Attacker";
                lblOpponentRole.Text = "Defender";
            }
            else
            {
                lblPlayerRole.Text = "Defender";
                lblOpponentRole.Text = "Attacker";
            }
            //Display hand

            //Talon
            cardTopDeck.Visible = true;
            //lblCardsRemainingDisplay.Text = myGame.gameDeck;
            //Trump
            CardUserControl.CardUserControl trumpCardDisplay = new CardUserControl.CardUserControl();
            pnlDeckArea.Controls.Add(trumpCardDisplay);
            trumpCardDisplay.Card = myGame.GameTrumpCard;           
            trumpCardDisplay.FaceUp = true;
            trumpCardDisplay.Show();            
            
            #endregion
        }
               
        /// <summary>
        /// When the number of cards in the deck reaches 0, hide the talon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCardsRemainingDisplay_TextChanged(object sender, EventArgs e)
        {
            
            //if ()
            //{
                //cardTopDeck.Visible = false;
            //}
            //For testing
            if (lblCardsRemainingDisplay.Text == "0")
            {
                cardTopDeck.Visible = false;
            }
        }

        
    }
}

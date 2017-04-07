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
    public partial class frmStartup : Form
    {       
        
        public static int talonSize
        {
            get;set;
        }

        
        public static string playerName
        {
            get;set;
        }

        public frmStartup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Player
            try
            {
                playerName = txtPlayerName.Text;
                if (playerName == "")
                {
                    playerName = "Player";
                }
                DurakGameLib.Player player1 = new DurakGameLib.Player(playerName);
                //Deck
                talonSize = Convert.ToInt32(lbxDeckSize.SelectedItem);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
           
        }
    }
}

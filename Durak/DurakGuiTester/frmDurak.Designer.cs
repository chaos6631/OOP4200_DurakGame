namespace DurakGuiTester
{
    partial class frmDurak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ch13CardLib.Card card1 = new Ch13CardLib.Card();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurak));
            this.pnlOpponent = new System.Windows.Forms.Panel();
            this.lblOpponentRole = new System.Windows.Forms.Label();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lblPlayerRole = new System.Windows.Forms.Label();
            this.pnlPlayArea = new System.Windows.Forms.Panel();
            this.pnlDeckArea = new System.Windows.Forms.Panel();
            this.lblCardsRemainingDisplay = new System.Windows.Forms.Label();
            this.lblCardsRemaining = new System.Windows.Forms.Label();
            this.cardTopDeck = new CardUserControl.CardUserControl();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.pnlOpponent.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.pnlDeckArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpponent
            // 
            this.pnlOpponent.BackgroundImage = global::DurakGuiTester.Properties.Resources.Borders;
            this.pnlOpponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOpponent.Controls.Add(this.lblOpponentRole);
            this.pnlOpponent.Location = new System.Drawing.Point(0, 0);
            this.pnlOpponent.Name = "pnlOpponent";
            this.pnlOpponent.Size = new System.Drawing.Size(1184, 120);
            this.pnlOpponent.TabIndex = 0;
            // 
            // lblOpponentRole
            // 
            this.lblOpponentRole.AutoSize = true;
            this.lblOpponentRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpponentRole.Location = new System.Drawing.Point(543, 105);
            this.lblOpponentRole.Name = "lblOpponentRole";
            this.lblOpponentRole.Size = new System.Drawing.Size(98, 15);
            this.lblOpponentRole.TabIndex = 3;
            this.lblOpponentRole.Text = "Defender/Attacker";
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackgroundImage = global::DurakGuiTester.Properties.Resources.Borders;
            this.pnlPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer.Controls.Add(this.lblPlayerRole);
            this.pnlPlayer.Location = new System.Drawing.Point(0, 562);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(1184, 120);
            this.pnlPlayer.TabIndex = 1;
            // 
            // lblPlayerRole
            // 
            this.lblPlayerRole.AutoSize = true;
            this.lblPlayerRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerRole.Location = new System.Drawing.Point(543, 0);
            this.lblPlayerRole.Name = "lblPlayerRole";
            this.lblPlayerRole.Size = new System.Drawing.Size(98, 15);
            this.lblPlayerRole.TabIndex = 4;
            this.lblPlayerRole.Text = "Defender/Attacker";
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BackgroundImage = global::DurakGuiTester.Properties.Resources.Borders;
            this.pnlPlayArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayArea.Location = new System.Drawing.Point(0, 288);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(900, 143);
            this.pnlPlayArea.TabIndex = 1;
            // 
            // pnlDeckArea
            // 
            this.pnlDeckArea.BackgroundImage = global::DurakGuiTester.Properties.Resources.Borders;
            this.pnlDeckArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeckArea.Controls.Add(this.lblCardsRemainingDisplay);
            this.pnlDeckArea.Controls.Add(this.lblCardsRemaining);
            this.pnlDeckArea.Controls.Add(this.cardTopDeck);
            this.pnlDeckArea.Location = new System.Drawing.Point(950, 288);
            this.pnlDeckArea.Name = "pnlDeckArea";
            this.pnlDeckArea.Size = new System.Drawing.Size(225, 143);
            this.pnlDeckArea.TabIndex = 2;
            // 
            // lblCardsRemainingDisplay
            // 
            this.lblCardsRemainingDisplay.AutoSize = true;
            this.lblCardsRemainingDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCardsRemainingDisplay.Location = new System.Drawing.Point(164, 119);
            this.lblCardsRemainingDisplay.Name = "lblCardsRemainingDisplay";
            this.lblCardsRemainingDisplay.Size = new System.Drawing.Size(19, 13);
            this.lblCardsRemainingDisplay.TabIndex = 5;
            this.lblCardsRemainingDisplay.Text = "36";
            this.lblCardsRemainingDisplay.TextChanged += new System.EventHandler(this.lblCardsRemainingDisplay_TextChanged);
            // 
            // lblCardsRemaining
            // 
            this.lblCardsRemaining.AutoSize = true;
            this.lblCardsRemaining.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCardsRemaining.Location = new System.Drawing.Point(40, 119);
            this.lblCardsRemaining.Name = "lblCardsRemaining";
            this.lblCardsRemaining.Size = new System.Drawing.Size(90, 13);
            this.lblCardsRemaining.TabIndex = 4;
            this.lblCardsRemaining.Text = "Cards Remaining:";
            // 
            // cardTopDeck
            // 
            card1.FaceUp = false;
            card1.Rank = Ch13CardLib.Rank.Joker;
            card1.Suit = Ch13CardLib.Suit.Clubs;
            this.cardTopDeck.Card = card1;
            this.cardTopDeck.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cardTopDeck.Enabled = false;
            this.cardTopDeck.FaceUp = false;
            this.cardTopDeck.Location = new System.Drawing.Point(132, 12);
            this.cardTopDeck.Name = "cardTopDeck";
            this.cardTopDeck.Rank = Ch13CardLib.Rank.Joker;
            this.cardTopDeck.Size = new System.Drawing.Size(80, 100);
            this.cardTopDeck.Suit = Ch13CardLib.Suit.Clubs;
            this.cardTopDeck.TabIndex = 3;
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpponentName.Location = new System.Drawing.Point(543, 144);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(87, 15);
            this.lblOpponentName.TabIndex = 4;
            this.lblOpponentName.Text = "Opponent Name";
            this.lblOpponentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerName.Location = new System.Drawing.Point(543, 533);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(69, 15);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.Location = new System.Drawing.Point(950, 447);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(225, 49);
            this.btnEndTurn.TabIndex = 6;
            this.btnEndTurn.Text = "&End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // frmDurak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.pnlDeckArea);
            this.Controls.Add(this.pnlPlayArea);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlOpponent);
            this.Name = "frmDurak";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.frmDurak_Load);
            this.pnlOpponent.ResumeLayout(false);
            this.pnlOpponent.PerformLayout();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlDeckArea.ResumeLayout(false);
            this.pnlDeckArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpponent;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Panel pnlPlayArea;
        private System.Windows.Forms.Panel pnlDeckArea;
        private System.Windows.Forms.Label lblOpponentRole;
        private System.Windows.Forms.Label lblPlayerRole;
        private CardUserControl.CardUserControl cardTopDeck;
        private System.Windows.Forms.Label lblCardsRemaining;
        private System.Windows.Forms.Label lblCardsRemainingDisplay;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnEndTurn;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ch13CardLib;

namespace CardUserControl
{
    public partial class CardUserControl : UserControl
    {
        #region FIELDS AND PROPERTIES
        //Card Property
        private Card myCard;
        public Card Card
        {
            set
            {
                myCard = value;
                UpdateCardImage(); // update card image
            }
            get { return myCard; }
        }
        //Suit
        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage(); // update card image
            }
            get { return Card.Suit; }
        }

        //Rank
        public Rank Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage(); // update card image
            }
            get { return Card.Rank; }
        }

        //Faceup
        public bool FaceUp
        {
            set
            {
                if (myCard.FaceUp != value) //card is flipping over
                {
                    myCard.FaceUp = value; //change property

                    UpdateCardImage();

                    //if there's a flip event handler
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs());
                }
            }
            get { return Card.FaceUp; }
        }

        //Orientation
        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                //If value is different than myOrientation
                if (myOrientation != value)
                {
                    myOrientation = value; //Change orientation
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage(); // update card image

                }
            }
            get { return myOrientation; }
        }

        //Update card image
        private void UpdateCardImage()
        {
            pbMyPictureBox.Image = myCard.GetCardImage();

            if (myOrientation == Orientation.Horizontal)
            {
                //rotate
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        #endregion

        #region CONSTRUCTORS
        //Default constructor
        public CardUserControl()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new Card();
        }
        //Parameterized constructor
        public CardUserControl(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
        }
        #endregion

        #region EVENTS AND EVENT HANDLERS
        //Load
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }
        //Flip delegate
        public event EventHandler CardFlipped;
        //Click event delegate
        new public event EventHandler Click;
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, e);//if ther is an event handler for click in client
        }
        #endregion

        #region OTHER METHODS
        //ToString
        public override string ToString()
        {
            return myCard.ToString();
        }
        #endregion


    }
}
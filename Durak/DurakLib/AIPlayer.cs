using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13CardLib;

namespace DurakGameLib
{
    class AIPlayer : CardsPlayed
    {
        #region CLASS MEMBERS




        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor for the AIPlayer object
        /// </summary>
        public AIPlayer()
        {

            aiplayhand = new Cards();   // The ia player cards as a hand


        }
        #endregion



        #region INSTANCE MEMBERS
        private Cards aiplayhand;
        private Card humanLastCard;
        private bool isAttacker;    // Is the   attacker
        private Suit superSuit;
        #endregion

        #region ACCESSORS & MUTATORS
        /// <summary>
        /// Getter & Setter for AIplayhand
        /// </summary>
        public Cards AIplayhand
        {
            get
            {
                return aiplayhand; // Returns the ai hand of cards
            }
            set
            {
                aiplayhand = value; // Sets the ai hand of cards
            }
        }

        /// <summary>
        /// Getter & Setter for   Isattacker 
        /// </summary>
        public bool IsAttacker
        {
            get
            {
                return isAttacker;
            }
            set
            {
                isAttacker = value;
            }
        }

        /// <summary>
        /// Getter & Setter for HumanLastCard 
        /// </summary>
        public Card HumanLastCard
        {
            get
            {
                return humanLastCard;
            }
            set
            {
                humanLastCard = value;
            }
        }

        public Suit SuperSuit
        {
            get
            {
                return superSuit;
            }
            set
            {
                superSuit = value;
            }
        }

        #endregion

        #region METHODS
        /// <summary>
        /// remove card from ai player's hand
        /// </summary>
        /// <param name="card"></param>
        public void AiPlayCard(Card card)
        {
            aiplayhand.Remove(card); // Removes the card played from the ai hand
        }

        /// <summary>
        /// Draw cards to the ai player's hand
        /// </summary>
        /// <param name="card"></param>
        public void DrawCards(Card card)
        {
            aiplayhand.Add(card); // Add each to the players hand           
        }

        /// <summary>
        /// basic logic of ai player
        /// </summary>
        public void BasicAILogic()
        {
            if (IsAttacker == true)
            {
                foreach (Card aicard in AIplayhand)
                {
                    if (aicard.Rank == Rank.Two)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Three)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Four)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Five)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Six)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Seven)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Eight)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Nine)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Ten)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Jack)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Queen)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.King)
                    {
                        AiPlayCard(aicard);
                    }
                    else if (aicard.Rank == Rank.Ace)
                    {
                        AiPlayCard(aicard);
                    }

                }
            }
            else
            {
                foreach (Card aicard in AIplayhand)
                {
                    if (humanLastCard >= aicard)
                    {
                        DrawCards(humanLastCard);
                    }

                    if (humanLastCard < aicard || humanLastCard.Suit == aicard.Suit)
                    {

                        AiPlayCard(aicard);

                    }

                    if (humanLastCard < aicard || aicard.Suit == superSuit)
                    {

                        AiPlayCard(aicard);

                    }

                }

            }

        }
        #endregion
    }
}

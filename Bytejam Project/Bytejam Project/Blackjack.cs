using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bytejam_Project
{
    public partial class Blackjack : Form
    {
        public Dictionary<string, int> CardValues = new Dictionary<string, int>();
        public Dictionary<string, Image> CardImages = new Dictionary<string, Image>();
        public List<string> CardDeck;
        public static string playName;

        public List<string> PlayerCards;
        public List<string> DealerCards;

        private bool running = false;
        private Random random = new Random();

        public Blackjack()
        {
            InitializeComponent();
        }

        public int AceValue( int handValue )
        {
            if ( handValue + 11 > 21 )
                return 1;
            else
                return 11;
        }

        public void DealCards()
        {
            // Reset scores using toString method because it is impossible to convert integers to strings.
            playerScore.Text = 0.ToString();
            dealerScore.Text = 0.ToString();

            // Reset deck.
            CardDeck = new List<string>();
            foreach ( string key in CardValues.Keys )
            {
                CardDeck.Add( key );
            }

            // Reset cards.
            PlayerCards = new List<string>();
            DealerCards = new List<string>();

            // Reset card images.
            HideCards();

            // Draw one card for each player.
            PlayerDraw();
            DealerDraw();

            // Start game.
            running = true;
        }

        public void HideCards()
        {
            // Add card back images.
            playerCard1.Image = CardImages["Back"];
            playerCard1.Tag = "Back";
            playerCard2.Image = CardImages["Back"];
            playerCard2.Tag = "Back";
            playerCard3.Image = CardImages["Back"];
            playerCard3.Tag = "Back";
            playerCard4.Image = CardImages["Back"];
            playerCard4.Tag = "Back";
            playerCard5.Image = CardImages["Back"];
            playerCard5.Tag = "Back";
            dealerCard1.Image = CardImages["Back"];
            dealerCard1.Tag = "Back";
            dealerCard2.Image = CardImages["Back"];
            dealerCard2.Tag = "Back";
            dealerCard3.Image = CardImages["Back"];
            dealerCard3.Tag = "Back";
            dealerCard4.Image = CardImages["Back"];
            dealerCard4.Tag = "Back";
            dealerCard5.Image = CardImages["Back"];
            dealerCard5.Tag = "Back";
        }

        public void PlayerLose()
        {
            MessageBox.Show( "You have busted, better luck next time.", "Loss.", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            EndGame();
        }

        public void DealerLose()
        {
            MessageBox.Show( "Dealer has busted. You win $250!", "Win!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            MainMenu.UpdateScore( lblPlayerScore, 250 );
            EndGame();
        }

        public void EverybodyLose()
        {
            MainMenu.UpdateScore( lblPlayerScore, 50 );
            MessageBox.Show( "You've both busted, you receive $50.", "Tie?", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            EndGame();
        }

        public void EndGame()
        {
            running = false;
            //check to see if players $$ is negative
            if ( MainMenu.Players.ContainsKey( MainMenu.ActivePlayer ) )
                NegativeCheck();
        }

        public void PlayerDraw()
        {
            int nextCard;
            string card;
            Image cardImage;
            int nextScore;
            nextCard = random.Next( 0, CardDeck.Count);
            card = CardDeck[nextCard];
            PlayerCards.Add( card );
            CardDeck.RemoveAt( nextCard );
            cardImage = CardImages[card];
            nextScore = CardValues[card];
            if ( nextScore == 0 )
                nextScore = nextScore = AceValue( int.Parse( playerScore.Text ) );
            if ( (string)playerCard1.Tag == "Back" )
            {
                playerCard1.Image = cardImage;
                playerCard1.Tag = card;
            }
            else if ( (string)playerCard2.Tag == "Back" )
            {
                playerCard2.Image = cardImage;
                playerCard2.Tag = card;
            }
            else if ( (string)playerCard3.Tag == "Back" )
            {
                playerCard3.Image = cardImage;
                playerCard3.Tag = card;
            }
            else if ( (string)playerCard4.Tag == "Back" )
            {
                playerCard4.Image = cardImage;
                playerCard4.Tag = card;
            }
            else if ( (string)playerCard5.Tag == "Back" )
            {
                playerCard5.Image = cardImage;
                playerCard5.Tag = card;
            }
            playerScore.Text = (int.Parse( playerScore.Text ) + nextScore).ToString();
        }

        public void DealerDraw()
        {
            int nextCard;
            string card;
            Image cardImage;
            int nextScore;

            nextCard = random.Next( 0, CardDeck.Count );
            card = CardDeck[nextCard];
            DealerCards.Add( card );
            CardDeck.RemoveAt( nextCard );
            cardImage = CardImages[card];
            nextScore = CardValues[card];
            if ( nextScore == 0 )
                nextScore = AceValue( int.Parse( dealerScore.Text ) );
            if ( (string)dealerCard1.Tag == "Back" )
            {
                dealerCard1.Image = cardImage;
                dealerCard1.Tag = card;
            }
            else if ( (string)dealerCard2.Tag == "Back" )
            {
                dealerCard2.Image = cardImage;
                dealerCard2.Tag = card;
            }
            else if ( (string)dealerCard3.Tag == "Back" )
            {
                dealerCard3.Image = cardImage;
                dealerCard3.Tag = card;
            }
            else if ( (string)dealerCard4.Tag == "Back" )
            {
                dealerCard4.Image = cardImage;
                dealerCard4.Tag = card;
            }
            else if ( (string)dealerCard5.Tag == "Back" )
            {
                dealerCard5.Image = cardImage;
                dealerCard5.Tag = card;
            }
            dealerScore.Text = (int.Parse( dealerScore.Text ) + nextScore).ToString();
        }

        private void Blackjack_Load( object sender, EventArgs e )
        {
            NameEntry form = new NameEntry();
            form.Shown += delegate { this.Hide(); };
            form.FormClosed += delegate
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;

                string[] imageFiles = Directory.GetFiles( Directory.GetCurrentDirectory() + "/images/" );
                for ( int x = 0; x < imageFiles.Length; x++ )
                {
                    string[] splitDirectory = imageFiles[x].Split( '/' );
                    string actualName = splitDirectory[splitDirectory.Length - 1].Split( '.' )[0];
                    CardImages.Add( actualName, Image.FromFile( imageFiles[x] ) );
                }

                CardValues.Add( "0Club", 10 );
                CardValues.Add( "0Diamond", 10 );
                CardValues.Add( "0Heart", 10 );
                CardValues.Add( "0Spade", 10 );

                CardValues.Add( "2Club", 2 );
                CardValues.Add( "2Diamond", 2 );
                CardValues.Add( "2Heart", 2 );
                CardValues.Add( "2Spade", 2 );

                CardValues.Add( "3Club", 3 );
                CardValues.Add( "3Diamond", 3 );
                CardValues.Add( "3Heart", 3 );
                CardValues.Add( "3Spade", 3 );

                CardValues.Add( "4Club", 4 );
                CardValues.Add( "4Diamond", 4 );
                CardValues.Add( "4Heart", 4 );
                CardValues.Add( "4Spade", 4 );

                CardValues.Add( "5Club", 5 );
                CardValues.Add( "5Diamond", 5 );
                CardValues.Add( "5Heart", 5 );
                CardValues.Add( "5Spade", 5 );

                CardValues.Add( "6Club", 6 );
                CardValues.Add( "6Diamond", 6 );
                CardValues.Add( "6Heart", 6 );
                CardValues.Add( "6Spade", 6 );

                CardValues.Add( "7Club", 7 );
                CardValues.Add( "7Diamond", 7 );
                CardValues.Add( "7Heart", 7 );
                CardValues.Add( "7Spade", 7 );

                CardValues.Add( "8Club", 8 );
                CardValues.Add( "8Diamond", 8 );
                CardValues.Add( "8Heart", 8 );
                CardValues.Add( "8Spade", 8 );

                CardValues.Add( "9Club", 9 );
                CardValues.Add( "9Diamond", 9 );
                CardValues.Add( "9Heart", 9 );
                CardValues.Add( "9Spade", 9 );

                CardValues.Add( "JClub", 10 );
                CardValues.Add( "JDiamond", 10 );
                CardValues.Add( "JHeart", 10 );
                CardValues.Add( "JSpade", 10 );

                CardValues.Add( "QClub", 10 );
                CardValues.Add( "QDiamond", 10 );
                CardValues.Add( "QHeart", 10 );
                CardValues.Add( "QSpade", 10 );

                CardValues.Add( "KClub", 10 );
                CardValues.Add( "KDiamond", 10 );
                CardValues.Add( "KHeart", 10 );
                CardValues.Add( "KSpade", 10 );

                Show();

                labelPlayerName.Text = MainMenu.ActivePlayer + "'s Game!";
                MainMenu.UpdateScore( lblPlayerScore );

                //check to see if players $$ is negative
                if ( MainMenu.Players.ContainsKey( MainMenu.ActivePlayer ) )
                    NegativeCheck();
            };
            form.Show();            
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void btnDeal_Click( object sender, EventArgs e )
        {
            if ( running )
                return;
            DealCards();
            MainMenu.UpdateScore( lblPlayerScore , - 100 );
        }

        private void btnHit_Click( object sender, EventArgs e )
        {
            if ( !running )
                return;
            if ( PlayerCards.Count < 5 )
            {
                PlayerDraw();
            }

            if ( int.Parse( playerScore.Text ) > 21 )
            {
                PlayerLose();
                return;
            }

            if ( DealerCards.Count < 5 && int.Parse( dealerScore.Text ) <= int.Parse( playerScore.Text ) )
            {
                DealerDraw();
            }

            if ( int.Parse( dealerScore.Text ) > 21 )
            {
                DealerLose();
                return;
            }

            if ( PlayerCards.Count == 5 && DealerCards.Count == 5 )
            {
                if ( int.Parse( playerScore.Text ) > int.Parse( dealerScore.Text ) )
                    DealerLose();
                else if ( int.Parse( playerScore.Text ) < int.Parse( dealerScore.Text ) )
                    PlayerLose();
                else
                    EverybodyLose();
                return;
            }
        }

        private void btnPass_Click( object sender, EventArgs e )
        {
            if ( !running )
                return;

            if ( DealerCards.Count < 5 && int.Parse( dealerScore.Text ) <= int.Parse( playerScore.Text ) )
            {
                DealerDraw();
            }

            if ( int.Parse( dealerScore.Text ) > 21 )
            {
                DealerLose();
                return;
            }

            if ( PlayerCards.Count == 5 && DealerCards.Count == 5 )
            {
                if ( int.Parse( playerScore.Text ) > int.Parse( dealerScore.Text ) )
                    DealerLose();
                else if ( int.Parse( playerScore.Text ) < int.Parse( dealerScore.Text ) )
                    PlayerLose();
                else
                    EverybodyLose();
                return;
            }
        }

        public void NegativeCheck()
        {
            if ( MainMenu.Players[MainMenu.ActivePlayer] <= 0 )
            {
                MessageBox.Show( "You have ran out of money! Better luck next time!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                Close();
            }
        }
    }
}

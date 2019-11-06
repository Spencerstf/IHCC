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

            CardDeck = new List<string>();
            foreach ( string key in CardValues.Keys )
            {
                CardDeck.Add( key );
            }

            PlayerCards = new List<string>();
            DealerCards = new List<string>();

            playerScore.Text = 0.ToString();
        }

        public void PlayerLose()
        {

        }

        private void Blackjack_Load( object sender, EventArgs e )
        {
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

            NameEntry form = new NameEntry();
            form.Activated += delegate { this.Hide(); };
            form.FormClosed += delegate { this.Show(); };
            form.Show();

            labelPlayerName.Text = playName + "'s Game! ";

            DealCards();
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void btnDeal_Click( object sender, EventArgs e )
        {
            DealCards();
        }

        private void btnHit_Click( object sender, EventArgs e )
        {
            Random random = new Random();
            int nextCard = random.Next( 0, CardDeck.Count - 1 );
            string card = CardDeck[nextCard];
            PlayerCards.Add( card );
            CardDeck.RemoveAt( nextCard );
            Image cardImage = CardImages[card];
            int nextScore = CardValues[card];
            if (nextScore == 0)
                nextScore = nextScore = AceValue(int.Parse(playerScore.Text));
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
            if (int.Parse(playerScore.Text) > 21)
                PlayerLose();
        }
    }
}

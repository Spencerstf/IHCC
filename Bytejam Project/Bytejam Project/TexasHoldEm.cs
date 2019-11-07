﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bytejam_Project
{
    public partial class TexasHoldEm : Form
    {
        public Dictionary<string, Image> CardImages = new Dictionary<string, Image>();
        public List<string> CardDeck;
        public static string playName;

        public List<string> PlayerCards;
        public List<string> DealerCards;

        private bool running = false;
        private Random random = new Random();

        public TexasHoldEm()
        {
            InitializeComponent();
        }

        private void TexasHoldEm_Load( object sender, EventArgs e )
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

                HideCards();

                Show();

                lblPlayerName.Text = MainMenu.ActivePlayer + "'s Game!";
                MainMenu.UpdateScore( lblPlayerScore );
            };
            form.Show();

        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void BtnDeal_Click( object sender, EventArgs e )
        {
            if ( running )
                return;

            DealCards();
            MainMenu.UpdateScore( lblPlayerScore, -200 );

            NegativeCheck();

            running = true;
        }

        private void BtnCall_Click( object sender, EventArgs e )
        {
            if ( !running || DealerCards.Count == 5 )
                return;

            DealerDraw();
            MainMenu.UpdateScore( lblPlayerScore, -100 );            

            if ( DealerCards.Count == 5 )
                CheckHand();

            NegativeCheck();
        }

        private void BtnFold_Click( object sender, EventArgs e )
        {
            if ( !running )
                return;

            Lose();
        }

        private void DealCards()
        {
            // Reset deck.
            CardDeck = new List<string>();
            foreach ( string key in CardImages.Keys )
            {
                if ( key != "Back" )
                    CardDeck.Add( key );
            }

            // Reset cards.
            PlayerCards = new List<string>();
            DealerCards = new List<string>();
            HideCards();

            // Draw two cards for the player.
            PlayerDraw();
            PlayerDraw();

            // Draw three cards for the dealer.
            DealerDraw();
            DealerDraw();
            DealerDraw();
        }

        public void PlayerDraw()
        {
            int nextCard;
            string card;
            Image cardImage;
            nextCard = random.Next( 0, CardDeck.Count - 1 );
            card = CardDeck[nextCard];
            PlayerCards.Add( card );
            CardDeck.RemoveAt( nextCard );
            cardImage = CardImages[card];
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
        }

        public void DealerDraw()
        {
            int nextCard;
            string card;
            Image cardImage;

            nextCard = random.Next( 0, CardDeck.Count - 1 );
            card = CardDeck[nextCard];
            DealerCards.Add( card );
            CardDeck.RemoveAt( nextCard );
            cardImage = CardImages[card];
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
        }

        public void HideCards()
        {
            // Add card back images.
            playerCard1.Image = CardImages["Back"];
            playerCard1.Tag = "Back";
            playerCard2.Image = CardImages["Back"];
            playerCard2.Tag = "Back";
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

        public void Lose()
        {
            MessageBox.Show( "You lose, better luck next time.", "Loss.", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            EndGame();
        }

        public void EndGame()
        {
            running = false;
        }

        public void CheckHand()
        {
            //CheckRoyalFlush();
            //CheckStraightFlush();
            if ( running )
                CheckFourOfAKind();
            //CheckFullHouse();
            if ( running )
                CheckFlush();
            if ( running )
                CheckStraight();
            if ( running )
                CheckThreeOfAKind();
            //CheckTwoPair();
            if ( running )
                CheckOnePair();
            if ( running )
                HighestCard();

            // If still running, lose.
            if ( running )
                Lose();
        }

        public void CheckFourOfAKind()
        {
            // See if four of the same card value exist in game.
            foreach ( string card in PlayerCards )
            {
                char valueToMatch = card[0];
                List<string> matchedCards = new List<string>();
                matchedCards.Add( card );
                foreach ( string otherCard in PlayerCards )
                {
                    if ( !matchedCards.Contains( otherCard ) && otherCard[0] == valueToMatch )
                        matchedCards.Add( card );
                }
                foreach ( string otherCard in DealerCards )
                {
                    if ( !matchedCards.Contains( otherCard ) && otherCard[0] == valueToMatch )
                        matchedCards.Add( card );
                }
                if ( matchedCards.Count == 4 )
                {
                    string valueLiteral = "";

                    switch ( valueToMatch )
                    {
                        case 'A':
                            valueLiteral += "Ace";
                            break;
                        case '1':
                            valueLiteral += "One";
                            break;
                        case '2':
                            valueLiteral += "Two";
                            break;
                        case '3':
                            valueLiteral += "Three";
                            break;
                        case '4':
                            valueLiteral += "Four";
                            break;
                        case '5':
                            valueLiteral += "Five";
                            break;
                        case '6':
                            valueLiteral += "Six";
                            break;
                        case '7':
                            valueLiteral += "Seven";
                            break;
                        case '8':
                            valueLiteral += "Eight";
                            break;
                        case '9':
                            valueLiteral += "Nine";
                            break;
                        case '0':
                            valueLiteral += "Ten";
                            break;
                        case 'J':
                            valueLiteral += "Jack";
                            break;
                        case 'Q':
                            valueLiteral += "Queen";
                            break;
                        case 'K':
                            valueLiteral += "King";
                            break;
                        default:
                            valueLiteral += "Unknown";
                            break;
                    }
                    MessageBox.Show( "You got four " + valueLiteral + "s, earning yourself $800!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 800 );
                    running = false;
                    return;
                }
            }
            foreach ( string card in DealerCards )
            {
                char valueToMatch = card[0];
                List<string> matchedCards = new List<string>();
                matchedCards.Add( card );
                foreach ( string otherCard in PlayerCards )
                {
                    if ( !matchedCards.Contains( otherCard ) && otherCard[0] == valueToMatch )
                        matchedCards.Add( card );
                }
                foreach ( string otherCard in DealerCards )
                {
                    if ( !matchedCards.Contains( otherCard ) && otherCard[0] == valueToMatch )
                        matchedCards.Add( card );
                }
                if ( matchedCards.Count == 4 )
                {
                    string valueLiteral = "";

                    switch ( valueToMatch )
                    {
                        case 'A':
                            valueLiteral += "Ace";
                            break;
                        case '1':
                            valueLiteral += "One";
                            break;
                        case '2':
                            valueLiteral += "Two";
                            break;
                        case '3':
                            valueLiteral += "Three";
                            break;
                        case '4':
                            valueLiteral += "Four";
                            break;
                        case '5':
                            valueLiteral += "Five";
                            break;
                        case '6':
                            valueLiteral += "Six";
                            break;
                        case '7':
                            valueLiteral += "Seven";
                            break;
                        case '8':
                            valueLiteral += "Eight";
                            break;
                        case '9':
                            valueLiteral += "Nine";
                            break;
                        case '0':
                            valueLiteral += "Ten";
                            break;
                        case 'J':
                            valueLiteral += "Jack";
                            break;
                        case 'Q':
                            valueLiteral += "Queen";
                            break;
                        case 'K':
                            valueLiteral += "King";
                            break;
                        default:
                            valueLiteral += "Unknown";
                            break;
                    }
                    MessageBox.Show( "You got four " + valueLiteral + "s, earning yourself $800!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 800 );
                    running = false;
                    return;
                }
            }
        }

        public void CheckFlush()
        {
            // See if there are at least 5 cards of the same suit.
            foreach ( string card in PlayerCards )
            {
                string suit = card.Substring( 1 );
                List<string> suitedCards = new List<string>();
                suitedCards.Add( card );
                int attempts = 10;
                while ( attempts > 0 )
                {
                    // Process other player card.
                    foreach ( string otherCard in PlayerCards )
                    {
                        if ( suitedCards.Contains( otherCard ) )
                            continue;

                        string otherSuit = otherCard.Substring( 1 );

                        if ( suit == otherSuit )
                            suitedCards.Add( otherCard );
                    }

                    if ( suitedCards.Count == 5 )
                        break;

                    // Process dealer cards.
                    foreach ( string otherCard in DealerCards )
                    {
                        if ( suitedCards.Contains( otherCard ) )
                            continue;

                        string otherSuit = otherCard.Substring( 1 );

                        if ( suit == otherSuit )
                        {
                            suitedCards.Add( otherCard );
                            break;
                        }
                    }

                    if ( suitedCards.Count == 5 )
                        break;

                    attempts--;
                }
                if ( suitedCards.Count >= 5 )
                {
                    MessageBox.Show( "You got a flush, earning yourself $600!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 600 );
                    running = false;
                    return;
                }
            }
            foreach ( string card in DealerCards )
            {
                string suit = card.Substring( 1 );
                List<string> suitedCards = new List<string>();
                suitedCards.Add( card );
                int attempts = 10;
                while ( attempts > 0 )
                {
                    // Process other player card.
                    foreach ( string otherCard in PlayerCards )
                    {
                        if ( suitedCards.Contains( otherCard ) )
                            continue;

                        string otherSuit = otherCard.Substring( 1 );

                        if ( suit == otherSuit )
                            suitedCards.Add( otherCard );
                    }

                    if ( suitedCards.Count == 5 )
                        break;

                    // Process dealer cards.
                    foreach ( string otherCard in DealerCards )
                    {
                        if ( suitedCards.Contains( otherCard ) )
                            continue;

                        string otherSuit = otherCard.Substring( 1 );

                        if ( suit == otherSuit )
                        {
                            suitedCards.Add( otherCard );
                            break;
                        }
                    }

                    if ( suitedCards.Count == 5 )
                        break;

                    attempts--;
                }
                if ( suitedCards.Count >= 5 )
                {
                    MessageBox.Show( "You got a flush, earning yourself $600!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 600 );
                    running = false;
                    return;
                }
            }
        }

        public void CheckStraight()
        {
            // See if there are 5 cards in numeric alignment.
            foreach ( string card in PlayerCards )
            {
                int value = -2;
                char numericChar = card[0];
                if ( char.IsNumber( numericChar ) && numericChar != '0' )
                    value = (int)char.GetNumericValue( numericChar );
                else
                    switch ( card[0] )
                    {
                        case 'A':
                            value = 1;
                            break;
                        case 'J':
                            value = 11;
                            break;
                        case 'Q':
                            value = 12;
                            break;
                        case 'K':
                            value = 13;
                            break;
                        default:
                            break;
                    }
                // Keep attempting to build a straight until we're done.
                List<string> straightCards = new List<string>();
                List<int> straightValues = new List<int>();
                straightCards.Add( card );
                straightValues.Add( value );
                int attempts = 10;
                while ( attempts > 0 )
                {
                    // Process other player card.
                    foreach ( string otherCard in PlayerCards )
                    {
                        if ( straightCards.Contains( otherCard ) )
                            continue;

                        int otherValue = -2;
                        numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            otherValue = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    otherValue = 1;
                                    break;
                                case 'J':
                                    otherValue = 11;
                                    break;
                                case 'Q':
                                    otherValue = 12;
                                    break;
                                case 'K':
                                    otherValue = 13;
                                    break;
                                default:
                                    break;
                            }

                        if ( otherValue - straightValues.Min() == -1 || otherValue - straightValues.Max() == 1 )
                        {
                            straightCards.Add( otherCard );
                            straightValues.Add( otherValue );
                        }
                    }

                    if ( straightValues.Count == 5 )
                        break;

                    // Process dealer cards.
                    foreach ( string otherCard in DealerCards )
                    {
                        if ( straightCards.Contains( otherCard ) )
                            continue;

                        int otherValue = -2;
                        numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            otherValue = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    otherValue = 1;
                                    break;
                                case 'J':
                                    otherValue = 11;
                                    break;
                                case 'Q':
                                    otherValue = 12;
                                    break;
                                case 'K':
                                    otherValue = 13;
                                    break;
                                default:
                                    break;
                            }

                        if ( otherValue - straightValues.Min() == -1 || otherValue - straightValues.Max() == 1 )
                        {
                            straightCards.Add( otherCard );
                            straightValues.Add( otherValue );
                            break;
                        }
                    }

                    if ( straightValues.Count == 5 )
                        break;

                    attempts--;
                }

                if ( straightValues.Count >= 5 )
                {
                    MessageBox.Show( "You got a straight, earning yourself $500!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 500 );
                    running = false;
                    return;
                }
            }
            foreach ( string card in DealerCards )
            {
                int value = -2;
                char numericChar = card[0];
                if ( char.IsNumber( numericChar ) && numericChar != '0' )
                    value = (int)char.GetNumericValue( numericChar );
                else
                    switch ( card[0] )
                    {
                        case 'A':
                            value = 1;
                            break;
                        case 'J':
                            value = 11;
                            break;
                        case 'Q':
                            value = 12;
                            break;
                        case 'K':
                            value = 13;
                            break;
                        default:
                            break;
                    }
                // Keep attempting to build a straight until we're done.
                List<string> straightCards = new List<string>();
                List<int> straightValues = new List<int>();
                straightCards.Add( card );
                straightValues.Add( value );
                int attempts = 10;
                while ( attempts > 0 )
                {
                    // Process other player card.
                    foreach ( string otherCard in PlayerCards )
                    {
                        if ( straightCards.Contains( otherCard ) )
                            continue;

                        int otherValue = -2;
                        numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            otherValue = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    otherValue = 1;
                                    break;
                                case 'J':
                                    otherValue = 11;
                                    break;
                                case 'Q':
                                    otherValue = 12;
                                    break;
                                case 'K':
                                    otherValue = 13;
                                    break;
                                default:
                                    break;
                            }

                        if ( otherValue - straightValues.Min() == -1 || otherValue - straightValues.Max() == 1 )
                        {
                            straightCards.Add( otherCard );
                            straightValues.Add( otherValue );
                        }
                    }

                    if ( straightValues.Count == 5 )
                        break;

                    // Process dealer cards.
                    foreach ( string otherCard in DealerCards )
                    {
                        if ( straightCards.Contains( otherCard ) )
                            continue;

                        int otherValue = -2;
                        numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            otherValue = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    otherValue = 1;
                                    break;
                                case 'J':
                                    otherValue = 11;
                                    break;
                                case 'Q':
                                    otherValue = 12;
                                    break;
                                case 'K':
                                    otherValue = 13;
                                    break;
                                default:
                                    break;
                            }

                        if ( otherValue - straightValues.Min() == -1 || otherValue - straightValues.Max() == 1 )
                        {
                            straightCards.Add( otherCard );
                            straightValues.Add( otherValue );
                            break;
                        }
                    }

                    if ( straightValues.Count == 5 )
                        break;

                    attempts--;
                }

                if ( straightValues.Count >= 5 )
                {
                    MessageBox.Show( "You got a straight, earning yourself $500!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    MainMenu.UpdateScore( lblPlayerScore, 500 );
                    running = false;
                    return;
                }
            }
        }

        public void CheckThreeOfAKind()
        {

        }

        public void CheckOnePair()
        {
            // Check for two cards with a matching value.
            int foundPairValue = 0;
            foreach ( string card in PlayerCards )
            {
                foreach ( string otherCard in PlayerCards )
                    if ( otherCard != card && otherCard[0] == card[0] )
                    {
                        int value = -2;
                        char numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            value = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    value = 1;
                                    break;
                                case 'J':
                                    value = 11;
                                    break;
                                case 'Q':
                                    value = 12;
                                    break;
                                case 'K':
                                    value = 13;
                                    break;
                                default:
                                    break;
                            }

                        foundPairValue = Math.Max( foundPairValue, value );
                    }
                foreach ( string otherCard in DealerCards )
                    if ( otherCard != card && otherCard[0] == card[0] )
                    {
                        int value = -2;
                        char numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            value = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    value = 1;
                                    break;
                                case 'J':
                                    value = 11;
                                    break;
                                case 'Q':
                                    value = 12;
                                    break;
                                case 'K':
                                    value = 13;
                                    break;
                                default:
                                    break;
                            }

                        foundPairValue = Math.Max( foundPairValue, value );
                    }

            }
            foreach ( string card in DealerCards )
            {
                foreach ( string otherCard in PlayerCards )
                    if ( otherCard != card && otherCard[0] == card[0] )
                    {
                        int value = -2;
                        char numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            value = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    value = 1;
                                    break;
                                case 'J':
                                    value = 11;
                                    break;
                                case 'Q':
                                    value = 12;
                                    break;
                                case 'K':
                                    value = 13;
                                    break;
                                default:
                                    break;
                            }

                        foundPairValue = Math.Max( foundPairValue, value );
                    }
                foreach ( string otherCard in DealerCards )
                    if ( otherCard != card && otherCard[0] == card[0] )
                    {
                        int value = -2;
                        char numericChar = otherCard[0];
                        if ( char.IsNumber( numericChar ) && numericChar != '0' )
                            value = (int)char.GetNumericValue( numericChar );
                        else
                            switch ( otherCard[0] )
                            {
                                case 'A':
                                    value = 1;
                                    break;
                                case 'J':
                                    value = 11;
                                    break;
                                case 'Q':
                                    value = 12;
                                    break;
                                case 'K':
                                    value = 13;
                                    break;
                                default:
                                    break;
                            }

                        foundPairValue = Math.Max( foundPairValue, value );
                    }

            }
            if ( foundPairValue > 0 )
            {
                string cardLiteral = "";

                switch ( foundPairValue )
                {
                    case 1:
                        cardLiteral += "Ace";
                        break;
                    case 2:
                        cardLiteral += "Two";
                        break;
                    case 3:
                        cardLiteral += "Three";
                        break;
                    case 4:
                        cardLiteral += "Four";
                        break;
                    case 5:
                        cardLiteral += "Five";
                        break;
                    case 6:
                        cardLiteral += "Six";
                        break;
                    case 7:
                        cardLiteral += "Seven";
                        break;
                    case 8:
                        cardLiteral += "Eight";
                        break;
                    case 9:
                        cardLiteral += "Nine";
                        break;
                    case 10:
                        cardLiteral += "Ten";
                        break;
                    case 11:
                        cardLiteral += "Jack";
                        break;
                    case 12:
                        cardLiteral += "Queen";
                        break;
                    case 13:
                        cardLiteral += "King";
                        break;
                    default:
                        cardLiteral += "Unknown";
                        break;
                }

                MessageBox.Show( "You have a pair of " + cardLiteral + "s, earning yourself $200!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                MainMenu.UpdateScore( lblPlayerScore, 200 );
                running = false;
                return;
            }
        }

        public void HighestCard()
        {
            int highCardValue = 0;
            string highCard = "";
            foreach ( string card in PlayerCards )
            {
                int value = -2;
                char numericChar = card[0];
                if ( char.IsNumber( numericChar ) && numericChar != '0' )
                    value = (int)char.GetNumericValue( numericChar );
                else
                    switch ( card[0] )
                    {
                        case 'A':
                            value = 1;
                            break;
                        case 'J':
                        case 'Q':
                        case 'K':
                        case '0':
                            value = 10;
                            break;
                        default:
                            break;
                    }

                if ( value > highCardValue )
                {
                    highCardValue = value;
                    highCard = card;
                }
            }
            foreach ( string card in DealerCards )
            {
                int value = -2;
                char numericChar = card[0];
                if ( char.IsNumber( numericChar ) && numericChar != '0' )
                    value = (int)char.GetNumericValue( numericChar );
                else
                    switch ( card[0] )
                    {
                        case 'A':
                            value = 1;
                            break;
                        case 'J':
                        case 'Q':
                        case 'K':
                        case '0':
                            value = 10;
                            break;
                        default:
                            break;
                    }

                if ( value > highCardValue )
                {
                    highCardValue = value;
                    highCard = card;
                }
            }

            string cardLiteral = "";

            switch ( highCard[0] )
            {
                case 'A':
                    cardLiteral += "Ace";
                    break;
                case '1':
                    cardLiteral += "One";
                    break;
                case '2':
                    cardLiteral += "Two";
                    break;
                case '3':
                    cardLiteral += "Three";
                    break;
                case '4':
                    cardLiteral += "Four";
                    break;
                case '5':
                    cardLiteral += "Five";
                    break;
                case '6':
                    cardLiteral += "Six";
                    break;
                case '7':
                    cardLiteral += "Seven";
                    break;
                case '8':
                    cardLiteral += "Eight";
                    break;
                case '9':
                    cardLiteral += "Nine";
                    break;
                case '0':
                    cardLiteral += "Ten";
                    break;
                case 'J':
                    cardLiteral += "Jack";
                    break;
                case 'Q':
                    cardLiteral += "Queen";
                    break;
                case 'K':
                    cardLiteral += "King";
                    break;
                default:
                    cardLiteral += "Unknown";
                    break;
            }

            cardLiteral += " of " + highCard.Substring( 1 ) + "s";

            string grammer = "a";
            if ( cardLiteral[0].ToString().ToLower() == "a"
                || cardLiteral[0].ToString().ToLower() == "e"
                || cardLiteral[0].ToString().ToLower() == "i"
                || cardLiteral[0].ToString().ToLower() == "o"
                || cardLiteral[0].ToString().ToLower() == "u" )
                grammer = "an";

            MessageBox.Show( "You have " + grammer + " " + cardLiteral + ", earning yourself $" + (highCardValue * 10) + ".", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            MainMenu.UpdateScore( lblPlayerScore, highCardValue * 10 );
            running = false;
        }

        public void NegativeCheck()
        {
            if (MainMenu.Players[MainMenu.ActivePlayer] < 0)
            {
                MessageBox.Show("You have ran out of money! Better luck next time!", "Boy howdy!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

    }

}

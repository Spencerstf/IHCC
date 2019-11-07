using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Bytejam_Project
{
    public partial class TexasHoldEm : Form
    {
        public Dictionary<string, Image> CardImages = new Dictionary<string, Image>();
        public List<string> CardDeck;
        public static string playName;

        public List<string> PlayerCards;
        public List<string> DealerCards;
        public TexasHoldEm()
        {
            InitializeComponent();
        }

        private void TexasHoldEm_Load(object sender, EventArgs e)
        {
            NameEntry form = new NameEntry();
            form.Shown += delegate { this.Hide(); };
            form.FormClosed += delegate
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;

                string[] imageFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "/images/");
                for (int x = 0; x < imageFiles.Length; x++)
                {
                    string[] splitDirectory = imageFiles[x].Split('/');
                    string actualName = splitDirectory[splitDirectory.Length - 1].Split('.')[0];
                    CardImages.Add(actualName, Image.FromFile(imageFiles[x]));
                }

                DealCards();

                Show();

                labelPlayerName.Text = MainMenu.ActivePlayer + "'s Game!";

            };
            form.Show();

        }

        public void DealCards()
        {


            //Reset cards 
            PlayerCards = new List<string>();
            DealerCards = new List<string>();

            //Add card back images
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

            //reset whole game 

            //player two cards and dealer three cards


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PlayerLose()
        {
            MessageBox.Show("Dealer wins.", "Bye bye.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DealCards();
        }

        public void DealerLose()
        {
            MessageBox.Show(MainMenu.ActivePlayer + " wins!", "Bye bye.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DealCards();
        }

        public void EverybodyLose()
        {
            MessageBox.Show("Tie!.", "Bye bye.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DealCards();
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {
            DealCards();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int nextCard;
            //string card;
            //Image cardImage;
            //
            //if ((string)playerCard1.Tag == "Back")
            //{
            //    playerCard1.Image = cardImage;
            //    playerCard1.Tag = card;
            //}
            //else if ((string)playerCard2.Tag == "Back")
            //{
            //    playerCard2.Image = cardImage;
            //    playerCard2.Tag = card;
            //}


            //200 to deal in and 100 to call 
            //get next dealer card 
        }

        private void BtnFold_Click(object sender, EventArgs e)
        {
            //quit
            MessageBox.Show("You fold. ", "Bye bye", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DealCards();
        }


    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytejam_Project
{
    public partial class MainMenu : Form
    {
        //dictionary thats a string int for name and score 
        public static Dictionary<string, int> Players = new Dictionary<string, int>();
        public static string ActivePlayer = "";

        public System.Media.SoundPlayer howdy = new System.Media.SoundPlayer( "songs/howdy.wav" );
        System.Media.SoundPlayer song = new System.Media.SoundPlayer( "songs/main.wav" );

        public static void UpdateScore( Label scoreDisplay, int change )
        {
            MainMenu.Players[MainMenu.ActivePlayer] += change;
            UpdateScore( scoreDisplay );
        }

        public static void UpdateScore(Label scoreDisplay)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture( "en-US" );
            culture.NumberFormat.CurrencyNegativePattern = 1;
            String str = String.Format( culture, "{0:C}", MainMenu.Players[MainMenu.ActivePlayer] );
            scoreDisplay.Text = str;
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnBlackJack_Click( object sender, EventArgs e )
        {
            Blackjack form = new Blackjack();
            form.Load += delegate { this.Hide(); };
            form.FormClosed += delegate { this.Show(); };
            form.Show();
        }

        private void btnTexas_Click( object sender, EventArgs e )
        {
            TexasHoldEm form = new TexasHoldEm();
            form.Load += delegate { this.Hide(); };
            form.FormClosed += delegate { this.Show(); };
            form.Show();
        }

        private void Exit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void MainMenu_Activated( object sender, EventArgs e )
        {
            song.Stop();

            howdy.Play();
            Thread.Sleep( 2000 );
            howdy.Stop();

            song.PlayLooping();
        }
    }
}

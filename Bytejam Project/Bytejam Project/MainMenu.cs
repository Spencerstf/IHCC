using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytejam_Project
{
    public partial class MainMenu : Form
    {
        //dictionary thats a string int for name and score 
        public Dictionary<string, int> Players = new Dictionary<string, int>();
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load( object sender, EventArgs e )
        {

        }

        private void btnBlackJack_Click( object sender, EventArgs e )
        {
            Blackjack form = new Blackjack();
            form.Activated += delegate { this.Hide(); };
            form.FormClosed += delegate { this.Show(); };
            form.Show();
        }

        private void btnTexas_Click( object sender, EventArgs e )
        {
            TexasHoldEm form = new TexasHoldEm();
            form.Activated += delegate { this.Hide(); };
            form.FormClosed += delegate { this.Show(); };
            form.Show();
        }

        private void Exit_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}

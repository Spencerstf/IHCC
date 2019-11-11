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
    public partial class NameEntry : Form
    {
        public NameEntry()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void NameEntry_FormClosing( object sender, FormClosingEventArgs e )
        {
            AddPlayer();
        }

        private void AddPlayer()
        {
            if ( !MainMenu.Players.Keys.Contains( txtName.Text ) )
            {
                MainMenu.Players.Add( txtName.Text, 2500 );
                MainMenu.ActivePlayer = txtName.Text;
            }
            else
                MainMenu.ActivePlayer = txtName.Text;
        }

        private void NameEntry_Load( object sender, EventArgs e )
        {
            txtName.Text = MainMenu.ActivePlayer;
        }

        private void txtName_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == '\r' )
                Close();
        }
    }
}

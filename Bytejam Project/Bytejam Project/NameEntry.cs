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
            if ( !MainMenu.Players.Keys.Contains( txtName.Text ) )
            {
                MainMenu.Players.Add( txtName.Text, 1000 );
                MainMenu.ActivePlayer = txtName.Text;
            }
            else
                MainMenu.ActivePlayer = txtName.Text;
            Close();
        }
    }
}

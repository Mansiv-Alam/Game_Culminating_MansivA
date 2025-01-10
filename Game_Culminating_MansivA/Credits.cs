using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Culminating_MansivA
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Main Menu Form
            Menu Menu = new Menu();
            // Hides this form
            this.Hide();
            // Shows/Opens the menu
            Menu.Show();
        }
    }
}

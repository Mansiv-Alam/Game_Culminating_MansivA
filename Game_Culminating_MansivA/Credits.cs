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
            // Renders another screen not on the screen and then changes the rendered screen not on the screen onto the screen
            // helps with smoother animation and less lag (increases ram usage)
            this.DoubleBuffered = true;
            // Makes the background the ruins bg
            this.BackgroundImage = Resource1.RuinsBg;
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

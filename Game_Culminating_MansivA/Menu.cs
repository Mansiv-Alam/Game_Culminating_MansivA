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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Closes the Game
            this.Close();
        }

        private void btnTutorialStart_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Tutorial
            TutorialPart1 TutorialPart1 = new TutorialPart1();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            TutorialPart1.Show();
        }
    }
}

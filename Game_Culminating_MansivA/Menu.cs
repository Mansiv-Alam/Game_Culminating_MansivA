// Mansiv Alam
// January 8th 2025
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
        // Occurs when the Quit button is clicked
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Closes the Game
            this.Close();
        }
        // Occurs when the tutorial button is clicked
        private void btnTutorialStart_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Tutorial Part 1 Form
            TutorialPart3 TutorialPart3 = new TutorialPart3();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            TutorialPart3.Show();
            this.Close();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Tutorial Part 1 Form
            TutorialPart3 TutorialPart3 = new TutorialPart3();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            TutorialPart3.Show();
            this.Close();
        }
    }
}

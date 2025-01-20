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
            TutorialPart1 TutorialPart1 = new TutorialPart1();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            TutorialPart1.Show();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Main Game 1 Form
            MainGamePt3 MainGamePt3 = new MainGamePt3();
            // Hides this form
            this.Hide();
            // Shows/Opens the Main Game
            MainGamePt3.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Credits Form
            Credits Credits = new Credits();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            Credits.Show();
        }
    }
}

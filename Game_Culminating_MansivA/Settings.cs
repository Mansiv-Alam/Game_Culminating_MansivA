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
    public partial class Settings : Form
    {
        // Holds which form opened the settings form
        public static int intLevelOpened;
        // Player UI
        public static int[] intInventoryValuesSaved = new int[9];
        public static string[] strInventoryNamesSaved = new string[9];
        public static int intPlayerHealthReset = 100;
        public static int intPlayerScoreSaved = 0;
        // Game Environment Variables
        public Settings()
        {
            InitializeComponent();
        }
        // Runs if the Player wants Restarts the level
        private void btnRestartLevel_Click(object sender, EventArgs e)
        {
            if (intLevelOpened == 1) { 
                TutorialPart1 tutorialPart1 = new TutorialPart1();
                tutorialPart1.Show();
            }
            if (intLevelOpened == 2) {
                TutorialPart2 tutorialPart2 = new TutorialPart2();
                tutorialPart2.Show();
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Quits all Forms / the Entire application
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Deletes all forms and shows the menu
            Application.Restart();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {

        }
    }
}

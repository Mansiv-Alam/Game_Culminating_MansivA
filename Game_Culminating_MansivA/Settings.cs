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
        // Player Movement Variables 
        public static bool blnMovingLeftReset = false;
        public static bool blnMovingRightReset = false;
        public static bool blnIsJumpingReset = false;
        public static bool blnIsDashingReset = false;
        public static bool blnInteractReset = false;
        public static int intPlayerSpeedReset = 8;
        public static int intJumpPowerReset = 16;
        public static int intJumpVelocityReset = 0;

        public static int intDashSpeedReset = 10;
        public static int intDashCounterReset = 0;
        public static bool blnGroundedReset = true;
        public static int intGravityReset = 1;
        // Player UI
        public static int[] intInventoryValuesReset = new int[9];
        public static string[] strInventoryNamesReset = new string[9];
        public static int intPlayerHealthReset = 100;
        public static int intPlayerScoreReset = 0;
        // Game Environment Variables
        public Settings()
        {
            InitializeComponent();
        }
        // Runs if the Player wants Restarts the level
        private void btnRestartLevel_Click(object sender, EventArgs e)
        {
            /*TutorialPart2.blnMovingLeft = blnMovingLeftReset;
            TutorialPart2.blnMovingRight = blnMovingRightReset;
            TutorialPart2.blnIsJumping = blnIsJumpingReset;
            TutorialPart2.blnInteract = blnInteractReset;
            TutorialPart2.intPlayerSpeed = intPlayerSpeedReset;
            TutorialPart2.intJumpPower = intJumpPowerReset;
            TutorialPart2.intJumpVelocity = intJumpVelocityReset;
            TutorialPart2.intDashSpeed = intDashSpeedReset;
            TutorialPart2.intDashCounter = intDashCounterReset;
            TutorialPart2.blnGrounded = blnGroundedReset;
            TutorialPart2.intGravity = intGravityReset;
            TutorialPart2.blnMovingLeft = blnMovingLeftReset;
            TutorialPart2.blnMovingLeft = blnMovingLeftReset;*/
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

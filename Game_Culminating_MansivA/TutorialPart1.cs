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
    public partial class TutorialPart1 : Form
    {
        bool blnMovingLeft = false;
        bool blnMovingRight = false;
        bool blnIsJumping = false;
        int intPlayerSpeed = 8;
        int intJumpPower = 18;
        public TutorialPart1()
        {
            InitializeComponent();
        }
        // Occurs when the Settings Button is clicked
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
        // Gets the keys that are pressed
        private void TutorialPart1_KeysDown(object sender, KeyEventArgs e)
        {
            // Movement Keys for the player
            if (e.KeyCode == Keys.A)
            {
                blnMovingLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                blnMovingRight = true;
            }
            if (e.KeyCode == Keys.Space && blnIsJumping == false) {
                blnIsJumping = true;
            }
        }
        // Finds when the key is lifted so the player doesn't infinitely slide one direction after clicking a key
        private void TutorialPart1_KeysUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                blnMovingLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                blnMovingRight = false;
            }
            Console.WriteLine(Math.Sign(intJumpPower));
        }
        // A player timer for smooth movement of the player
        private void tmrPlayerMovementTick(object sender, EventArgs e)
        {
            if (blnIsJumping == true) {
                jumpingMechanics();
            }
            // moves the player depending on if the player is moving left or right
            if (blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intPlayerSpeed;
            }
            else if (blnMovingRight == true) {
                this.pcbPlayer.Left += intPlayerSpeed;
            }
        }
        private void jumpingMechanics() {
            // makes the player jump by using a function for a parabola and Math.Sign for falling down
            if (intJumpPower >= -18)
            {
                pcbPlayer.Top -= (int)((0.15 * Math.Pow((double)intJumpPower, 2.0)) *  Math.Sign(intJumpPower));
                intJumpPower--;
            }
            else
            {
                intJumpPower = 18;
                blnIsJumping = false;
                return;
            }
        }
    }
}

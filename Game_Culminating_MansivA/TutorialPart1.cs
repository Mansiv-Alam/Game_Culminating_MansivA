// Mansiv Alam
// January 9th 2025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private void btnSettings_Click(object sender, MouseEventArgs e)
        {
            
        }
        // Gets the keys that are pressed
        private void TutorialPart1_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Space && blnIsJumping == false)
            {
                blnIsJumping = true;
            }
        }
        // Finds when the key is lifted so the player doesn't infinitely slide one direction after clicking a key
        private void TutorialPart1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                blnMovingLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                blnMovingRight = false;
            }
        }
        // A player timer for smooth movement of the player
        private void tmrPlayerMovementTick(object sender, EventArgs e)
        {
            if (blnIsJumping == true) {
                playerJump();
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
        private void playerJump() {
            // makes the player jump by using a quadratic function for a parabola, Math.Sign for falling down, and a coefficent to have the player "float" near the top
            // of their jump
            if (intJumpPower >= -18)
            {
                pcbPlayer.Top -= (int)((0.15 * Math.Pow((double)intJumpPower, 2.0)) *  Math.Sign(intJumpPower));
                intJumpPower--;
            }
            else
            {
                // Resets the jump values after the jump is done
                intJumpPower = 18;
                blnIsJumping = false;
                return;
            }
        }
        // Finds and returns the index value of a specified value in a Array (Helps with inventory searches)
        private int IndexFind(int[] intArrayX, int intValue) {
            for (int i = 0; i < intArrayX.Length; i++)
            {
                if (intValue == intArrayX[i])
                {
                    return i;
                }
            }
            return -1;
        }
        // Timer for the Game
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Checks if the player went beyond the left side width and switches to tutorial level part 2
            if (pcbPlayer.Left > 1200)
            {
                TutorialPart2 TutorialPart2 = new TutorialPart2();
                // Hides this form
                this.Hide();
                // Shows/Opens the tutorial
                TutorialPart2.Show();
                this.tmrGameTick.Enabled = false;
                this.tmrPlayerMovement.Enabled = false;
                this.Close();
            }
        }
    }
}

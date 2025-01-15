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
    public partial class TutorialPart2 : Form
    {
        // Player Movement Variables 
        bool blnMovingLeft = false;
        bool blnMovingRight = false;
        bool blnIsJumping = false;
        bool blnIsDashing = false;
        int intPlayerSpeed = 8;
        int intJumpPower = 18;
        int intJumpVelocity = 0;
        int intDashSpeed = 15;
        int intDashCounter = 0;
        bool blnGrounded = true;
        int intGravity = 1;
        // Player UI
        int[] intInventoryValues = new int[9];
        int intPlayerHealth = 100;
        int intPlayerScore = 0;
        public TutorialPart2()
        {
            InitializeComponent();
        }
        // Keys getting pressed
        private void TutorialPart2_KeyDown(object sender, KeyEventArgs e)
        {
            // Movement keys for the player
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
        // Keys getting released
        private void TutorialPart2_KeyUp(object sender, KeyEventArgs e)
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
        // Player Movement
        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            checkGrounded();
            if (blnIsJumping == true)
            {
                playerJump();
            }
            // moves the player depending on if the player is moving left or right
            if (blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intPlayerSpeed;
            }
            if (blnMovingRight == true)
            {
                this.pcbPlayer.Left += intPlayerSpeed;
            }
        }
        // Handles the players jump
        private void playerJump()
        {
            // makes the player jump by using a quadratic function for a parabola, Math.Sign for falling down, and a coefficent to have the player "float" near the top of their jump
            if (intJumpPower >= -18)
            {
                pcbPlayer.Top -= (int)((0.15 * Math.Pow((double)intJumpPower, 2.0)) * Math.Sign(intJumpPower));
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
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Checks if the player went beyond the left side width and switches to tutorial level part 2
            if (pcbPlayer.Left > 1200)
            {
                TutorialPart3 TutorialPart3 = new TutorialPart3();
                // Hides this form
                this.tmrGameTick.Enabled = false;
                this.tmrPlayerMovement.Enabled = false;
                this.Hide();
                // Shows/Opens the tutorial
                TutorialPart3.Show();
                this.Close();
            }
        }
        // Checks if the player is grounded
        private void checkGrounded()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbGround.Bounds))
            {
                // Resets Variable values back to as they were when the player is grounded
                isGrounded();
            }
            else
            {
                blnGrounded = false;
            }
        }
        // Moves the player using gravity
        private void Gravity()
        {
            // Sets the player's location to 700 if in the next interval they will hit the ground so they dont glitch through the floor
            if (pcbPlayer.Location.Y + intGravity > 701)
            {
                pcbPlayer.Top = 701;
                // changes the gravity back to 1 so the gravity doesnt keep constantly increase
                intGravity = 1;
                // changes the dash counter back to 0 after landing
                intDashCounter = 0;
            }
            else
            {
                // Changes the players position using velocity and changes that velocity by 1 every interval
                pcbPlayer.Top += intGravity;
                intGravity++;
            }
        }
        // Stops the jump (helps for stopping an active jump)
        private void stopJump()
        {
            intJumpPower = 18;
            intJumpVelocity = 0;
            blnIsJumping = false;
        }
        // Stops the dash (helps cancelling an active dash)
        private void stopDash()
        {
            // resets all values after the dashes are done
            blnIsDashing = false;
            intDashSpeed = 15;
            // Increases the jump counter
            intDashCounter++;
            // Cuts the jump mid way 
            stopJump();
        }
        // Changes variables back to as if the player was grounded
        private void isGrounded()
        {
            // Makes the grounded variable true 
            blnGrounded = true;
            // resets gravity and the dash counter to 0 because the player is on the ground
            intGravity = 0;
            intDashCounter = 0;
        }
    }
}

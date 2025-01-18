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
    public partial class TutorialPart3 : Form
    {
        // Player Movement Variables 
        bool blnMovingLeft = false;
        bool blnMovingRight = false;
        bool blnIsJumping = false;
        bool blnIsDashing = false;
        bool blnInteract = false;
        int intPlayerSpeed = 8;
        int intJumpPower = 16;
        int intJumpVelocity = 0;
        int intDashSpeed = 10;
        int intDashCounter = 0;
        bool blnGrounded = true;
        int intGravity = 1;
        // Player UI
        int[] intInventoryValues = new int[9];
        string[] strInventoryNames = new string[9];
        int intPlayerHealth = 100;
        public static int intPlayerScore = Settings.intPlayerScoreSaved;
        public TutorialPart3()
        {
            InitializeComponent();
            intInventoryValues[0] = 1;
            strInventoryNames[0] = "Sword";
        }
        // Keys getting released
        private void TutorialPart3_KeyDown(object sender, KeyEventArgs e)
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
            // Interact Key
            if (e.KeyCode == Keys.E)
            {
                blnInteract = true;
            }
            // Restrict the number of dashes to 2 mid air
            if (e.KeyCode == Keys.Q && intDashCounter < 2)
            {
                blnIsDashing = true;
            }
            // Makes sure the player can't jump multiple times mid air
            if (e.KeyCode == Keys.Space && blnIsJumping == false && blnGrounded == true)
            {
                blnIsJumping = true;
            }
        }
        // Keys getting released
        private void TutorialPart3_KeyUp(object sender, KeyEventArgs e)
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
        // Handles Basic Horizontal Movement
        private void horizontalPlayerMovement()
        {
            if (blnMovingLeft == false && blnMovingRight == false)
            {
                return;
            }
            // moves the player depending on if the player is moving left or right
            if (blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intPlayerSpeed;
            }
            else if (blnMovingRight == true)
            {
                this.pcbPlayer.Left += intPlayerSpeed;
            }
        }
        // Smooth Player Movement
        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            horizontalPlayerMovement();
            checkGrounded();
            // Moves the player if they clicked q to dash
            if (blnIsDashing == true)
            {
                playerDash();
            }
            // Stops a jump affecting how the player lands on a platform
            if (blnGrounded == true && intJumpPower < 0)
            {
                stopJump();
                return;
            }
            // Moves the player if they pressed the spacebar
            if (blnIsJumping == true)
            {
                playerJump();
            }
            // Gravity
            if (blnGrounded == false && blnIsJumping == false && blnIsDashing == false)
            {
                Gravity();
            }

        }
        // Calculates the jump velocity.
        private void calculateJumpVelocity()
        {
            // makes the player jump by using a quadratic function for a parabola, Math.Sign for falling down, and a coefficent to have the player "float" near the top of their jump
            intJumpVelocity = (int)(0.2 * Math.Pow(intJumpPower, 2.0) * Math.Sign(intJumpPower));
        }
        // Handles the players jump
        private void playerJump()
        {
            if (intJumpPower >= -16)
            {
                calculateJumpVelocity();
                pcbPlayer.Top -= intJumpVelocity;
                intJumpPower--;
            }
            else
            {
                // Resets the jump values after the jump is done
                stopJump();
                // makes the player drop with gravity after a jump is done instead of gravity being zero after the jump is done
                intGravity = 25;
                return;
            }
        }
        // Manages the player dash
        private void playerDash()
        {
            // moves the player with a dash power and decreases it over the intervals to simulate deceleration
            if (intDashSpeed >= 0 && blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intDashSpeed;
                intDashSpeed--;
            }
            // Works in the other direction as well
            else if (intDashSpeed >= 0 && blnMovingRight == true)
            {
                this.pcbPlayer.Left += intDashSpeed;
                intDashSpeed--;
            }
            else
            {
                // Stops the dash and resets its values after the dash is done
                stopDash();
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
        // Stops the jump (helps for stopping an active jump)
        private void stopJump()
        {
            intJumpPower = 16;
            intJumpVelocity = 0;
            blnIsJumping = false;
        }
        // Stops the dash (helps cancelling an active dash)
        private void stopDash()
        {
            // resets all values after the dashes are done
            blnIsDashing = false;
            intDashSpeed = 10;
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

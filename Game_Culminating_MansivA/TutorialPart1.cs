// Mansiv Alam
// January 9th 2025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Culminating_MansivA
{
    public partial class TutorialPart1 : Form
    {
        // Player Movement Variables 
        bool blnMovingLeft = false;
        bool blnMovingRight = false;
        bool blnIsJumping = false;
        bool blnIsDashing = false;
        int intPlayerSpeed = 8;
        int intJumpPower = 16;
        int intJumpVelocity = 0;
        int intDashSpeed = 10;
        int intDashCounter = 0;
        bool blnGrounded = true;
        int intGravity = 1;
        // Player UI
        int[] intInventoryValues = new int[9];
        int intPlayerHealth = 100;
        int intPlayerScore = 0;

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
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Updates score per game tick
            updateScore();
            // Updates Health
            updateHealth();
            // Checks if the player went beyond the left side width and switches to tutorial level part 2
            if (pcbPlayer.Left > 1200)
            {
                // Adds 10 score
                intPlayerScore += 10;
                // Saves the score to the settings form
                Settings.intPlayerScoreSaved = intPlayerScore;
                TutorialPart2 TutorialPart2 = new TutorialPart2();
                // Hides this form
                this.Hide();
                // Shows/Opens the tutorial
                TutorialPart2.Show();
                this.Close();
            }
            // makes a boundary for the left wall using the speed of the player and how many pixels they could move beyond the window
            else if (pcbPlayer.Left - 3 <= 0)
            {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
            }
        }
        // A player timer for smooth movement of the player, Also controls player physics
        private void tmrPlayerMovementTick(object sender, EventArgs e)
        {
            checkGrounded();
            extraScoreHitbox();
            hitboxPlatform1();
            // Moves the player if they clicked q to dash
            if (blnIsDashing == true) {
                playerDash();
            }
            // moves the player depending on if the player is moving left or right
            if (blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intPlayerSpeed;
            }
            else if (blnMovingRight == true) {
                this.pcbPlayer.Left += intPlayerSpeed;
            }
            // Stops a jump affecting how the player lands on a platform
            if (blnGrounded == true && intJumpPower < 0) {
                stopJump();
                return;
            }
            // Moves the player if they pressed the spacebar
            if (blnIsJumping == true)
            {
                playerJump();
            }
            // Gravity
            if (blnGrounded == false && blnIsJumping == false && blnIsDashing == false) {
                Gravity();
            }
        }
        // Calculates the jump velocity.
        private void calculateJumpVelocity()
        {
            // makes the player jump by using a quadratic function for a parabola, Math.Sign for falling down, and a coefficent to have the player "float" near the top
            // of their jump
            intJumpVelocity = (int)(0.2 * Math.Pow((double)intJumpPower, 2.0) * Math.Sign(intJumpPower));
        }
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
            if (intDashSpeed >= 0 && blnMovingLeft == true) {
                this.pcbPlayer.Left -= intDashSpeed;
                intDashSpeed--;
            }
            // Works in the other direction as well
            else if (intDashSpeed >= 0 && blnMovingRight == true)
            {
                this.pcbPlayer.Left += intDashSpeed;
                intDashSpeed--;
            }
            else {
                // Stops the dash and resets its values after the dash is done
                stopDash();
            }
            // Stops an active jump if there is a dash
            stopJump();
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
            else {
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
        // Manages the hitbox for the platform 
        private void hitboxPlatform1(){
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform1.Bounds)){
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                // Careful of the falling velocity of the player because thats what determines if the + 30 needs to increase or not
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbPlatform1.Top && pcbPlayer.Bottom < pcbPlatform1.Top + 30)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform1.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                } 
                else {
                    blnGrounded = false;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbPlatform1.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbPlatform1.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform1.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform1.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform1.Top + 1 && pcbPlayer.Top < pcbPlatform1.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform1.Left && pcbPlayer.Left < pcbPlatform1.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbPlatform1.Left)
                        {
                            pcbPlayer.Left = pcbPlatform1.Left - (pcbPlayer.Width + 5);
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform1.Right)
                        {
                            pcbPlayer.Left = pcbPlatform1.Right + 5;
                        }
                    }
                }
            }
        }
        // Hitbox for the extra score
        private void extraScoreHitbox() {
            // Checks if the extra score is visible/on the screem
            if (pcbExtraScore.Visible == true)
            {
                if (pcbPlayer.Bounds.IntersectsWith(pcbExtraScore.Bounds))
                {
                    // increases score
                    intPlayerScore += 5;
                    // Makes the extra score dissapear
                    pcbExtraScore.Visible = false;
                }
            }
        }
        // Stops the jump (helps for stopping an active jump)
        private void stopJump() {
            intJumpPower = 16;
            intJumpVelocity = 0;
            blnIsJumping = false;
        }
        // Stops the dash (helps cancelling an active dash)
        private void stopDash() {
            // resets all values after the dashes are done
            blnIsDashing = false;
            intDashSpeed = 10;
            // Increases the jump counter
            intDashCounter++;
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
        // Updates the score text based on the score variable
        private void updateScore() {
            this.lblScore.Text = "Score: " + intPlayerScore;
        }
        // Updates the Health text based on the health variable
        private void updateHealth()
        {
            this.lblPlayerHealth.Text = "Health: " + intPlayerHealth;
        }
        // Opens the settings form
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Changes the int level opened in the settings form so that we can reopen this level
            Settings.intLevelOpened = 1;
            Settings settings = new Settings();
            settings.Show();
            // Closes this form
            this.Close();
        }
    }
}

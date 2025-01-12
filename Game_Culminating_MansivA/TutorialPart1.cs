// Mansiv Alam
// January 9th 2025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // A player timer for smooth movement of the player, Also controls player physics
        private void tmrPlayerMovementTick(object sender, EventArgs e)
        {
            //Console.WriteLine(intGravity + "," + intJumpVelocity + "," + intJumpPower);
            checkGrounded();
            platformHitBoxBottom();
            // Moves the player if they clicked q to dash
            if (blnIsDashing == true) {
                playerDash();
                return;
            }
            // Moves the player if they pressed the spacebar
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
            // Gravity
            if (blnGrounded == false && blnIsJumping == false && blnIsDashing == false) {
                Gravity();
            }
        }
        private void playerJump()
        {
            // makes the player jump by using a quadratic function for a parabola, Math.Sign for falling down, and a coefficent to have the player "float" near the top
            // of their jump
            if (intJumpPower >= -18)
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
                intGravity = 30;
                return;
            }
        }
        // Calculates the jump velocity.
        private void calculateJumpVelocity()
        {
            intJumpVelocity = (int)(0.15 * Math.Pow((double)intJumpPower, 2.0) * Math.Sign(intJumpPower));
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
                // resets all values after the dashes are done
                blnIsDashing = false;
                intDashSpeed = 15;
                // Increases the jump counter
                intDashCounter++;
                // Cuts the jump mid way 
                stopJump();
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
        // Timer for the Game (Enemy Ai, hitboxes)
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
                this.Close();
            }
            // makes a boundary for the left wall using the speed of the player and how many pixels they could move beyond the window
            else if (pcbPlayer.Left - 3 <= 0) {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
            }
        }
        // Checks if the player is grounded
        private void checkGrounded(){
            if (pcbPlayer.Bounds.IntersectsWith(pcbGround.Bounds) || platformHitboxTop() == true)
            {
                blnGrounded = true;
                intGravity = 0;
                // keeps the dash counter 0 if the player is on the ground
                intDashCounter = 0;
            }
            else {
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
            else {
                // Changes the players position using velocity and changes that velocity by 1 every interval
                pcbPlayer.Top += intGravity;
                intGravity++;
            }
        }
        // Manages the top hitbox for the platform
        private bool platformHitboxTop(){
            // Checks if the player jumps to the top of the platform 
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform1.Bounds) && pcbPlayer.Bottom + intJumpVelocity <= (pcbPlatform1.Location.Y + 30))
            {
                // Location of the platform and the player height
                pcbPlayer.Top = pcbPlatform1.Location.Y + 1 - pcbPlayer.Height;
                return true;
            }
            else { return false; }
        }
        private void platformHitBoxBottom(){
            // Checks if the player jumps and hits the bottom of the platform
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform1.Bounds) && pcbPlayer.Top > (pcbPlatform1.Location.Y + 20))
            {
                pcbPlayer.Top = pcbPlatform1.Bottom + 1;
                // stops the jump
                stopJump();
            }
        }
        // Stops the jump (helps for stopping an active jump)
        private void stopJump() {
            intJumpPower = 18;
            blnIsJumping = false;
        }
    }
}

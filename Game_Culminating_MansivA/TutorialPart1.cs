﻿// Mansiv Alam
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
        int intJumpPower = 14;
        int intJumpPowerMin = -14;
        int intJumpVelocity = 0;
        int intDashSpeed = 10;
        int intDashCounter = 0;
        bool blnGrounded = true;
        int intGravity = 1;
        bool blnSwordAttack = false;
        int intSwordAttackCounter = 0;
        // Player UI
        int[] intInventoryValues = new int[5];
        string[] strInventoryNames = new string[5];
        int intPlayerHealth = 100;
        int intPlayerScore = 0;
        string strMainHandItemName = "";
        int intMainHandItemValue;
        // Tutorial Text 
        int intTutorialText = 0;
        public TutorialPart1()
        {
            InitializeComponent();
            strMainHandItemName = "Sword";
            intMainHandItemValue = 1;
            lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            // Renders another screen not on the screen and then changes the rendered screen not on the screen onto the screen
            // helps with smoother animation and less lag (increases ram usage)
            this.DoubleBuffered = true;
            // Makes the background the ruins bg
            this.BackgroundImage = Resource1.RuinsBg;
            // Adds Images to the platform
            pcbPlatform1.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbPlatform1.BackgroundImageLayout = ImageLayout.Stretch;
            // Image for the extra score
            pcbExtraScore.BackgroundImage = Resource1.ExtraScore;
            pcbExtraScore.BackgroundImageLayout = ImageLayout.Stretch;
        }
        // Gets the keys that are pressed
        private void TutorialPart1_KeyDown(object sender, KeyEventArgs e)
        {
            // Inventory key for the main hand
            if (e.KeyCode == Keys.D1)
            {
                swapToMainHand(1);
                lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            }
            else if (e.KeyCode == Keys.D2)
            {
                swapToMainHand(2);
                lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            }
            else if (e.KeyCode == Keys.D3)
            {
                swapToMainHand(3);
                lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            }
            else if (e.KeyCode == Keys.D4)
            {
                swapToMainHand(4);
                lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            }
            else if (e.KeyCode == Keys.D5)
            {
                swapToMainHand(5);
                lblMainHand.Text = "Main Hand:" + strMainHandItemName;
            }
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
        // Finds when the player clicks to use the sword
        private void PlayerMouseClick(object sender, MouseEventArgs e)
        {
            blnSwordAttack = true;
            intSwordAttackCounter = 0;
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
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Updates score per game tick
            updateScore();
            // Updates Health
            updateHealth();
            // updates Inventory Text
            inventoryUpdate();
            // Updates the main hand text
            mainHandUpdate();
            // Handles Sword Attack
            playerSwordVisibility();
            // Checks if the player went beyond the left side width and switches to tutorial level part 2
            if (pcbPlayer.Left > 1200)
            {
                // Adds 10 score
                intPlayerScore += 10;
                // Saves the score to the settings form
                Settings.intPlayerScoreSaved = intPlayerScore;
                sortInventory();
                SaveInventory();
                TutorialPart2 TutorialPart2 = new TutorialPart2();
                // Hides this form
                this.Hide();
                // Shows/Opens the tutorial
                TutorialPart2.Show();
                this.Close();
            }
            // makes a boundary for the left wall
            else if (pcbPlayer.Left - 3 <= 0)
            {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
            }
        }
        // A player timer for smooth movement of the player, Also controls player physics
        private void tmrPlayerMovementTick(object sender, EventArgs e)
        {
            horizontalPlayerMovement();
            swordPositionUpdate();
            checkGrounded();
            extraScoreHitbox();
            hitboxPlatform1();
            // Moves the player if they clicked q to dash
            if (blnIsDashing == true) {
                playerDash();
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
            if (intJumpPower >= intJumpPowerMin)
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
        // Moves the player using gravity
        private void Gravity()
        {
            // Sets the player's location to 722 (based on the players Height) if in the next interval they will hit the ground so they dont glitch through the floor
            if (pcbPlayer.Location.Y + intGravity > 722)
            {
                pcbPlayer.Top = 722;
                // changes the gravity back to 1 so the gravity doesnt keep constantly increase
                intGravity = 1;
                // changes the dash counter back to 0 after landing
                intDashCounter = 0;
            }
            // adds terminal velocity
            else if (intGravity < 25)
            {
                // Changes the players position using velocity and changes that velocity by 1 every interval
                pcbPlayer.Top += intGravity;
                intGravity++;
            }
            else {
                pcbPlayer.Top += intGravity;
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
        private void extraScoreHitbox()
        {
            // Checks if the extra score is visible/on the screem
            if (pcbExtraScore.Visible == true)
            {
                if (pcbPlayer.Bounds.IntersectsWith(pcbExtraScore.Bounds))
                {
                    // increases score
                    intPlayerScore += 5;
                    // Makes the extra score disappear
                    pcbExtraScore.Visible = false;
                }
            }
        }
        // Swaps a inventory slot to the main hand.
        private void swapToMainHand(int intValue)
        {
            int intTemp; string strTemp;
            // Swaps the int values for the Item in the inventory and the item in the main hand
            intTemp = intInventoryValues[intValue - 1];
            intInventoryValues[intValue - 1] = intMainHandItemValue;
            intMainHandItemValue = intTemp;
            // Swaps the string values for the Item in the inventory and the item in the main hand
            strTemp = strInventoryNames[intValue - 1];
            strInventoryNames[intValue - 1] = strMainHandItemName;
            strMainHandItemName = strTemp;
        }
        // Updates the inventory values
        private void inventoryUpdate()
        {
            this.lblPlayerInventory.Text = "Inventory: " + strInventoryNames[0] + " | " + strInventoryNames[1] + " | " + strInventoryNames[2] + " | " + strInventoryNames[3] + " | " + strInventoryNames[4];
        }
        // Updates Main hand text
        private void mainHandUpdate()
        {
            this.lblMainHand.Text = lblMainHand.Text = "Main Hand:" + strMainHandItemName;
        }
        // Handles the player's sword attack duration and Visibility
        private void playerSwordVisibility()
        {
            // Check if the player is attacking
            if (blnSwordAttack == true)
            {
                // Checks if the sword is in the main hand 
                if (intMainHandItemValue == 1 && intSwordAttackCounter <= 50)
                {
                    // 1 second attack
                    pcbSword.Visible = true;
                    intSwordAttackCounter++;
                }
                else
                {
                    // If the duration is over or the sword isnt in the main hand makes the sword disapear
                    blnSwordAttack = false;
                    pcbSword.Visible = false;
                    // resets the duration for another sword attack
                    intSwordAttackCounter = 0;
                }
            }
        }
        // Updates the position of the sword relative to the player
        private void swordPositionUpdate() {
            if (blnMovingLeft == true)
            {
                pcbSword.Left = pcbPlayer.Left - pcbSword.Width;
                pcbSword.Top = pcbPlayer.Top + 25;
            }
            else {
                pcbSword.Left = pcbPlayer.Right;
                pcbSword.Top = pcbPlayer.Top + 25;
            }
        }
        // Stops the jump (helps for stopping an active jump)
        private void stopJump() {
            intJumpPower = 14;
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
        // Sorts Inventory So that the sword is always in the first slot when entering a new level
        private void sortInventory()
        {
            int intTemp;
            string strTemp;
            for (int i = 0; i < intInventoryValues.Length; i++)
            {
                for (int j = 0; j < intInventoryValues.Length - 1; j++)
                {
                    // Skips Swapping with zeros
                    if (intInventoryValues[j + 1] == 0 || intInventoryValues[i] == 0)
                    {
                        continue;
                    }
                    // Ascending Order
                    if (intInventoryValues[i] > intInventoryValues[j + 1])
                    {
                        // Swaps the int values 
                        intTemp = intInventoryValues[j + 1];
                        intInventoryValues[j + 1] = intInventoryValues[i];
                        intInventoryValues[i] = intTemp;
                        // Swaps the string values 
                        strTemp = strInventoryNames[j + 1];
                        strInventoryNames[j + 1] = strInventoryNames[i];
                        strInventoryNames[i] = strTemp; ;
                    }
                }
            }
        }
        // Saves inventory for the next level
        private void SaveInventory()
        {
            // Saves main hand values for the next level
            Settings.intMainHandValue = intMainHandItemValue;
            Settings.strMainHandItemName = strMainHandItemName;
            for (int i = 0; i < intInventoryValues.Length; i++)
            {
                Settings.intInventoryValuesSaved[i] = intInventoryValues[i];
                Settings.strInventoryNamesSaved[i] = strInventoryNames[i];
            }
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

        private void lblTutorial1Text_Click(object sender, EventArgs e)
        {
            if (intTutorialText == 0)
            {
                lblTutorial1Text.Text = "To move use the A and D keys to go left or right\n and use space bar to jump (Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 1)
            {
                lblTutorial1Text.Text = "Press Q and the A or D keys to dash and E to \n Interact (Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 2)
            {
                lblTutorial1Text.Text = "You get score by either collecting the golden orbs (+5 Score) \n or by completing the level (+10 Score)(Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 3)
            {
                lblTutorial1Text.Text = "You Lose Score by dying (-5 Score). In the bottom left you have\n a health bar, an inventory, and a main hand (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 4)
            {
                lblTutorial1Text.Text = "To Swap from your main hand to your inventory, \n Press 1,2,3,4, or 5 (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 5)
            {
                lblTutorial1Text.Text = "You Can also use a Sword Attack when you have your sword in your\n main hand and click on the screen (Make sure to click the \n background and not anything else)" +
                    "(Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 6)
            {
                lblTutorial1Text.Text = "Your inventory saves and sorts itself when you go to the next \n level however your game does not auto save so make sure\n you save in the settings. (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 7)
            {
                lblTutorial1Text.Text = "Your Save load contains your score, your current level, \n and your inventory. It does not save any progress you have made\n in a current level (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 8)
            {
                lblTutorial1Text.Text = "Your Health Reset back to 100 after completing a level. To\ncomplete a level, go to the left side of your page (Click to Close)";
                intTutorialText++;
            }
            else if (intTutorialText == 9) {
                lblTutorial1Text.Visible = false;
                lblTutorial1Text.Enabled = false;
            }
        }
    }
}

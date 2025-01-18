﻿using System;
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
        // Game Environment Variables

        public TutorialPart2()
        {
            InitializeComponent();
            intInventoryValues[0] = 1;
            strInventoryNames[0] = "Sword";
        }
        // Keys getting pressed
        private void TutorialPart2_KeyDown(object sender, KeyEventArgs e)
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
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Changes the score/ Updates the score text
            changeScore();
            // Checks if the player has interacted with a key game object
            playerInteract();
            // holdable button hitbox
            holdableButtonHitbox();
            // updates the inventory text
            inventoryUpdate();
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
            // makes a boundary for the left wall using the speed of the player and how many pixels they could move beyond the window
            else if (pcbPlayer.Left - intPlayerSpeed <= 0)
            {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
            }
        }
        // Handles Basic Horizontal Movement
        private void horizontalPlayerMovement() {
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
        // Player Movement
        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            btnSettings.TabStop = false;
            horizontalPlayerMovement();
            //Console.WriteLine(intGravity + "," + intJumpVelocity + "," + blnIsJumping + "," + blnGrounded);
            //Console.WriteLine("Player Position: Left = " + pcbPlayer.Left + ", Right = " + pcbPlayer.Right + ", Top = " + pcbPlayer.Top + ", Bottom = " + pcbPlayer.Bottom + " Is grounded: " + blnGrounded);
            // Moves the player if they pressed the spacebar
            checkGrounded();
            wallHitbox();
            hitboxPlatform1();
            hitboxPlatform2();
            hitboxPlatform3();
            hitboxMovableBox();
            hitboxLockedCyanDoor();
            hitboxLockedLeverDoor();
            hitboxLockedButtonDoor();
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
        // Manages the hitbox for the platform 
        private void hitboxPlatform1()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform1.Bounds))
            {
                
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                // Careful of the falling velocity of the player because thats what determines if the + 30 needs to increase or not
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform1.Top && pcbPlayer.Bottom < pcbPlatform1.Top + 35))
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform1.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
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
                            pcbPlayer.Left = pcbPlatform1.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform1.Right)
                        {
                            pcbPlayer.Left = pcbPlatform1.Right;
                        }
                    }
                }
            }
        }
        // hitbox for platform 2
        private void hitboxPlatform2()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform2.Bounds))
            {
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform2.Top && pcbPlayer.Bottom < pcbPlatform2.Top + 30))
                {
                    pcbPlayer.Top = pcbPlatform2.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                if (pcbPlayer.Top > pcbPlatform2.Location.Y)
                {
                    pcbPlayer.Top = pcbPlatform2.Bottom + 1;
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false) {
                    // Left dash
                    if (blnMovingLeft == true){ stopDash(); pcbPlayer.Left = pcbPlatform2.Right;}
                    // Right dash
                    else if (blnMovingRight == true){ stopDash(); pcbPlayer.Left = pcbPlatform2.Left - pcbPlayer.Width;}
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform2.Top + 1 && pcbPlayer.Top < pcbPlatform2.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform2.Left && pcbPlayer.Left < pcbPlatform2.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbPlatform2.Left)
                        {
                            pcbPlayer.Left = pcbPlatform2.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform2.Right)
                        {
                            pcbPlayer.Left = pcbPlatform2.Right;
                        }
                    }
                }
            }
        }
        // hitbox for platform 3
        private void hitboxPlatform3()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform3.Bounds))
            {
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform3.Top) && (pcbPlayer.Bottom < pcbPlatform3.Top + 30))
                {
                    pcbPlayer.Top = pcbPlatform3.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                if (pcbPlayer.Top > pcbPlatform3.Location.Y)
                {
                    pcbPlayer.Top = pcbPlatform3.Bottom + 1;
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform3.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform3.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform3.Top + 1 && pcbPlayer.Top < pcbPlatform3.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform3.Left && pcbPlayer.Left < pcbPlatform3.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbPlatform3.Left)
                        {
                            pcbPlayer.Left = pcbPlatform3.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform3.Right)
                        {
                            pcbPlayer.Left = pcbPlatform3.Right;
                        }
                    }
                }
            }
        }
        // hitbox for the cyan door when its locked
        private void hitboxLockedCyanDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedCyanDoor.Bounds))
            {
                // also checks if the user has a key in their second slot (will change later)
                if (intInventoryValues[1] != 2 && pcbLockedCyanDoor.Visible == true)
                {
                    if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbLockedCyanDoor.Top) && (pcbPlayer.Bottom < pcbLockedCyanDoor.Top + 30))
                    {
                        pcbPlayer.Top = pcbLockedCyanDoor.Location.Y + 1 - pcbPlayer.Height;
                        isGrounded();
                        return;
                    }
                    // Doesnt need the if condition for the bottom of the door
                    // Stops a dash from clipping into the platform from the left and right side
                    if (blnIsDashing == true && blnGrounded == false)
                    {
                        // Left dash
                        if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbLockedCyanDoor.Right; }
                        // Right dash
                        else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbLockedCyanDoor.Left - pcbPlayer.Width; }
                    }
                    // Handles Horizontal Collision (First checks if the players is both above and below the door)
                    if (pcbPlayer.Bottom > pcbLockedCyanDoor.Top + 1 && pcbPlayer.Top < pcbLockedCyanDoor.Bottom)
                    {
                        // Checks which part is inside of the Door (right side or lefts)
                        if (pcbPlayer.Right > pcbLockedCyanDoor.Left && pcbPlayer.Left < pcbLockedCyanDoor.Right)
                        {
                            // Checks if the left side is Outside the door
                            if (pcbPlayer.Left < pcbLockedCyanDoor.Left)
                            {
                                pcbPlayer.Left = pcbLockedCyanDoor.Left - pcbPlayer.Width;
                            }
                            // Checks if the right side is Outside the door
                            else if (pcbPlayer.Right > pcbLockedCyanDoor.Right)
                            {
                                pcbPlayer.Left = pcbLockedCyanDoor.Right;
                            }
                        }
                    }
                }
                else {
                    deleteCyanKey();
                }
            }
        }
        // hitbox for the Lever door when to unlock or get blocked by it
        private void hitboxLockedLeverDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedLeverDoor.Bounds) && pcbLockedLeverDoor.Visible == true)
            {
                // also checks if the user has a key in their second slot (will change later)
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbLockedLeverDoor.Top) && (pcbPlayer.Bottom < pcbLockedLeverDoor.Top + 30))
                {
                    pcbPlayer.Top = pcbLockedLeverDoor.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Doesnt need the if condition for the bottom of the door
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbLockedLeverDoor.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbLockedLeverDoor.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the door)
                if (pcbPlayer.Bottom > pcbLockedLeverDoor.Top + 1 && pcbPlayer.Top < pcbLockedLeverDoor.Bottom)
                {
                    // Checks which part is inside of the door (right side or lefts)
                    if (pcbPlayer.Right > pcbLockedLeverDoor.Left && pcbPlayer.Left < pcbLockedLeverDoor.Right)
                    {
                        // Checks if the left side is Outside the door
                        if (pcbPlayer.Left < pcbLockedLeverDoor.Left)
                        {
                            pcbPlayer.Left = pcbLockedLeverDoor.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the door
                        else if (pcbPlayer.Right > pcbLockedLeverDoor.Right)
                        {
                            pcbPlayer.Left = pcbLockedLeverDoor.Right;
                        }
                    }
                }
            }
        }
        //
        // hitbox for the Lever door when to unlock or get blocked by it
        private void hitboxLockedButtonDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedButtonDoor.Bounds) && pcbLockedButtonDoor.Visible == true)
            {
                // also checks if the user has a key in their second slot (will change later)
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbLockedLeverDoor.Top) && (pcbPlayer.Bottom < pcbLockedLeverDoor.Top + 30))
                {
                    pcbPlayer.Top = pcbLockedButtonDoor.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Doesnt need the if condition for the bottom of the door
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbLockedButtonDoor.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbLockedButtonDoor.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the door)
                if (pcbPlayer.Bottom > pcbLockedButtonDoor.Top + 1 && pcbPlayer.Top < pcbLockedButtonDoor.Bottom)
                {
                    // Checks which part is inside of the door (right side or lefts)
                    if (pcbPlayer.Right > pcbLockedButtonDoor.Left && pcbPlayer.Left < pcbLockedButtonDoor.Right)
                    {
                        // Checks if the left side is Outside the door
                        if (pcbPlayer.Left < pcbLockedButtonDoor.Left)
                        {
                            pcbPlayer.Left = pcbLockedButtonDoor.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the door
                        else if (pcbPlayer.Right > pcbLockedButtonDoor.Right)
                        {
                            pcbPlayer.Left = pcbLockedLeverDoor.Right;
                        }
                    }
                }
            }
        }
        // Hitbox and physics for the Movable box
        private void hitboxMovableBox() {
            if (pcbPlayer.Bounds.IntersectsWith(pcbMovableBox.Bounds))
            {
                //Checks if the player is above the box
                // also checks if the user has a key in their second slot (will change later)
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbMovableBox.Top) && (pcbPlayer.Bottom < pcbMovableBox.Top + 30))
                {
                    pcbPlayer.Top = pcbMovableBox.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks which direction the box is being pushed and moves the box accordingly
                if (blnMovingLeft == true)
                {
                    pcbMovableBox.Left = pcbPlayer.Left + 1 - pcbMovableBox.Width;
                }
                else if (blnMovingRight == true) {
                    pcbMovableBox.Left = pcbPlayer.Right;
                }
            }
            // Checks if the box is touching either side of the screen or the platform/floor it is suppose to be touching
            if (pcbMovableBox.Left < 0) {
                pcbMovableBox.Left = 0;
                pcbPlayer.Left = pcbMovableBox.Right;
            }
            if (pcbMovableBox.Bounds.IntersectsWith(pcbWall.Bounds)) {
                pcbMovableBox.Left = pcbWall.Left - pcbMovableBox.Width;
                pcbPlayer.Left = pcbMovableBox.Left - pcbPlayer.Width;
            }
        }
        // hitbox for the Right wall
        private void wallHitbox() {
            if (pcbPlayer.Bounds.IntersectsWith(pcbWall.Bounds)) {
                pcbPlayer.Left = pcbWall.Left - pcbPlayer.Width;
            }
        }
        // Hitbox for the holdable button
        private void holdableButtonHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbHoldableButton.Bounds) || pcbMovableBox.Bounds.IntersectsWith(pcbHoldableButton.Bounds))
            {
                pcbLockedButtonDoor.Visible = false;
                pcbHoldableButton.BackColor = Color.SpringGreen;
            }
            else {
                pcbLockedButtonDoor.Visible = true;
                pcbHoldableButton.BackColor = Color.DarkTurquoise;
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
        // Checks if the player interacts with any game object
        private void playerInteract() {
            if (blnInteract == true) {
                if (pcbPlayer.Bounds.IntersectsWith(pcbCyanKey.Bounds) && pcbCyanKey.Visible == true)
                {
                    pcbCyanKey.Visible = false;
                    intInventoryValues[1] = 2;
                    strInventoryNames[1] = "Cyan Key";
                    blnInteract = false;
                }
                if (pcbPlayer.Bounds.IntersectsWith(pcbLever.Bounds))
                {
                    if (pcbLever.BackColor == Color.SandyBrown)
                    {
                        pcbLever.BackColor = Color.DarkGreen;
                        pcbLockedLeverDoor.Visible = false;
                        blnInteract = false;
                    }
                    else
                    {
                        pcbLockedLeverDoor.Visible = true;
                        pcbLever.BackColor = Color.SandyBrown;
                        blnInteract = false;
                    }
                }
                else {
                    blnInteract = false;
                }
            }
        }
        // Changes the score text based on the score variable
        private void changeScore()
        {
            this.lblScore.Text = "Score: " + intPlayerScore;
        }
        // Updates the inventory values
        private void inventoryUpdate() {
            this.lblPlayerInventory.Text = "Inventory: " + strInventoryNames[0] + ", " + strInventoryNames[1];
        }
        // Gets rid of the key after using it
        private void deleteCyanKey() {
            pcbLockedCyanDoor.Visible = false;
            intInventoryValues[1] = -1;
            strInventoryNames[1] = null;
        }
        // Shows a form when you click the settings button
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings.intLevelOpened = 2;
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }
    }
}

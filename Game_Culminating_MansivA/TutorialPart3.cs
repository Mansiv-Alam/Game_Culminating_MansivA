﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        string strMainHandItemName = "";
        int intMainHandItemValue;
        int intPlayerScore = Settings.intPlayerScoreSaved;
        // Game Environment
        bool blnTrapIsFalling = false;
        bool blnBasicEnemyMovingLeft = true;
        bool blnStrongEnemyMovingLeft = false;
        int intEnemySwordVisibilityCounter = 26;
        int intEnemyAttackInterval = 0;
        int intStrongEnemySwordVisibilityCounter = 26;
        int intStrongEnemyAttackInterval = 0;
        bool blnBasicEnemyCanDamagePlayer = true;
        bool blnStrongEnemyCanDamagePlayer = true;
        int intTutorialText = 0;
        public TutorialPart3()
        {
            InitializeComponent();
            // Renders another screen not on the screen and then changes the rendered screen not on the screen onto the screen
            // helps with smoother animation and less lag (increases ram usage)
            this.DoubleBuffered = true;
            // Makes the background the ruins bg
            this.BackgroundImage = Resource1.RuinsBg;
            // Images for all platforms and stretchs out them so they look more natural
            pcbPlatform1.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbPlatform1.BackgroundImageLayout = ImageLayout.Stretch;
            pcbPlatform2.BackgroundImage = Resource1.LightStonePlatformLong;
            pcbPlatform2.BackgroundImageLayout = ImageLayout.None;
            pcbPlatform3.BackgroundImage = Resource1.LightStonePlatformLong;
            pcbPlatform3.BackgroundImageLayout = ImageLayout.Stretch;
            pcbPlatform4.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbPlatform4.BackgroundImageLayout = ImageLayout.Stretch;
            pcbWall.BackgroundImage = Resource1.LightStoneWall;
            pcbWall.BackgroundImageLayout = ImageLayout.Stretch;
            // Environmental Hazards 
            pcbSpike.BackgroundImage = Resource1.Spike;
            pcbSpike.BackgroundImageLayout = ImageLayout.Stretch;
            pcbFallingTrap.BackgroundImage = Resource1.FallingTrap;
            pcbFallingTrap.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLava.BackgroundImage = Resource1.Lava;
            pcbLava.BackgroundImageLayout = ImageLayout.Stretch;
            LoadInventory();
        }
        // Keys getting released
        private void TutorialPart3_KeyDown(object sender, KeyEventArgs e)
        {
            // Inventory keys for the main hand
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
        // Runs when the player wants to Attack with the sword using a click or use a health poition
        private void PlayerMouseClick(object sender, MouseEventArgs e)
        {
            // Heals the player
            if (intMainHandItemValue == 99)
            {
                intMainHandItemValue = 0;
                strMainHandItemName = "";
                intPlayerHealth += 40;
            }
            else {
                // Starts a sword attack
                blnSwordAttack = true;
                intSwordAttackCounter = 0;
            }
        }
        // Timer for the Game (Enemy Ai, Boundaries)
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Updates the score text
            updateScore();
            // Updates the health text
            updateHealth();
            // Updates the inventory text
            inventoryUpdate();
            // Updates the health text
            playerHealthCheck();
            // Handles the players attacks
            playerSwordVisibility();
            // Defeats the enemy if the player is attacking
            swordDamage();
            // Updates main hand text
            mainHandUpdate();
            // Enemy ai
            EnemyAi();
            if (pcbPlayer.Left > 1200)
            {
                // Resets score for the main game
                Settings.intPlayerScoreSaved = intPlayerScore;

                Menu menu = new Menu();
                // Hides this form
                this.tmrGameTick.Enabled = false;
                this.tmrPlayerMovement.Enabled = false;
                this.Hide();
                // Shows/Opens the tutorial
                menu.Show();
                this.Close();
            }
            // makes a boundary for the left wall 
            else if (pcbPlayer.Left - 3 <= 0)
            {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
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
            swordPositionUpdate();
            checkGrounded();
            wallHitbox();
            hitboxLava();
            hitboxSpike();
            fallingTrapPhysics();
            hitboxPlatform1();
            hitboxPlatform2();
            hitboxPlatform3();
            hitboxPlatform4();
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
            // Stops an active jump when there is a dash
            stopJump();
        }
        // Moves the player using gravity
        private void Gravity()
        {
            // Sets the player's location to 722 (based on the players height) if in the next interval they will hit the ground so they dont glitch through the floor
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
            else
            {
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
        // Manages the hitbox for platform 1
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
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform2.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform2.Left - pcbPlayer.Width; }
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
        // Hitbox for platform 4
        private void hitboxPlatform4()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform4.Bounds))
            {

                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform4.Top && pcbPlayer.Bottom < pcbPlatform4.Top + 35))
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform4.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbPlatform4.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbPlatform4.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into by dashing the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform4.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform4.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform4.Top + 1 && pcbPlayer.Top < pcbPlatform4.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform4.Left && pcbPlayer.Left < pcbPlatform4.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbPlatform4.Left)
                        {
                            pcbPlayer.Left = pcbPlatform4.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform4.Right)
                        {
                            pcbPlayer.Left = pcbPlatform4.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for lava
        private void hitboxLava() {
            // Checks if the player has touched the lava but also gives the player a bit of leeway
            if (pcbPlayer.Bounds.IntersectsWith(pcbLava.Bounds) && pcbPlayer.Right > pcbLava.Left + 10 && pcbPlayer.Left < pcbLava.Right - 10)
            {
                intPlayerHealth = 0;
            }
        }
        // Hitbox for the Spike
        private void hitboxSpike()
        {
            // Checks if the player has touched the spike with some margin 
            if (pcbPlayer.Bounds.IntersectsWith(pcbSpike.Bounds) && pcbPlayer.Right > pcbSpike.Left + 5 && pcbPlayer.Left < pcbSpike.Right - 5)
            {
                // Decreases health
                intPlayerHealth -= 10;
                // Changes the player's Height
                pcbPlayer.Top = pcbSpike.Top - 1 - pcbPlayer.Height;
                // Changes the jump variables to make a mini player jump
                intJumpPower = 10;
                intJumpPowerMin = -10;
                blnIsJumping = true;
            }
        }
        // hitbox for the Right wall
        private void wallHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbWall.Bounds))
            {
                pcbPlayer.Left = pcbWall.Left - pcbPlayer.Width;
            }
        }
        // Hitbox/Physics for the falling trap
        private void fallingTrapPhysics()
        {
            if (pcbFallingTrap.Visible == true) {
                // Checks if the player is under the trap but also above the platform on which the falling trap will fall onto
                if (pcbPlayer.Left - 10 < pcbFallingTrap.Right && pcbPlayer.Top < pcbPlatform2.Top) {
                    blnTrapIsFalling = true;
                }
                // Continues to fall until the bottom of the falling trap has reached the platform/ designated end point
                if (blnTrapIsFalling == true)
                {
                    pcbFallingTrap.Top += 5;
                    if (pcbFallingTrap.Bounds.IntersectsWith(pcbPlatform2.Bounds))
                    {
                        pcbFallingTrap.Visible = false;
                    }
                }
                // Checks if the player has touched the falling trap and makes the trap break/dissapear if the player is touching the falling trap
                if (pcbPlayer.Bounds.IntersectsWith(pcbFallingTrap.Bounds)) {
                    intPlayerHealth -= 40;
                    pcbFallingTrap.Visible = false;
                }
            }
        }
        // Handles the Enemy Ai
        private void EnemyAi() {
            if (pcbBasicEnemy.Visible == true)
            {
                // Handles the enemies atack
                basicEnemyAttack();
                // Moves the enemy
                basicEnemyAiMovement();
                // Shows/Hides the sword 
                basicEnemySwordVisibility();
            }
            if (pcbStrongEnemy.Visible == true) {
                // Handles strong enemy attacks
                strongEnemyAttack();
                // Strong Enemy movement
                strongEnemyAiMovement();
                // Shows the strong enemy's sword
                strongEnemySwordVisibility();
            }
        }
        // Basic Enemy ai movement
        private void basicEnemyAiMovement() {
            // Checks if the Enemy has reached its left or right boundary
            if (pcbBasicEnemy.Left <= pcbPlatform3.Left + 30)
            {
                blnBasicEnemyMovingLeft = false;
            }
            else if (pcbBasicEnemy.Left >= pcbPlatform3.Left + 300) {
                blnBasicEnemyMovingLeft = true;
            }
            // Stops the enemy from glitching out when near the player
            if (pcbBasicEnemy.Bounds.IntersectsWith(pcbPlayer.Bounds)) {
                return;
            }
            // Switches the position of the sword depending on the direction the enemy is travelling
            if (blnBasicEnemyMovingLeft == false)
            {
                pcbBasicEnemySword.Left = pcbBasicEnemy.Right;
            }
            else {
                pcbBasicEnemySword.Left = pcbBasicEnemy.Left - pcbBasicEnemySword.Width;
            }
            // Idle Walk
            // Walks towards the left
            if (blnBasicEnemyMovingLeft == true) {
                pcbBasicEnemy.Left -= 3;
                pcbBasicEnemySword.Left -= 3;
            }
            // Walks towards the right
            if (blnBasicEnemyMovingLeft == false)
            {
                pcbBasicEnemy.Left += 3;
                pcbBasicEnemySword.Left += 3;
            }
        }
        // Strong Enemy ai movement
        private void strongEnemyAiMovement()
        {
            // Checks if the Enemy has reached its left or right boundary
            if (pcbStrongEnemy.Left <= pcbPlatform3.Right - 350)
            {
                blnStrongEnemyMovingLeft = false;
            }
            else if (pcbStrongEnemy.Left >= pcbPlatform3.Right - 50)
            {
                blnStrongEnemyMovingLeft = true;
            }
            // Stops the enemy from glitching out when near the player
            if (pcbStrongEnemy.Bounds.IntersectsWith(pcbPlayer.Bounds))
            {
                return;
            }
            // Switches the position of the sword depending on the direction the enemy is travelling
            if (blnStrongEnemyMovingLeft == false)
            {
                pcbStrongEnemySword.Left = pcbStrongEnemy.Right;
            }
            else
            {
                pcbStrongEnemySword.Left = pcbStrongEnemy.Left - pcbStrongEnemySword.Width;
            }
            // Idle Walk
            // Walks towards the left
            if (blnStrongEnemyMovingLeft == true)
            {
                pcbStrongEnemy.Left -= 3;
                pcbStrongEnemySword.Left -= 3;
            }
            // Walks towards the right
            if (blnStrongEnemyMovingLeft == false)
            {
                pcbStrongEnemy.Left += 3;
                pcbStrongEnemySword.Left += 3;
            }
        }
        // Attacks the player if they are within range
        private void basicEnemyAttack() {
            // Every 3 seconds the enemy can attack (but the enemy's sword stays up for 1 second so technically every 2 seconds the enemy can deal damage (150 ticks * 20 ms per tick))
            if (intEnemyAttackInterval < 150)
            {
                intEnemyAttackInterval++;
                blnBasicEnemyCanDamagePlayer = false;
            }
            else {
                blnBasicEnemyCanDamagePlayer = true;
            }
            // Checks if the player is on the same y level as the enemy (pcbPlayer.Top < pcbPlatform3.Top depends on range of the y level, additional conditions may be added depending on the situation)
            if (pcbPlayer.Top < pcbPlatform3.Top) {
                // Checks if the player is within the horizontal range of the enemy
                if (pcbPlayer.Left > pcbPlatform3.Left + 30 && pcbPlayer.Left <= pcbPlatform3.Left + 300)
                {
                    if (pcbPlayer.Left < pcbBasicEnemy.Left)
                    {
                        blnBasicEnemyMovingLeft = true;
                    }
                    if (pcbPlayer.Left > pcbBasicEnemy.Left)
                    {
                        blnBasicEnemyMovingLeft = false;
                    }
                }
                // deals damage if the enemy can attack the player
                if (blnBasicEnemyCanDamagePlayer == true)
                {
                    // Checks if the sword is within the range
                    if (pcbBasicEnemySword.Bounds.IntersectsWith(pcbPlayer.Bounds))
                    {
                        basicEnemyAttackDamage();
                    }
                }
            }
        }
        // strong enemy attacks
        private void strongEnemyAttack() {
            // Handles the strong enemy's attack interval (every 4 seconds)
            if (intStrongEnemyAttackInterval < 200)
            {
                intStrongEnemyAttackInterval++;
                blnStrongEnemyCanDamagePlayer = false;
            }
            else
            {
                blnStrongEnemyCanDamagePlayer = true;
            }
            // Checks if the player is on the same y level as the enemy
            if (pcbPlayer.Top < pcbPlatform3.Top)
            {
                // Checks if the player is within the horizontal range of the enemy
                if (pcbPlayer.Left > pcbPlatform3.Right - 350 && pcbPlayer.Left <= pcbPlatform3.Right - 50)
                {
                    if (pcbPlayer.Left < pcbStrongEnemy.Left)
                    {
                        blnStrongEnemyMovingLeft = true;
                    }
                    if (pcbPlayer.Left > pcbStrongEnemy.Left)
                    {
                        blnStrongEnemyMovingLeft = false;
                    }
                }
                // deals damage if the enemy can attack the player
                if (blnStrongEnemyCanDamagePlayer == true)
                {
                    // Checks if the sword is within the range
                    if (pcbStrongEnemySword.Bounds.IntersectsWith(pcbPlayer.Bounds))
                    {
                        strongEnemyAttackDamage();
                    }
                }
            }
        }
        // Deals damage to the player when the enemy has hit the player
        private void basicEnemyAttackDamage() {
            // Allows the enemy's sword to be visible
            intEnemySwordVisibilityCounter = 0;
            // Checks if the enemy sword is visible
            if (pcbBasicEnemySword.Visible == true)
            {
                // Lowers the players health
                intPlayerHealth -= 20;
                blnBasicEnemyCanDamagePlayer = false;
                // Resets the enemy attack interval 
                intEnemyAttackInterval = 0;
            }
        }
        // Deals damage to the player when the enemy has hit the player
        private void strongEnemyAttackDamage()
        {
            // Allows the enemy's sword to be visible
            intStrongEnemySwordVisibilityCounter = 0;
            // Checks if the enemy sword is visible
            if (pcbStrongEnemySword.Visible == true)
            {
                // Lowers the players health
                intPlayerHealth -= 45;
                blnStrongEnemyCanDamagePlayer = false;
                // Resets the enemy attack interval 
                intStrongEnemyAttackInterval = 0;
            }
        }
        // Handles the visibility of the enemy sword
        private void basicEnemySwordVisibility() {
            // allows the enemy's sword to be visible for 1 second
            if (intEnemySwordVisibilityCounter < 25) {
                pcbBasicEnemySword.Visible = true;
                intEnemySwordVisibilityCounter++;
            }
            else {
                pcbBasicEnemySword.Visible = false;
            }
        }
        // Handles the visibility of the strong enemy's sword
        private void strongEnemySwordVisibility() {
            // Handles the strong enemy's visiblity/timer
            if (intStrongEnemySwordVisibilityCounter < 25)
            {
                pcbStrongEnemySword.Visible = true;
                intStrongEnemySwordVisibilityCounter++;
            }
            else
            {
                pcbStrongEnemySword.Visible = false;
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
        private void swordPositionUpdate()
        {
            if (blnMovingLeft == true)
            {
                pcbSword.Left = pcbPlayer.Left - pcbSword.Width;
                pcbSword.Top = pcbPlayer.Top + 25;
            }
            else
            {
                pcbSword.Left = pcbPlayer.Right;
                pcbSword.Top = pcbPlayer.Top + 25;
            }
        }
        // Deals damage to enemy's using the player's sword attack
        private void swordDamage() {
            // Checks if the player's sword is visible and touching the basic enemy
            if (pcbSword.Visible == true ) {
                if (pcbSword.Bounds.IntersectsWith(pcbBasicEnemy.Bounds))
                {
                    // makes the enemy and their sword disappear
                    pcbBasicEnemy.Visible = false;
                    pcbBasicEnemySword.Visible = false;
                }
                if (pcbSword.Bounds.IntersectsWith(pcbStrongEnemy.Bounds)) {
                    // makes the strong enemy and their sword disappear
                    pcbStrongEnemy.Visible = false;
                    pcbStrongEnemySword.Visible = false;
                }
            } 
        }
        // Stops the jump (helps for stopping an active jump)
        private void stopJump()
        {
            intJumpPower = 14;
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
        }
        // Stops Sword Attack
        private void stopSwordAttack() {
            blnSwordAttack = false;
            intSwordAttackCounter = 51;
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
        private void updateScore()
        {
            this.lblScore.Text = "Score: " + intPlayerScore;
        }
        // Updates the Health text based on the health variable
        private void updateHealth()
        {
            this.lblPlayerHealth.Text = "Health: " + intPlayerHealth;
        }
        // Updates Main hand text
        private void mainHandUpdate()
        {
            this.lblMainHand.Text = lblMainHand.Text = "Main Hand:" + strMainHandItemName;
        }
        // Updates the inventory text
        private void inventoryUpdate()
        {
            this.lblPlayerInventory.Text = "Inventory: " + strInventoryNames[0] + " | " + strInventoryNames[1] + " | " + strInventoryNames[2] + " | " + strInventoryNames[3] + " | " + strInventoryNames[4];
        }
        // Opens the settings form
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings.intLevelOpened = 3;
            Settings settings = new Settings();
            settings.Show();
            this.Close();
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
        // Load Previous Inventory
        private void LoadInventory()
        {
            intMainHandItemValue = Settings.intMainHandValue;
            strMainHandItemName = Settings.strMainHandItemName;
            for (int i = 0; i < intInventoryValues.Length; i++)
            {
                intInventoryValues[i] = Settings.intInventoryValuesSaved[i];
                strInventoryNames[i] = Settings.strInventoryNamesSaved[i];
            }
        }
        // Runs every game tick to check if the player has 0 health
        private void playerHealthCheck() {
            // Checks if the player is dead
            if (intPlayerHealth <= 0) {
                // Resets the player to the Position at the beginning of the level
                pcbPlayer.Location = new Point(25, 701);
                // Makes the player stop moving after their position got reset
                blnMovingLeft = false;
                blnMovingRight = false;
                // Resets the health
                intPlayerHealth = 100;
                // Stops the sword attacking
                stopSwordAttack();
                // Decreases the score unless the score is already 0
                if (intPlayerScore > 0) {
                    intPlayerScore -= 5;
                }
            }
        }

        private void lblTutorialPt3Text_Click(object sender, EventArgs e)
        {
            if (intTutorialText == 0)
            {
                lblTutorialPt3Text.Text = "The Red Lava Depletes your health to 0 so don't touch\n it (Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 1)
            {
                lblTutorialPt3Text.Text = "The Spike takes away 10 hp and it makes you do a little jump when\n you touch it(Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 2)
            {
                lblTutorialPt3Text.Text = "Some Spikes are Upside down in that case, they Push you downwards\n (Click to Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 3)
            {
                lblTutorialPt3Text.Text = "The Boulder is a falling object that gets triggered once you are under it.\n it does 40 damage to you (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 4)
            {
                lblTutorialPt3Text.Text = "The Red Enemy is a basic enemy that does 20 damage per sword \nattack You can defeat him by using your sword(Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 5)
            {
                lblTutorialPt3Text.Text = "The Dark Cyan Enemy is a Strong Enemy that does 45 damage \n You can also defeat him by using your sword (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 6)
            {
                lblTutorialPt3Text.Text = "If your score goes down to 0 it won't go down anymore.\n (Click To Continue...)";
                intTutorialText++;
            }
            else if (intTutorialText == 7)
            {
                lblTutorialPt3Text.Text = "Every Time you die, you start back at the beginning, but you keep the\n progress you have made so far (Click To Close)";
                intTutorialText++;
            }
            else if (intTutorialText == 8)
            {
                lblTutorialPt3Text.Visible = false;
                lblTutorialPt3Text.Enabled = false;
            }
        }
    }
}

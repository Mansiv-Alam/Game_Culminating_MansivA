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
    public partial class MainGamePt2 : Form
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
        // Player UI
        int[] intInventoryValues = new int[5];
        string[] strInventoryNames = new string[5];
        int intPlayerHealth = 100;
        string strMainHandItemName = "";
        int intMainHandItemValue;
        bool blnSwordAttack = false;
        int intSwordAttackCounter = 0;
        int intPlayerScore = Settings.intPlayerScoreSaved;
        // Game Environment
        bool blnStrongEnemyCanDamagePlayer = true;
        int intStrongEnemyAttackInterval = 0;
        int intStrongEnemySwordVisibilityCounter = 26;
        bool blnStrongEnemyMovingLeft = false;
        public MainGamePt2()
        {
            InitializeComponent();
            LoadInventory();
        }
        // Detects when the player presses a key down
        private void MainGamePt2_KeyDown(object sender, KeyEventArgs e)
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
        // Detects when the player lifts a key up
        private void MainGamePt2_KeyUp(object sender, KeyEventArgs e)
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
        // Detects when the player wants to Attack with the sword using a click or use a health poition
        private void PlayerMouseClick(object sender, MouseEventArgs e)
        {
            // Heals the player
            if (intMainHandItemValue == 99)
            {
                intMainHandItemValue = 0;
                strMainHandItemName = "";
                intPlayerHealth += 40;
            }
            else
            {
                // Starts a sword attack
                blnSwordAttack = true;
                intSwordAttackCounter = 0;
            }
        }
        // Handles Basic Horizontal Movement
        private void horizontalPlayerMovement()
        {
            if (blnMovingLeft == false && blnMovingRight == false)
            {
                return;
            }
            if (blnMovingLeft == true)
            {
                this.pcbPlayer.Left -= intPlayerSpeed;
            }
            else if (blnMovingRight == true)
            {
                this.pcbPlayer.Left += intPlayerSpeed;
            }
        }
        // Smooth player movement, platform interaction with the player, and hitbox checks
        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            horizontalPlayerMovement();
            swordPositionUpdate();
            checkGrounded();
            extraScoreHitbox();
            wallHitbox();
            hitboxMovableBox();
            hitboxMovableBox2();
            // Environmental Hazards Hitboxes
            hitboxLava();
            hitboxSpike1();
            hitboxSpike2();
            // Locked doors hitboxes
            hitboxLockedLeverDoor();
            hitboxLockedBlueDoor();
            hitboxLockedRedDoor();
            hitboxLockedButtonDoor();
            hitboxNegativeLockedLeverDoor();
            // Platforms Hitboxes
            hitboxPlatform1();
            hitboxPlatform2();
            hitboxPlatform3();
            hitboxPlatform4();
            hitboxPlatform5();
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
        // Enemy ai, interaction with key game objects, and updating text
        private void tmrGameTick_Tick(object sender, EventArgs e)
        {
            // Updates the score text
            updateScore();
            // Updates the health text
            updateHealth();
            // Updates the inventory text
            inventoryUpdate();
            // Updates the main hand text
            mainHandUpdate();
            // Updates the health text
            playerHealthCheck();
            // Checks if the player has interacted with a key game object
            playerInteract();
            // Visiblity for the player's sword
            playerSwordVisibility();
            // Defeats the enemy if the player is attacking
            swordDamage();
            // Enemy ai
            EnemyAi();
            // Holdable button check 
            holdableButtonHitbox();
            // Boundaries for the next level
            if (pcbPlayer.Left > 1200)
            {
                // Resets score for the main game
                Settings.intPlayerScoreSaved = intPlayerScore + 10;
                SaveInventory();
                MainGamePt3 mainGamePt3 = new MainGamePt3();
                // Hides this form
                this.tmrGameTick.Enabled = false;
                this.tmrPlayerMovement.Enabled = false;
                this.Hide();
                // Shows/Opens the tutorial
                mainGamePt3.Show();
                this.Close();
            }
            // makes a boundary for the left wall
            else if (pcbPlayer.Left - 3 <= 0)
            {
                pcbPlayer.Left = 0;
                blnMovingLeft = false;
            }
        }
        // Calculates the jump velocity.
        private void calculateJumpVelocity()
        {
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
            // Stops an active jump if there is a dash
            stopJump();
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
            else
            {
                pcbPlayer.Top += intGravity;
            }
        }
        // Hitbox for platform 1
        private void hitboxPlatform1()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform1.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbPlatform1.Top && pcbPlayer.Bottom < pcbPlatform1.Top + 35)
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
        // Hitbox for platform 2
        private void hitboxPlatform2()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform2.Bounds))
            {

                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform2.Top && pcbPlayer.Bottom < pcbPlatform2.Top + 35))
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform2.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbPlatform2.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbPlatform2.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into by dashing the platform from the left and right side
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
        // Hitbox for platform 3
        private void hitboxPlatform3()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform3.Bounds))
            {

                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform3.Top && pcbPlayer.Bottom < pcbPlatform3.Top + 35))
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform3.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbPlatform3.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbPlatform3.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into by dashing the platform from the left and right side
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
        // Hitbox for platform 5
        private void hitboxPlatform5()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbPlatform5.Bounds))
            {

                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbPlatform5.Top && pcbPlayer.Bottom < pcbPlatform5.Top + 35))
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbPlatform5.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbPlatform5.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbPlatform5.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into by dashing the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform5.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform5.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform5.Top + 1 && pcbPlayer.Top < pcbPlatform5.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform5.Left && pcbPlayer.Left < pcbPlatform5.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbPlatform5.Left)
                        {
                            pcbPlayer.Left = pcbPlatform5.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbPlatform5.Right)
                        {
                            pcbPlayer.Left = pcbPlatform5.Right;
                        }
                    }
                }
            }
        }
        // Hitbox and physics for the Movable box
        private void hitboxMovableBox()
        {
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
                else if (blnMovingRight == true)
                {
                    pcbMovableBox.Left = pcbPlayer.Right;
                }
            }
            // Checks if the box is touching either side of the screen or the platform/floor it is suppose to be touching
            if (pcbMovableBox.Left < 0)
            {
                pcbMovableBox.Left = 0;
                pcbPlayer.Left = pcbMovableBox.Right;
            }
            if (pcbMovableBox.Bounds.IntersectsWith(pcbWall.Bounds))
            {
                pcbMovableBox.Left = pcbWall.Left - pcbMovableBox.Width;
                pcbPlayer.Left = pcbMovableBox.Left - pcbPlayer.Width;
            }
        }
        // Hitbox and physics for the second Movable box
        private void hitboxMovableBox2()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbMovableBox2.Bounds) && pcbMovableBox2.Visible == true)
            {
                //Checks if the player is above the box
                // also checks if the user has a key in their second slot (will change later)
                if ((intJumpVelocity <= 0 || intGravity > 0) && (pcbPlayer.Bottom > pcbMovableBox2.Top) && (pcbPlayer.Bottom < pcbMovableBox2.Top + 30))
                {
                    pcbPlayer.Top = pcbMovableBox2.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks which direction the box is being pushed and moves the box accordingly
                if (blnMovingLeft == true)
                {
                    pcbMovableBox2.Left = pcbPlayer.Left + 1 - pcbMovableBox2.Width;
                }
                else if (blnMovingRight == true)
                {
                    pcbMovableBox2.Left = pcbPlayer.Right;
                }
            }
            // Makes the small box fall
            if (pcbMovableBox2.Visible == true) {
                if (pcbMovableBox2.Bounds.IntersectsWith(pcbGround.Bounds) == false)
                {
                    pcbMovableBox2.Top += 8;
                }
                else {
                    pcbMovableBox2.Top = pcbGround.Top + 1 - pcbMovableBox2.Height;
                }
            }
            // Checks if the box is touching either side of the screen or the platform/floor it is suppose to be touching
            if (pcbMovableBox2.Left < 0)
            {
                pcbMovableBox2.Left = 0;
                pcbPlayer.Left = pcbMovableBox2.Right;
            }
            if (pcbMovableBox2.Bounds.IntersectsWith(pcbWall.Bounds))
            {
                pcbMovableBox2.Left = pcbWall.Left - pcbMovableBox2.Width;
                pcbPlayer.Left = pcbMovableBox2.Left - pcbPlayer.Width;
            }
        }
        // Hitbox for the holdable button 
        private void holdableButtonHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbHoldableButton.Bounds) || pcbMovableBox.Bounds.IntersectsWith(pcbHoldableButton.Bounds) || pcbMovableBox2.Bounds.IntersectsWith(pcbHoldableButton.Bounds))
            {
                pcbLockedButtonDoor.Visible = false;
                pcbHoldableButton.BackColor = Color.SpringGreen;
            }
            else
            {
                pcbLockedButtonDoor.Visible = true;
                pcbHoldableButton.BackColor = Color.DarkTurquoise;
            }
        }
        // hitbox for the Blue door when its locked
        private void hitboxLockedBlueDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedBlueDoor.Bounds))
            {
                // checks if the user has the cyan key in their main hand
                if (intMainHandItemValue != 3 && pcbLockedBlueDoor.Visible == true)
                {
                    pcbPlayer.Left = pcbLockedBlueDoor.Left - pcbPlayer.Width;
                }
                else
                {
                    deleteKey();
                }
            }
        }
        // hitbox for the Red door when its locked
        private void hitboxLockedRedDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedRedDoor.Bounds))
            {
                // checks if the user has the cyan key in their main hand
                if (intMainHandItemValue != 4 && pcbLockedRedDoor.Visible == true)
                {
                    pcbPlayer.Left = pcbLockedRedDoor.Left - pcbPlayer.Width;
                }
                else
                {
                    deleteKey();
                }
            }
        }
        // hitbox for the Lever door when to unlock or get blocked by it
        private void hitboxLockedLeverDoor()
        {
            // checks if the user has the cyan key in their main hand
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedLeverDoor.Bounds) && pcbLockedLeverDoor.Visible == true)
            {
                pcbPlayer.Left = pcbLockedLeverDoor.Left - pcbPlayer.Width;
            }
        }
        // hitbox for the Holdable Button door when to unlock or get blocked by it
        private void hitboxLockedButtonDoor()
        {
            // checks if the user has the cyan key in their main hand
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedButtonDoor.Bounds) && pcbLockedButtonDoor.Visible == true)
            {
                pcbPlayer.Left = pcbLockedButtonDoor.Left - pcbPlayer.Width;
            }
        }
        // hitbox for the Negative Lever door when to unlock or get blocked by it
        private void hitboxNegativeLockedLeverDoor()
        {
            // checks if the user has the cyan key in their main hand
            if (pcbPlayer.Bounds.IntersectsWith(pcbNegativeLockedLeverDoor.Bounds) && pcbNegativeLockedLeverDoor.Visible == true)
            {
                pcbPlayer.Left = pcbNegativeLockedLeverDoor.Left - pcbPlayer.Width;
            }
        }
        // Hitbox for the extra score
        private void extraScoreHitbox()
        {
            // Checks if the extra score is visible/on the screem
            if (pcbExtraScore.Visible == true && pcbPlayer.Bounds.IntersectsWith(pcbExtraScore.Bounds))
            {
                // increases score
                intPlayerScore += 5;
                // Makes the extra score disappear
                pcbExtraScore.Visible = false;
            }
        }
        // Hitbox for lava
        private void hitboxLava()
        {
            // Checks if the player has touched the lava but also gives the player a bit of leeway
            if (pcbPlayer.Bounds.IntersectsWith(pcbLava.Bounds) && pcbPlayer.Right > pcbLava.Left + 10 && pcbPlayer.Left < pcbLava.Right - 10)
            {
                intPlayerHealth = 0;
            }
        }
        // Hitbox for the Spike 1
        private void hitboxSpike1()
        {
            // Checks if the player has touched the spike with some margin 
            if (pcbPlayer.Bounds.IntersectsWith(pcbSpike.Bounds) && pcbPlayer.Right > pcbSpike.Left + 5 && pcbPlayer.Left < pcbSpike.Right - 5)
            {
                // Decreases health
                intPlayerHealth -= 10;
                // Changes the player's Height
                pcbPlayer.Top = pcbSpike.Top - 1 - pcbPlayer.Height;
                // Changes the jump variables to make a mini player jump
                intJumpPower = 8;
                intJumpPowerMin = -8;
                blnIsJumping = true;
            }
        }
        // Hitbox for the Spike 2
        private void hitboxSpike2()
        {
            // Checks if the player has touched the spike with some margin 
            if (pcbPlayer.Bounds.IntersectsWith(pcbSpike2.Bounds) && pcbPlayer.Right > pcbSpike2.Left + 5 && pcbPlayer.Left < pcbSpike2.Right - 5)
            {
                // Decreases health
                intPlayerHealth -= 10;
                // Changes the player's Height
                pcbPlayer.Top = pcbSpike2.Top - 1 - pcbPlayer.Height;
                // Changes the jump variables to make a mini player jump
                intJumpPower = 10;
                intJumpPowerMin = -10;
                blnIsJumping = true;
            }
        }
        // hitbox for the Bottom Right wall
        private void wallHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbWall.Bounds))
            {
                pcbPlayer.Left = pcbWall.Left - pcbPlayer.Width;
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
        // Checks if the player interacts with any game object
        private void playerInteract()
        {
            if (blnInteract == true)
            {
                if (pcbPlayer.Bounds.IntersectsWith(pcbBlueKey.Bounds) && pcbBlueKey.Visible == true)
                {
                    if (intInventoryValues[0] == 0)
                    {
                        pcbBlueKey.Visible = false;
                        intInventoryValues[0] = 3;
                        strInventoryNames[0] = "Blue Key";
                        blnInteract = false;
                    }
                    else
                    {
                        // Runs a for loop to find a slot where the game can put the item into
                        for (int i = 0; i < 5; i++)
                        {
                            if (intInventoryValues[i] == 0)
                            {
                                pcbBlueKey.Visible = false;
                                intInventoryValues[i] = 3;
                                strInventoryNames[i] = "Blue Key";
                                blnInteract = false;
                                break;
                            }
                        }
                    }
                }
                if (pcbPlayer.Bounds.IntersectsWith(pcbRedKey.Bounds) && pcbRedKey.Visible == true)
                {
                    if (intInventoryValues[1] == 0)
                    {
                        pcbRedKey.Visible = false;
                        intInventoryValues[1] = 4;
                        strInventoryNames[1] = "Red Key";
                        blnInteract = false;
                    }
                    else
                    {
                        // Runs a for loop to find a slot where the game can put the item into
                        for (int i = 0; i < 5; i++)
                        {
                            if (intInventoryValues[i] == 0)
                            {
                                pcbRedKey.Visible = false;
                                intInventoryValues[i] = 4;
                                strInventoryNames[i] = "Red Key";
                                blnInteract = false;
                                break;
                            }
                        }
                    }
                }
                if (pcbPlayer.Bounds.IntersectsWith(pcbHealthPotion.Bounds) && pcbHealthPotion.Visible == true)
                {
                    if (intInventoryValues[1] == 0)
                    {
                        pcbHealthPotion.Visible = false;
                        intInventoryValues[1] = 99;
                        strInventoryNames[1] = "Health Pot";
                        blnInteract = false;
                    }
                    else
                    {
                        // Runs a for loop to find a slot where the game can put the item into
                        for (int i = 0; i < 5; i++)
                        {
                            if (intInventoryValues[i] == 0)
                            {
                                pcbHealthPotion.Visible = false;
                                intInventoryValues[i] = 99;
                                strInventoryNames[i] = "Health Pot";
                                blnInteract = false;
                                break;
                            }
                        }
                    }
                }
                if (pcbPlayer.Bounds.IntersectsWith(pcbLever.Bounds))
                {
                    pcbMovableBox2.Visible = true;
                    if (pcbLever.BackColor == Color.SandyBrown)
                    {
                        pcbLever.BackColor = Color.DarkGreen;
                        pcbLockedLeverDoor.Visible = false;
                        pcbNegativeLockedLeverDoor.Visible = true;
                        blnInteract = false;
                    }
                    else
                    {
                        pcbLockedLeverDoor.Visible = true;
                        pcbNegativeLockedLeverDoor.Visible = false;
                        pcbLever.BackColor = Color.SandyBrown;
                        blnInteract = false;
                    }
                }
                else
                {
                    blnInteract = false;
                }
            }
        }
        // Handles the  Enemy Ai
        private void EnemyAi()
        {
            if (pcbStrongEnemy.Visible == true)
            {
                // Handles strong enemy attacks
                strongEnemyAttack();
                // Strong Enemy movement
                strongEnemyAiMovement();
                // Shows the strong enemy's sword
                strongEnemySwordVisibility();
            }
        }
        // Strong Enemy ai movement
        private void strongEnemyAiMovement()
        {
            // Checks if the Enemy has reached its left or right boundary
            if (pcbStrongEnemy.Left <= pcbPlatform5.Left + 100)
            {
                blnStrongEnemyMovingLeft = false;
            }
            else if (pcbStrongEnemy.Left >= pcbPlatform5.Right - pcbStrongEnemy.Width)
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
        // strong enemy attacks
        private void strongEnemyAttack()
        {
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
                if (pcbPlayer.Left > pcbPlatform5.Left + 60 && pcbPlayer.Left <= pcbPlatform5.Right - pcbStrongEnemy.Width)
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
        // Handles the visibility of the strong enemy's sword
        private void strongEnemySwordVisibility()
        {
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
                    blnSwordAttack = false;
                    pcbSword.Visible = false;
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
        private void swordDamage()
        {
            // Checks if the player's sword is visible and touching the basic enemy
            if (pcbSword.Visible == true)
            {
                if (pcbSword.Bounds.IntersectsWith(pcbStrongEnemy.Bounds))
                {
                    // makes the enemy and their sword disappear
                    pcbStrongEnemy.Visible = false;
                    pcbStrongEnemySword.Visible = false;
                }
            }
        }
        // Stops Sword Attack
        private void stopSwordAttack()
        {
            blnSwordAttack = false;
            intSwordAttackCounter = 51;
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
        // Changes variables back to as if the player was grounded
        private void isGrounded()
        {
            // Makes the grounded variable true 
            blnGrounded = true;
            // resets gravity and the dash counter to 0 because the player is on the ground
            intGravity = 0;
            intDashCounter = 0;
        }
        // Gets rid of the key after using it
        private void deleteKey()
        {
            if (intMainHandItemValue == 3)
            {
                pcbLockedBlueDoor.Visible = false;
                intMainHandItemValue = 0;
                strMainHandItemName = "";
            }
            else if(intMainHandItemValue == 4)
            {
                pcbLockedRedDoor.Visible = false;
                intMainHandItemValue = 0;
                strMainHandItemName = "";
            }
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
        // Runs every game tick to check if the player has 0 health
        private void playerHealthCheck()
        {
            // Checks if the player is dead and resets the player to the Position at the beginning of the level, the player's health, and decreases the players score
            if (intPlayerHealth <= 0)
            {
                pcbPlayer.Location = new Point(25, 722);
                blnMovingLeft = false;
                blnMovingRight = false;
                intPlayerHealth = 100;
                // Stops the sword attacking
                stopSwordAttack();
                if (intPlayerScore > 0)
                {
                    intPlayerScore -= 5;
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
        // Opens the settings form
        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            // Changes the int level opened in the settings form so that we can reopen this level
            Settings.intLevelOpened = 5;
            Settings settings = new Settings();
            settings.Show();
            // Closes this form
            this.Close();
        }
    }
}
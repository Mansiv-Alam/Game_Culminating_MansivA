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
    public partial class MainGamePt3 : Form
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
        bool blnBasicEnemyMovingLeft = true;
        int intEnemySwordVisibilityCounter = 26;
        int intEnemyAttackInterval = 0;
        bool blnBasicEnemyCanDamagePlayer = true;
        public MainGamePt3()
        {
            InitializeComponent();
            // Renders another screen not on the screen and then changes the rendered screen not on the screen onto the screen
            // helps with smoother animation and less lag (increases ram usage)
            this.DoubleBuffered = true;
            // Makes the background the ruins bg
            this.BackgroundImage = Resource1.RuinsBg;
            // Adds all the images for the game
            // Images for all platforms and stretchs out them so they look more natural
            pcbBottomLeftPlatform.BackgroundImage = Resource1.LightStonePlatformLong;
            pcbBottomLeftPlatform.BackgroundImageLayout = ImageLayout.None;
            pcbBottomRightPlatform.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbBottomRightPlatform.BackgroundImageLayout = ImageLayout.Stretch;
            pcbTopPlatform.BackgroundImage = Resource1.LightStonePlatformLong;
            pcbTopPlatform.BackgroundImageLayout = ImageLayout.None;
            pcbPlatform1.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbPlatform1.BackgroundImageLayout = ImageLayout.Stretch;
            pcbPlatform2.BackgroundImage = Resource1.LightStonePlatformLong;
            pcbPlatform2.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLeftColumnWall.BackgroundImage = Resource1.LightStoneWall;
            pcbLeftColumnWall.BackgroundImageLayout = ImageLayout.Stretch;
            pcbRightColumnWall.BackgroundImage = Resource1.LightStoneWall;
            pcbRightColumnWall.BackgroundImageLayout = ImageLayout.Stretch;
            pcbTopWall.BackgroundImage = Resource1.LightStoneWall;
            pcbTopWall.BackgroundImageLayout = ImageLayout.Stretch;
            pcbBottomWall.BackgroundImage = Resource1.LightStoneWall;
            pcbBottomWall.BackgroundImageLayout = ImageLayout.Stretch;
            pcbStep1.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbStep1.BackgroundImageLayout = ImageLayout.Stretch;
            pcbStep2.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbStep2.BackgroundImageLayout = ImageLayout.Stretch;
            pcbStep3.BackgroundImage = Resource1.LightStonePlatformImproved;
            pcbStep3.BackgroundImageLayout = ImageLayout.Stretch;
            // Score, Keys, and Lever pngs
            pcbExtraScore.BackgroundImage = Resource1.ExtraScore;
            pcbExtraScore.BackgroundImageLayout = ImageLayout.Stretch;
            pcbExtraScore2.BackgroundImage = Resource1.ExtraScore;
            pcbExtraScore2.BackgroundImageLayout = ImageLayout.Stretch;
            pcbCrimsonKey.BackgroundImage = Resource1.RedKey;
            pcbCrimsonKey.BackgroundImageLayout = ImageLayout.Stretch;
            // Spike, Lava, Falling Trap Pngs
            pcbSpike.BackgroundImage = Resource1.Spike;
            pcbSpike.BackgroundImageLayout = ImageLayout.Stretch;
            pcbSpike2.BackgroundImage = Resource1.Spike;
            pcbSpike2.BackgroundImageLayout = ImageLayout.Stretch;
            pcbSpike3.BackgroundImage = Resource1.Spike;
            pcbSpike3.BackgroundImageLayout = ImageLayout.Stretch;
            pcbSpike4.BackgroundImage = Resource1.Spike;
            pcbSpike4.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLava.BackgroundImage = Resource1.Lava;
            pcbLava.BackgroundImageLayout = ImageLayout.Stretch;
            // Health potion
            pcbHealthPotion.BackgroundImage = Resource1.HealthPotion;
            pcbHealthPotion.BackgroundImageLayout = ImageLayout.Stretch;
            LoadInventory();
        }
        // Detects when the player presses a key down
        private void MainGamePt3_KeyDown(object sender, KeyEventArgs e)
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
        private void MainGamePt3_KeyUp(object sender, KeyEventArgs e)
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
        // Handles vertical movement if the player is above the screen
        private void verticalBoundary() {
            if (pcbPlayer.Top < 0) {
                stopJump();
                pcbPlayer.Top = 0;
            }
        }
        // Smooth player movement, platform interaction with the player, and hitbox checks
        private void tmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            horizontalPlayerMovement();
            verticalBoundary();
            swordPositionUpdate();
            checkGrounded();
            extraScoreHitboxes();
            // Hitboxes for platforms
            hitboxLeftPlatformFloor();
            hitboxRightPlatformFloor();
            hitboxLeftWallColumn();
            hitboxRightWallColumn();
            topWallHitbox();
            bottomWallHitbox();
            hitboxTopPlatform();
            hitboxPlatform1();
            hitboxPlatform2();
            // hitbox for Locked doors
            hitboxLockedLeverDoor();
            hitboxLockedLeverDoor2();
            hitboxLockedKeydoor();
            // hitboxes for the steps
            hitboxStep1();
            hitboxStep2();
            hitboxStep3();
            // Environmental Hazards Hitboxes
            hitboxLava();
            hitboxSpikes();

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
            // Boundaries for the next level
            if (pcbPlayer.Left > 1200)
            {
                // Resets score for the main game
                Settings.intPlayerScoreSaved = intPlayerScore + 10;
                SaveInventory();
                MainGamePt4 mainGamePt4 = new MainGamePt4();
                // Hides this form
                this.tmrGameTick.Enabled = false;
                this.tmrPlayerMovement.Enabled = false;
                this.Hide();
                // Shows/Opens the tutorial
                mainGamePt4.Show();
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
        // Changes variables back to as if the player was grounded
        private void isGrounded()
        {
            // Makes the grounded variable true 
            blnGrounded = true;
            // resets gravity and the dash counter to 0 because the player is on the ground
            intGravity = 0;
            intDashCounter = 0;
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
        // Hitbox for Bottom Left Floor
        private void hitboxLeftPlatformFloor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbBottomLeftPlatform.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbBottomLeftPlatform.Top && pcbPlayer.Bottom < pcbBottomLeftPlatform.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbBottomLeftPlatform.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbBottomLeftPlatform.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbBottomLeftPlatform.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
            }
        }
        // Hitbox for Bottom Right Floor
        private void hitboxRightPlatformFloor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbBottomRightPlatform.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbBottomRightPlatform.Top && pcbPlayer.Bottom < pcbBottomRightPlatform.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbBottomRightPlatform.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbBottomRightPlatform.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbBottomRightPlatform.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
            }
        }
        // Hitbox for left wall column
        private void hitboxLeftWallColumn()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLeftColumnWall.Bounds))
            {
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbLeftColumnWall.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbLeftColumnWall.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbLeftColumnWall.Top + 1 && pcbPlayer.Top < pcbLeftColumnWall.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbLeftColumnWall.Left && pcbPlayer.Left < pcbLeftColumnWall.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbLeftColumnWall.Left)
                        {
                            pcbPlayer.Left = pcbLeftColumnWall.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbLeftColumnWall.Right)
                        {
                            pcbPlayer.Left = pcbLeftColumnWall.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for Right wall column
        private void hitboxRightWallColumn()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbRightColumnWall.Bounds))
            {
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom < pcbRightColumnWall.Top + 30)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbRightColumnWall.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbRightColumnWall.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbRightColumnWall.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbRightColumnWall.Top + 1 && pcbPlayer.Top < pcbRightColumnWall.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbRightColumnWall.Left && pcbPlayer.Left < pcbRightColumnWall.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbRightColumnWall.Left)
                        {
                            pcbPlayer.Left = pcbRightColumnWall.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbRightColumnWall.Right)
                        {
                            pcbPlayer.Left = pcbRightColumnWall.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for the top platform
        private void hitboxTopPlatform()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbTopPlatform.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbTopPlatform.Top && pcbPlayer.Bottom < pcbTopPlatform.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbTopPlatform.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbTopPlatform.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbTopPlatform.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbTopPlatform.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbStep1.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbTopPlatform.Top + 1 && pcbPlayer.Top < pcbTopPlatform.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbTopPlatform.Left && pcbPlayer.Left < pcbTopPlatform.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbTopPlatform.Left)
                        {
                            pcbPlayer.Left = pcbTopPlatform.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbTopPlatform.Right)
                        {
                            pcbPlayer.Left = pcbTopPlatform.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for step 1
        private void hitboxStep1()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbStep1.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbStep1.Top && pcbPlayer.Bottom < pcbStep1.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbStep1.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbStep1.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbStep1.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbStep1.Right; }
                    // Right dash
                    else if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbStep1.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbStep1.Top + 1 && pcbPlayer.Top < pcbStep1.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbStep1.Left && pcbPlayer.Left < pcbStep1.Right)
                    {
                        // Checks if the left side is Outside the platform
                        if (pcbPlayer.Left < pcbStep1.Left)
                        {
                            pcbPlayer.Left = pcbStep1.Left - pcbPlayer.Width;
                        }
                        // Checks if the right side is Outside the platform
                        else if (pcbPlayer.Right > pcbStep1.Right)
                        {
                            pcbPlayer.Left = pcbStep1.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for step 2
        private void hitboxStep2()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbStep2.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbStep2.Top && pcbPlayer.Bottom < pcbStep2.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbStep2.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbStep2.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbStep2.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Left dash only because right dash isnt needed
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbStep2.Right; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbStep1.Top + 1 && pcbPlayer.Top < pcbStep1.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbStep1.Left && pcbPlayer.Left < pcbStep1.Right)
                    {
                        // Only Checks if the right side is Outside the platform because the left side isnt needed
                        if (pcbPlayer.Right > pcbStep1.Right)
                        {
                            pcbPlayer.Left = pcbStep1.Right;
                        }
                    }
                }
            }
        }
        // Hitbox for step 3
        private void hitboxStep3()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbStep3.Bounds))
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbStep3.Top && pcbPlayer.Bottom < pcbStep3.Top + 35)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbStep3.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
                // Checks if the player's head is below a the y position of the hitbox
                if (pcbPlayer.Top > pcbStep3.Location.Y)
                {
                    // Makes the player's position right under the platform
                    pcbPlayer.Top = pcbStep3.Bottom + 1;
                    // stops the jump
                    stopJump();
                    return;
                }
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Right dash only because left side isnt needed
                    if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbStep1.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbStep1.Top + 1 && pcbPlayer.Top < pcbStep1.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbStep1.Left && pcbPlayer.Left < pcbStep1.Right)
                    {
                        // only Checks if the left side is Outside the platform becuse right side isnt needed
                        if (pcbPlayer.Left < pcbStep1.Left)
                        {
                            pcbPlayer.Left = pcbStep1.Left - pcbPlayer.Width;
                        }
                    }
                }
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
                    // Left dash only because right dash isnt needed
                    if (blnMovingLeft == true) { stopDash(); pcbPlayer.Left = pcbPlatform1.Right; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform1.Top + 1 && pcbPlayer.Top < pcbPlatform1.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform1.Left && pcbPlayer.Left < pcbPlatform1.Right)
                    {
                        // Only Checks if the right side is Outside the platform because the left side isnt needed
                        if (pcbPlayer.Right > pcbPlatform1.Right)
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
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0) && pcbPlayer.Bottom > pcbPlatform2.Top && pcbPlayer.Bottom < pcbPlatform2.Top + 35)
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
                // Stops a dash from clipping into the platform from the left and right side
                if (blnIsDashing == true && blnGrounded == false)
                {
                    // Right dash only because left side isnt needed
                    if (blnMovingRight == true) { stopDash(); pcbPlayer.Left = pcbPlatform2.Left - pcbPlayer.Width; }
                }
                // Handles Horizontal Collision (First checks if the players is both above and below the platform)
                if (pcbPlayer.Bottom > pcbPlatform2.Top + 1 && pcbPlayer.Top < pcbPlatform2.Bottom)
                {
                    // Checks which part is inside of the platform (right side or lefts)
                    if (pcbPlayer.Right > pcbPlatform2.Left && pcbPlayer.Left < pcbPlatform2.Right)
                    {
                        // only Checks if the left side is Outside the platform becuse right side isnt needed
                        if (pcbPlayer.Left < pcbPlatform2.Left)
                        {
                            pcbPlayer.Left = pcbPlatform2.Left - pcbPlayer.Width;
                        }
                    }
                }
            }
        }
        // hitbox for the Bottom Right wall
        private void topWallHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbTopWall.Bounds))
            {
                pcbPlayer.Left = pcbTopWall.Left - pcbPlayer.Width;
            }
        }
        // hitbox for the Top Right wall
        private void bottomWallHitbox()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbBottomWall.Bounds))
            {
                pcbPlayer.Left = pcbBottomWall.Left - pcbPlayer.Width;
            }
        }
        // Hitboxes for both Extra Scores
        private void extraScoreHitboxes()
        {
            // Checks if the extra score is visible/on the screem
            if (pcbExtraScore.Visible == true && pcbPlayer.Bounds.IntersectsWith(pcbExtraScore.Bounds))
            {
                // increases score
                intPlayerScore += 5;
                // Makes the extra score disappear
                pcbExtraScore.Visible = false;
            }
            // Checks if the extra score is visible/on the screem
            if (pcbExtraScore2.Visible == true && pcbPlayer.Bounds.IntersectsWith(pcbExtraScore2.Bounds))
            {
                // increases score
                intPlayerScore += 5;
                // Makes the extra score disappear
                pcbExtraScore2.Visible = false;
            }
        }
        // Hitbox for locked lever door 1
        private void hitboxLockedLeverDoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedLeverDoor.Bounds) && pcbLockedLeverDoor.Visible == true)
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if (intJumpVelocity <= 0 || intGravity > 0)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbLockedLeverDoor.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
            }
        }
        // Hitbox for locked lever door 2
        private void hitboxLockedLeverDoor2()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedLeverDoor2.Bounds) && pcbLockedLeverDoor2.Visible == true)
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if (intJumpVelocity <= 0 || intGravity > 0)
                {
                    // Location of the platform and the player height
                    pcbPlayer.Top = pcbLockedLeverDoor2.Location.Y + 1 - pcbPlayer.Height;
                    isGrounded();
                    return;
                }
            }
        }
        // Hitbox for locked Key door
        private void hitboxLockedKeydoor()
        {
            if (pcbPlayer.Bounds.IntersectsWith(pcbLockedCrimsonDoor.Bounds) && pcbLockedCrimsonDoor.Visible == true)
            {
                // Checks if the player is moving or falling down, and the player's feet is below/touching the platform and if the player's feet is above a certain point to stop clipping onto the top of the platform\
                if ((intJumpVelocity <= 0 || intGravity > 0))
                {
                    // checks if the user has the cyan key in their main hand
                    if (intMainHandItemValue != 5 && pcbLockedCrimsonDoor.Visible == true)
                    {
                        // Location of the platform and the player height
                        pcbPlayer.Top = pcbLockedCrimsonDoor.Location.Y + 1 - pcbPlayer.Height;
                        isGrounded();
                        return;
                    }
                    else
                    {
                        deleteKey();
                    }
                }
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
        // Hitboxes for all spikes
        private void hitboxSpikes()
        {
            // Checks if the player has touched the spike with some margin 
            if ((pcbPlayer.Bounds.IntersectsWith(pcbSpike.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbSpike2.Bounds)) && pcbPlayer.Right > pcbSpike2.Left + 5 && pcbPlayer.Left < pcbSpike.Right - 5)
            {
                // Decreases health
                intPlayerHealth -= 10;
                // Changes the player's Height
                pcbPlayer.Top = pcbSpike.Top - 1 - pcbPlayer.Height;
                // Changes the jump variables to make a mini player jump
                intJumpPower = 4;
                intJumpPowerMin = -4;
                blnIsJumping = true;
            }
            else if ((pcbPlayer.Bounds.IntersectsWith(pcbSpike3.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbSpike4.Bounds)) && pcbPlayer.Right > pcbSpike4.Left + 5 && pcbPlayer.Left < pcbSpike3.Right - 5) {
                // Decreases health
                intPlayerHealth -= 10;
                // Changes the player's Height
                pcbPlayer.Top = pcbSpike.Top - 1 - pcbPlayer.Height;
                // Changes the jump variables to make a mini player jump
                intJumpPower = 4;
                intJumpPowerMin = -4;
                blnIsJumping = true;
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
        // Enemy Ai
        private void EnemyAi()
        {
            if (pcbBasicEnemy.Visible == true)
            {
                // Handles strong enemy attacks
                basicEnemyAttack();
                // Strong Enemy movement
                basicEnemyAiMovement();
                // Shows the strong enemy's sword
                basicEnemySwordVisibility();
            }
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
            if (pcbStrongEnemy.Left <= pcbBottomLeftPlatform.Left)
            {
                blnStrongEnemyMovingLeft = false;
            }
            else if (pcbStrongEnemy.Left >= pcbBottomLeftPlatform.Left + 200)
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
            if (pcbPlayer.Top < pcbBottomLeftPlatform.Top && pcbPlayer.Top > pcbPlatform1.Bottom)
            {
                // Checks if the player is within the horizontal range of the enemy
                if (pcbPlayer.Left > pcbBottomLeftPlatform.Left && pcbPlayer.Left <= pcbBottomLeftPlatform.Left + 200)
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
        // Basic Enemy ai movement
        private void basicEnemyAiMovement()
        {
            // Checks if the Enemy has reached its left or right boundary
            if (pcbBasicEnemy.Left <= pcbPlatform2.Left)
            {
                blnBasicEnemyMovingLeft = false;
            }
            else if (pcbBasicEnemy.Left >= pcbPlatform2.Right - 70)
            {
                blnBasicEnemyMovingLeft = true;
            }
            // Stops the enemy from glitching out when near the player
            if (pcbBasicEnemy.Bounds.IntersectsWith(pcbPlayer.Bounds))
            {
                return;
            }
            // Switches the position of the sword depending on the direction the enemy is travelling
            if (blnBasicEnemyMovingLeft == false)
            {
                pcbBasicEnemySword.Left = pcbBasicEnemy.Right;
            }
            else
            {
                pcbBasicEnemySword.Left = pcbBasicEnemy.Left - pcbBasicEnemySword.Width;
            }
            // Idle Walk
            // Walks towards the left
            if (blnBasicEnemyMovingLeft == true)
            {
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
        // Attacks the player if they are within range
        private void basicEnemyAttack()
        {
            // Every 3 seconds the enemy can attack (but the enemy's sword stays up for 1 second so technically every 2 seconds the enemy can deal damage (150 ticks * 20 ms per tick))
            if (intEnemyAttackInterval < 150)
            {
                intEnemyAttackInterval++;
                blnBasicEnemyCanDamagePlayer = false;
            }
            else
            {
                blnBasicEnemyCanDamagePlayer = true;
            }
            // Checks if the player is on the same y level as the enemy 
            if (pcbPlayer.Top > pcbTopPlatform.Top && pcbPlayer.Top < pcbPlatform2.Top)
            {
                // Checks if the player is within the horizontal range of the enemy
                if (pcbPlayer.Left > pcbPlatform2.Right - 70 && pcbPlayer.Left <= pcbPlatform2.Left)
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
        // Deals damage to the player when the enemy has hit the player
        private void basicEnemyAttackDamage()
        {
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
        // Handles the visibility of the enemy sword
        private void basicEnemySwordVisibility()
        {
            // allows the enemy's sword to be visible for 1 second
            if (intEnemySwordVisibilityCounter < 25)
            {
                pcbBasicEnemySword.Visible = true;
                intEnemySwordVisibilityCounter++;
            }
            else
            {
                pcbBasicEnemySword.Visible = false;
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
                if (pcbSword.Bounds.IntersectsWith(pcbBasicEnemy.Bounds))
                {
                    // makes the enemy and their sword disappear
                    pcbBasicEnemy.Visible = false;
                    pcbBasicEnemySword.Visible = false;
                }
            }
        }
        // Checks if the player interacts with any game object
        private void playerInteract()
        {
            if (blnInteract == true)
            {
                if (pcbPlayer.Bounds.IntersectsWith(pcbLever.Bounds))
                {
                    pcbLever.BackColor = Color.DarkGreen;
                    pcbLockedLeverDoor.Visible = false;
                    blnInteract = false;
                }
                else if (pcbPlayer.Bounds.IntersectsWith(pcbLever2.Bounds)) {
                    pcbLever2.BackColor = Color.DarkGreen;
                    pcbLockedLeverDoor2.Visible = false;
                    blnInteract = false;
                }
                if (pcbPlayer.Bounds.IntersectsWith(pcbCrimsonKey.Bounds) && pcbCrimsonKey.Visible == true)
                {
                    if (intInventoryValues[0] == 0)
                    {
                        pcbCrimsonKey.Visible = false;
                        intInventoryValues[0] = 5;
                        strInventoryNames[0] = "Crimson Key";
                        blnInteract = false;
                    }
                    else
                    {
                        // Runs a for loop to find a slot where the game can put the item into
                        for (int i = 0; i < 5; i++)
                        {
                            if (intInventoryValues[i] == 0)
                            {
                                pcbCrimsonKey.Visible = false;
                                intInventoryValues[i] = 5;
                                strInventoryNames[i] = "Crimson Key";
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
            }
            else { blnInteract = false; }
        }
        // Stops Sword Attack
        private void stopSwordAttack()
        {
            pcbSword.Visible = false;
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
        // Gets rid of the key after using it
        private void deleteKey()
        {
            if (intMainHandItemValue == 5)
            {
                pcbLockedCrimsonDoor.Visible = false;
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
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Changes the int level opened in the settings form so that we can reopen this level
            Settings.intLevelOpened = 6;
            Settings settings = new Settings();
            settings.Show();
            // Closes this form
            this.Close();
        }
    }
}

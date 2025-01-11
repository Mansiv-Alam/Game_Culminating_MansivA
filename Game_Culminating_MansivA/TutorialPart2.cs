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
        bool blnMovingLeft = false;
        bool blnMovingRight = false;
        bool blnIsJumping = false;
        int intPlayerSpeed = 8;
        int intJumpPower = 18;
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
    }
}

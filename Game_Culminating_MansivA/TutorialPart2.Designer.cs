﻿namespace Game_Culminating_MansivA
{
    partial class TutorialPart2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.lblTutorial1Text = new System.Windows.Forms.Label();
            this.lblTutorialPart2Text = new System.Windows.Forms.Label();
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform2 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform3 = new System.Windows.Forms.PictureBox();
            this.pcbWall = new System.Windows.Forms.PictureBox();
            this.pcbLockedCyanDoor = new System.Windows.Forms.PictureBox();
            this.pcbCyanKey = new System.Windows.Forms.PictureBox();
            this.lblPlayerInventory = new System.Windows.Forms.Label();
            this.pcbLever = new System.Windows.Forms.PictureBox();
            this.pcbLockedLeverDoor = new System.Windows.Forms.PictureBox();
            this.pcbMovableBox = new System.Windows.Forms.PictureBox();
            this.pcbHoldableButton = new System.Windows.Forms.PictureBox();
            this.pcbLockedButtonDoor = new System.Windows.Forms.PictureBox();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblMainHand = new System.Windows.Forms.Label();
            this.pcbSword = new System.Windows.Forms.PictureBox();
            this.pcbHealthPotion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedLeverDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMovableBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoldableButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedButtonDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHealthPotion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1097, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 75);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 722);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(80, 110);
            this.pcbPlayer.TabIndex = 2;
            this.pcbPlayer.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 5;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // lblTutorial1Text
            // 
            this.lblTutorial1Text.AutoSize = true;
            this.lblTutorial1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorial1Text.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblTutorial1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1Text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTutorial1Text.Location = new System.Drawing.Point(225, 97);
            this.lblTutorial1Text.Name = "lblTutorial1Text";
            this.lblTutorial1Text.Size = new System.Drawing.Size(0, 55);
            this.lblTutorial1Text.TabIndex = 3;
            // 
            // lblTutorialPart2Text
            // 
            this.lblTutorialPart2Text.AutoSize = true;
            this.lblTutorialPart2Text.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTutorialPart2Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTutorialPart2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorialPart2Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorialPart2Text.Location = new System.Drawing.Point(202, 12);
            this.lblTutorialPart2Text.Name = "lblTutorialPart2Text";
            this.lblTutorialPart2Text.Size = new System.Drawing.Size(885, 33);
            this.lblTutorialPart2Text.TabIndex = 4;
            this.lblTutorialPart2Text.Text = "This is where you will learn about Key Objects (Click to Continue...)";
            this.lblTutorialPart2Text.Click += new System.EventHandler(this.lblTutorialPart2Text_Click);
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Enabled = true;
            this.tmrGameTick.Interval = 10;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(0, 831);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(1185, 80);
            this.pcbGround.TabIndex = 6;
            this.pcbGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 39);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score:";
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(152, 615);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(163, 50);
            this.pcbPlatform1.TabIndex = 12;
            this.pcbPlatform1.TabStop = false;
            // 
            // pcbPlatform2
            // 
            this.pcbPlatform2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform2.Location = new System.Drawing.Point(422, 485);
            this.pcbPlatform2.Name = "pcbPlatform2";
            this.pcbPlatform2.Size = new System.Drawing.Size(166, 50);
            this.pcbPlatform2.TabIndex = 13;
            this.pcbPlatform2.TabStop = false;
            // 
            // pcbPlatform3
            // 
            this.pcbPlatform3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform3.Location = new System.Drawing.Point(622, 407);
            this.pcbPlatform3.Name = "pcbPlatform3";
            this.pcbPlatform3.Size = new System.Drawing.Size(562, 50);
            this.pcbPlatform3.TabIndex = 14;
            this.pcbPlatform3.TabStop = false;
            // 
            // pcbWall
            // 
            this.pcbWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbWall.Location = new System.Drawing.Point(1134, 454);
            this.pcbWall.Name = "pcbWall";
            this.pcbWall.Size = new System.Drawing.Size(50, 381);
            this.pcbWall.TabIndex = 15;
            this.pcbWall.TabStop = false;
            // 
            // pcbLockedCyanDoor
            // 
            this.pcbLockedCyanDoor.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbLockedCyanDoor.Location = new System.Drawing.Point(888, 185);
            this.pcbLockedCyanDoor.Name = "pcbLockedCyanDoor";
            this.pcbLockedCyanDoor.Size = new System.Drawing.Size(58, 226);
            this.pcbLockedCyanDoor.TabIndex = 32;
            this.pcbLockedCyanDoor.TabStop = false;
            // 
            // pcbCyanKey
            // 
            this.pcbCyanKey.BackColor = System.Drawing.Color.Transparent;
            this.pcbCyanKey.Location = new System.Drawing.Point(478, 400);
            this.pcbCyanKey.Name = "pcbCyanKey";
            this.pcbCyanKey.Size = new System.Drawing.Size(58, 57);
            this.pcbCyanKey.TabIndex = 34;
            this.pcbCyanKey.TabStop = false;
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventory.Location = new System.Drawing.Point(588, 854);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(106, 25);
            this.lblPlayerInventory.TabIndex = 35;
            this.lblPlayerInventory.Text = "Inventory:";
            // 
            // pcbLever
            // 
            this.pcbLever.BackColor = System.Drawing.Color.Transparent;
            this.pcbLever.Location = new System.Drawing.Point(208, 561);
            this.pcbLever.Name = "pcbLever";
            this.pcbLever.Size = new System.Drawing.Size(58, 57);
            this.pcbLever.TabIndex = 36;
            this.pcbLever.TabStop = false;
            // 
            // pcbLockedLeverDoor
            // 
            this.pcbLockedLeverDoor.BackColor = System.Drawing.Color.SandyBrown;
            this.pcbLockedLeverDoor.Location = new System.Drawing.Point(745, 185);
            this.pcbLockedLeverDoor.Name = "pcbLockedLeverDoor";
            this.pcbLockedLeverDoor.Size = new System.Drawing.Size(58, 226);
            this.pcbLockedLeverDoor.TabIndex = 37;
            this.pcbLockedLeverDoor.TabStop = false;
            // 
            // pcbMovableBox
            // 
            this.pcbMovableBox.BackColor = System.Drawing.Color.PeachPuff;
            this.pcbMovableBox.Location = new System.Drawing.Point(574, 733);
            this.pcbMovableBox.Name = "pcbMovableBox";
            this.pcbMovableBox.Size = new System.Drawing.Size(103, 102);
            this.pcbMovableBox.TabIndex = 38;
            this.pcbMovableBox.TabStop = false;
            // 
            // pcbHoldableButton
            // 
            this.pcbHoldableButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pcbHoldableButton.Location = new System.Drawing.Point(944, 746);
            this.pcbHoldableButton.Name = "pcbHoldableButton";
            this.pcbHoldableButton.Size = new System.Drawing.Size(58, 57);
            this.pcbHoldableButton.TabIndex = 39;
            this.pcbHoldableButton.TabStop = false;
            // 
            // pcbLockedButtonDoor
            // 
            this.pcbLockedButtonDoor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pcbLockedButtonDoor.Location = new System.Drawing.Point(1018, 185);
            this.pcbLockedButtonDoor.Name = "pcbLockedButtonDoor";
            this.pcbLockedButtonDoor.Size = new System.Drawing.Size(58, 226);
            this.pcbLockedButtonDoor.TabIndex = 40;
            this.pcbLockedButtonDoor.TabStop = false;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerHealth.Location = new System.Drawing.Point(12, 854);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(127, 39);
            this.lblPlayerHealth.TabIndex = 41;
            this.lblPlayerHealth.Text = "Health:";
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.BackColor = System.Drawing.Color.Gray;
            this.lblMainHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMainHand.Location = new System.Drawing.Point(238, 854);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(193, 39);
            this.lblMainHand.TabIndex = 42;
            this.lblMainHand.Text = "Main Hand:";
            // 
            // pcbSword
            // 
            this.pcbSword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbSword.Location = new System.Drawing.Point(115, 746);
            this.pcbSword.Name = "pcbSword";
            this.pcbSword.Size = new System.Drawing.Size(58, 54);
            this.pcbSword.TabIndex = 45;
            this.pcbSword.TabStop = false;
            this.pcbSword.Visible = false;
            // 
            // pcbHealthPotion
            // 
            this.pcbHealthPotion.BackColor = System.Drawing.Color.Transparent;
            this.pcbHealthPotion.Location = new System.Drawing.Point(81, 407);
            this.pcbHealthPotion.Name = "pcbHealthPotion";
            this.pcbHealthPotion.Size = new System.Drawing.Size(58, 54);
            this.pcbHealthPotion.TabIndex = 46;
            this.pcbHealthPotion.TabStop = false;
            // 
            // TutorialPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbSword);
            this.Controls.Add(this.lblMainHand);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.pcbHoldableButton);
            this.Controls.Add(this.lblPlayerInventory);
            this.Controls.Add(this.pcbPlatform3);
            this.Controls.Add(this.pcbPlatform2);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.lblTutorial1Text);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbWall);
            this.Controls.Add(this.pcbLockedCyanDoor);
            this.Controls.Add(this.pcbLockedLeverDoor);
            this.Controls.Add(this.pcbMovableBox);
            this.Controls.Add(this.pcbLockedButtonDoor);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.lblTutorialPart2Text);
            this.Controls.Add(this.pcbCyanKey);
            this.Controls.Add(this.pcbHealthPotion);
            this.Controls.Add(this.pcbLever);
            this.KeyPreview = true;
            this.Name = "TutorialPart2";
            this.Text = "TutorialPart2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart2_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedLeverDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMovableBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoldableButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedButtonDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHealthPotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Label lblTutorial1Text;
        private System.Windows.Forms.Label lblTutorialPart2Text;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.PictureBox pcbGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pcbPlatform1;
        private System.Windows.Forms.PictureBox pcbPlatform2;
        private System.Windows.Forms.PictureBox pcbPlatform3;
        private System.Windows.Forms.PictureBox pcbWall;
        private System.Windows.Forms.PictureBox pcbLockedCyanDoor;
        private System.Windows.Forms.PictureBox pcbCyanKey;
        private System.Windows.Forms.Label lblPlayerInventory;
        private System.Windows.Forms.PictureBox pcbLever;
        private System.Windows.Forms.PictureBox pcbLockedLeverDoor;
        private System.Windows.Forms.PictureBox pcbMovableBox;
        private System.Windows.Forms.PictureBox pcbHoldableButton;
        private System.Windows.Forms.PictureBox pcbLockedButtonDoor;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblMainHand;
        private System.Windows.Forms.PictureBox pcbSword;
        private System.Windows.Forms.PictureBox pcbHealthPotion;
    }
}
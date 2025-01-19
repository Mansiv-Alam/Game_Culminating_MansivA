namespace Game_Culminating_MansivA
{
    partial class MainGamePt1
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pcbSword = new System.Windows.Forms.PictureBox();
            this.lblMainHand = new System.Windows.Forms.Label();
            this.lblPlayerInventory = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform2 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform3 = new System.Windows.Forms.PictureBox();
            this.pcbExtraScore = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemy = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemySword = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbWall = new System.Windows.Forms.PictureBox();
            this.pcbLava = new System.Windows.Forms.PictureBox();
            this.pcbSpike = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbExtraScore2 = new System.Windows.Forms.PictureBox();
            this.pcbLockedCyanDoor = new System.Windows.Forms.PictureBox();
            this.pcbCyanKey = new System.Windows.Forms.PictureBox();
            this.pcbFallingTrap = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1097, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 75);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 39);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score:";
            // 
            // pcbSword
            // 
            this.pcbSword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbSword.Location = new System.Drawing.Point(102, 755);
            this.pcbSword.Name = "pcbSword";
            this.pcbSword.Size = new System.Drawing.Size(58, 54);
            this.pcbSword.TabIndex = 51;
            this.pcbSword.TabStop = false;
            this.pcbSword.Visible = false;
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.BackColor = System.Drawing.Color.Gray;
            this.lblMainHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMainHand.Location = new System.Drawing.Point(257, 852);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(193, 39);
            this.lblMainHand.TabIndex = 50;
            this.lblMainHand.Text = "Main Hand:";
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventory.Location = new System.Drawing.Point(588, 852);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(170, 39);
            this.lblPlayerInventory.TabIndex = 49;
            this.lblPlayerInventory.Text = "Inventory:";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerHealth.Location = new System.Drawing.Point(12, 852);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(127, 39);
            this.lblPlayerHealth.TabIndex = 48;
            this.lblPlayerHealth.Text = "Health:";
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(0, 831);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(1185, 80);
            this.pcbGround.TabIndex = 47;
            this.pcbGround.TabStop = false;
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 722);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(80, 110);
            this.pcbPlayer.TabIndex = 46;
            this.pcbPlayer.TabStop = false;
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(511, 576);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(163, 50);
            this.pcbPlatform1.TabIndex = 52;
            this.pcbPlatform1.TabStop = false;
            // 
            // pcbPlatform2
            // 
            this.pcbPlatform2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform2.Location = new System.Drawing.Point(902, 450);
            this.pcbPlatform2.Name = "pcbPlatform2";
            this.pcbPlatform2.Size = new System.Drawing.Size(283, 50);
            this.pcbPlatform2.TabIndex = 53;
            this.pcbPlatform2.TabStop = false;
            // 
            // pcbPlatform3
            // 
            this.pcbPlatform3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform3.Location = new System.Drawing.Point(0, 409);
            this.pcbPlatform3.Name = "pcbPlatform3";
            this.pcbPlatform3.Size = new System.Drawing.Size(333, 50);
            this.pcbPlatform3.TabIndex = 54;
            this.pcbPlatform3.TabStop = false;
            // 
            // pcbExtraScore
            // 
            this.pcbExtraScore.BackColor = System.Drawing.Color.Gold;
            this.pcbExtraScore.Location = new System.Drawing.Point(1090, 745);
            this.pcbExtraScore.Name = "pcbExtraScore";
            this.pcbExtraScore.Size = new System.Drawing.Size(58, 54);
            this.pcbExtraScore.TabIndex = 55;
            this.pcbExtraScore.TabStop = false;
            // 
            // pcbBasicEnemy
            // 
            this.pcbBasicEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pcbBasicEnemy.Location = new System.Drawing.Point(953, 745);
            this.pcbBasicEnemy.Name = "pcbBasicEnemy";
            this.pcbBasicEnemy.Size = new System.Drawing.Size(57, 87);
            this.pcbBasicEnemy.TabIndex = 56;
            this.pcbBasicEnemy.TabStop = false;
            // 
            // pcbBasicEnemySword
            // 
            this.pcbBasicEnemySword.BackColor = System.Drawing.Color.Gold;
            this.pcbBasicEnemySword.Location = new System.Drawing.Point(919, 771);
            this.pcbBasicEnemySword.Name = "pcbBasicEnemySword";
            this.pcbBasicEnemySword.Size = new System.Drawing.Size(36, 36);
            this.pcbBasicEnemySword.TabIndex = 57;
            this.pcbBasicEnemySword.TabStop = false;
            this.pcbBasicEnemySword.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(328, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 50);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // pcbWall
            // 
            this.pcbWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbWall.Location = new System.Drawing.Point(1164, 499);
            this.pcbWall.Name = "pcbWall";
            this.pcbWall.Size = new System.Drawing.Size(21, 333);
            this.pcbWall.TabIndex = 59;
            this.pcbWall.TabStop = false;
            // 
            // pcbLava
            // 
            this.pcbLava.BackColor = System.Drawing.Color.Firebrick;
            this.pcbLava.Location = new System.Drawing.Point(579, 175);
            this.pcbLava.Name = "pcbLava";
            this.pcbLava.Size = new System.Drawing.Size(95, 36);
            this.pcbLava.TabIndex = 60;
            this.pcbLava.TabStop = false;
            // 
            // pcbSpike
            // 
            this.pcbSpike.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pcbSpike.Location = new System.Drawing.Point(788, 122);
            this.pcbSpike.Name = "pcbSpike";
            this.pcbSpike.Size = new System.Drawing.Size(58, 54);
            this.pcbSpike.TabIndex = 61;
            this.pcbSpike.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Location = new System.Drawing.Point(477, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 54);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // pcbExtraScore2
            // 
            this.pcbExtraScore2.BackColor = System.Drawing.Color.Gold;
            this.pcbExtraScore2.Location = new System.Drawing.Point(47, 265);
            this.pcbExtraScore2.Name = "pcbExtraScore2";
            this.pcbExtraScore2.Size = new System.Drawing.Size(58, 54);
            this.pcbExtraScore2.TabIndex = 63;
            this.pcbExtraScore2.TabStop = false;
            // 
            // pcbLockedCyanDoor
            // 
            this.pcbLockedCyanDoor.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbLockedCyanDoor.Location = new System.Drawing.Point(952, 225);
            this.pcbLockedCyanDoor.Name = "pcbLockedCyanDoor";
            this.pcbLockedCyanDoor.Size = new System.Drawing.Size(58, 226);
            this.pcbLockedCyanDoor.TabIndex = 64;
            this.pcbLockedCyanDoor.TabStop = false;
            // 
            // pcbCyanKey
            // 
            this.pcbCyanKey.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbCyanKey.Location = new System.Drawing.Point(1011, 65);
            this.pcbCyanKey.Name = "pcbCyanKey";
            this.pcbCyanKey.Size = new System.Drawing.Size(58, 57);
            this.pcbCyanKey.TabIndex = 65;
            this.pcbCyanKey.TabStop = false;
            // 
            // pcbFallingTrap
            // 
            this.pcbFallingTrap.BackColor = System.Drawing.Color.MediumPurple;
            this.pcbFallingTrap.Location = new System.Drawing.Point(205, -1);
            this.pcbFallingTrap.Name = "pcbFallingTrap";
            this.pcbFallingTrap.Size = new System.Drawing.Size(118, 128);
            this.pcbFallingTrap.TabIndex = 66;
            this.pcbFallingTrap.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 5;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Enabled = true;
            this.tmrGameTick.Interval = 10;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // MainGamePt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbFallingTrap);
            this.Controls.Add(this.pcbCyanKey);
            this.Controls.Add(this.pcbLockedCyanDoor);
            this.Controls.Add(this.pcbExtraScore2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcbLava);
            this.Controls.Add(this.pcbWall);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbBasicEnemy);
            this.Controls.Add(this.pcbBasicEnemySword);
            this.Controls.Add(this.pcbExtraScore);
            this.Controls.Add(this.pcbPlatform3);
            this.Controls.Add(this.pcbPlatform2);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.pcbSword);
            this.Controls.Add(this.lblMainHand);
            this.Controls.Add(this.lblPlayerInventory);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbSpike);
            this.KeyPreview = true;
            this.Name = "MainGamePt1";
            this.Text = "MainGamePt1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGamePt1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGamePt1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pcbSword;
        private System.Windows.Forms.Label lblMainHand;
        private System.Windows.Forms.Label lblPlayerInventory;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.PictureBox pcbGround;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.PictureBox pcbPlatform1;
        private System.Windows.Forms.PictureBox pcbPlatform2;
        private System.Windows.Forms.PictureBox pcbPlatform3;
        private System.Windows.Forms.PictureBox pcbExtraScore;
        private System.Windows.Forms.PictureBox pcbBasicEnemy;
        private System.Windows.Forms.PictureBox pcbBasicEnemySword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbWall;
        private System.Windows.Forms.PictureBox pcbLava;
        private System.Windows.Forms.PictureBox pcbSpike;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbExtraScore2;
        private System.Windows.Forms.PictureBox pcbLockedCyanDoor;
        private System.Windows.Forms.PictureBox pcbCyanKey;
        private System.Windows.Forms.PictureBox pcbFallingTrap;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Timer tmrGameTick;
    }
}
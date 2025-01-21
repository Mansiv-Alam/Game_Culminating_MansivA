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
            this.lblMainHand = new System.Windows.Forms.Label();
            this.lblPlayerInventory = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.pcbFallingTrap = new System.Windows.Forms.PictureBox();
            this.pcbCyanKey = new System.Windows.Forms.PictureBox();
            this.pcbExtraScore2 = new System.Windows.Forms.PictureBox();
            this.pcbSpike = new System.Windows.Forms.PictureBox();
            this.pcbLava = new System.Windows.Forms.PictureBox();
            this.pcbWall = new System.Windows.Forms.PictureBox();
            this.pcbPlatform4 = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemy = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemySword = new System.Windows.Forms.PictureBox();
            this.pcbExtraScore = new System.Windows.Forms.PictureBox();
            this.pcbPlatform3 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform2 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pcbSword = new System.Windows.Forms.PictureBox();
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.pcbSpike2 = new System.Windows.Forms.PictureBox();
            this.pcbWall2 = new System.Windows.Forms.PictureBox();
            this.pcbLockedCyanDoor = new System.Windows.Forms.PictureBox();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
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
            this.lblScore.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 39);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score:";
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.BackColor = System.Drawing.Color.Gray;
            this.lblMainHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMainHand.Location = new System.Drawing.Point(246, 852);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(193, 39);
            this.lblMainHand.TabIndex = 50;
            this.lblMainHand.Text = "Main Hand:";
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventory.Location = new System.Drawing.Point(592, 852);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(106, 25);
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
            // pcbFallingTrap
            // 
            this.pcbFallingTrap.BackColor = System.Drawing.Color.Transparent;
            this.pcbFallingTrap.Location = new System.Drawing.Point(205, -1);
            this.pcbFallingTrap.Name = "pcbFallingTrap";
            this.pcbFallingTrap.Size = new System.Drawing.Size(118, 128);
            this.pcbFallingTrap.TabIndex = 66;
            this.pcbFallingTrap.TabStop = false;
            // 
            // pcbCyanKey
            // 
            this.pcbCyanKey.BackColor = System.Drawing.Color.Transparent;
            this.pcbCyanKey.Location = new System.Drawing.Point(1031, 140);
            this.pcbCyanKey.Name = "pcbCyanKey";
            this.pcbCyanKey.Size = new System.Drawing.Size(58, 57);
            this.pcbCyanKey.TabIndex = 65;
            this.pcbCyanKey.TabStop = false;
            // 
            // pcbExtraScore2
            // 
            this.pcbExtraScore2.BackColor = System.Drawing.Color.Transparent;
            this.pcbExtraScore2.Location = new System.Drawing.Point(19, 342);
            this.pcbExtraScore2.Name = "pcbExtraScore2";
            this.pcbExtraScore2.Size = new System.Drawing.Size(58, 54);
            this.pcbExtraScore2.TabIndex = 63;
            this.pcbExtraScore2.TabStop = false;
            // 
            // pcbSpike
            // 
            this.pcbSpike.BackColor = System.Drawing.Color.Transparent;
            this.pcbSpike.Location = new System.Drawing.Point(477, 0);
            this.pcbSpike.Name = "pcbSpike";
            this.pcbSpike.Size = new System.Drawing.Size(58, 54);
            this.pcbSpike.TabIndex = 62;
            this.pcbSpike.TabStop = false;
            // 
            // pcbLava
            // 
            this.pcbLava.BackColor = System.Drawing.Color.Firebrick;
            this.pcbLava.Location = new System.Drawing.Point(651, 219);
            this.pcbLava.Name = "pcbLava";
            this.pcbLava.Size = new System.Drawing.Size(95, 36);
            this.pcbLava.TabIndex = 60;
            this.pcbLava.TabStop = false;
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
            // pcbPlatform4
            // 
            this.pcbPlatform4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform4.Location = new System.Drawing.Point(328, 219);
            this.pcbPlatform4.Name = "pcbPlatform4";
            this.pcbPlatform4.Size = new System.Drawing.Size(857, 50);
            this.pcbPlatform4.TabIndex = 58;
            this.pcbPlatform4.TabStop = false;
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
            // pcbExtraScore
            // 
            this.pcbExtraScore.BackColor = System.Drawing.Color.Transparent;
            this.pcbExtraScore.Location = new System.Drawing.Point(1090, 745);
            this.pcbExtraScore.Name = "pcbExtraScore";
            this.pcbExtraScore.Size = new System.Drawing.Size(58, 54);
            this.pcbExtraScore.TabIndex = 55;
            this.pcbExtraScore.TabStop = false;
            // 
            // pcbPlatform3
            // 
            this.pcbPlatform3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform3.Location = new System.Drawing.Point(0, 435);
            this.pcbPlatform3.Name = "pcbPlatform3";
            this.pcbPlatform3.Size = new System.Drawing.Size(333, 50);
            this.pcbPlatform3.TabIndex = 54;
            this.pcbPlatform3.TabStop = false;
            // 
            // pcbPlatform2
            // 
            this.pcbPlatform2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbPlatform2.Location = new System.Drawing.Point(902, 450);
            this.pcbPlatform2.Name = "pcbPlatform2";
            this.pcbPlatform2.Size = new System.Drawing.Size(283, 50);
            this.pcbPlatform2.TabIndex = 53;
            this.pcbPlatform2.TabStop = false;
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(467, 607);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(245, 50);
            this.pcbPlatform1.TabIndex = 52;
            this.pcbPlatform1.TabStop = false;
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
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(0, 831);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(1185, 80);
            this.pcbGround.TabIndex = 47;
            this.pcbGround.TabStop = false;
            // 
            // pcbSpike2
            // 
            this.pcbSpike2.BackColor = System.Drawing.Color.Transparent;
            this.pcbSpike2.Location = new System.Drawing.Point(842, 170);
            this.pcbSpike2.Name = "pcbSpike2";
            this.pcbSpike2.Size = new System.Drawing.Size(58, 54);
            this.pcbSpike2.TabIndex = 61;
            this.pcbSpike2.TabStop = false;
            // 
            // pcbWall2
            // 
            this.pcbWall2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbWall2.Location = new System.Drawing.Point(1164, 0);
            this.pcbWall2.Name = "pcbWall2";
            this.pcbWall2.Size = new System.Drawing.Size(21, 224);
            this.pcbWall2.TabIndex = 67;
            this.pcbWall2.TabStop = false;
            // 
            // pcbLockedCyanDoor
            // 
            this.pcbLockedCyanDoor.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbLockedCyanDoor.Location = new System.Drawing.Point(952, 268);
            this.pcbLockedCyanDoor.Name = "pcbLockedCyanDoor";
            this.pcbLockedCyanDoor.Size = new System.Drawing.Size(58, 183);
            this.pcbLockedCyanDoor.TabIndex = 64;
            this.pcbLockedCyanDoor.TabStop = false;
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
            // MainGamePt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbFallingTrap);
            this.Controls.Add(this.pcbExtraScore2);
            this.Controls.Add(this.pcbSpike);
            this.Controls.Add(this.pcbLava);
            this.Controls.Add(this.pcbWall);
            this.Controls.Add(this.pcbPlatform4);
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
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbSpike2);
            this.Controls.Add(this.pcbWall2);
            this.Controls.Add(this.pcbLockedCyanDoor);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.pcbCyanKey);
            this.KeyPreview = true;
            this.Name = "MainGamePt1";
            this.Text = "MainGamePt1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGamePt1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainGamePt1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCyanKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtraScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLockedCyanDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
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
        private System.Windows.Forms.PictureBox pcbPlatform4;
        private System.Windows.Forms.PictureBox pcbWall;
        private System.Windows.Forms.PictureBox pcbLava;
        private System.Windows.Forms.PictureBox pcbSpike2;
        private System.Windows.Forms.PictureBox pcbSpike;
        private System.Windows.Forms.PictureBox pcbExtraScore2;
        private System.Windows.Forms.PictureBox pcbLockedCyanDoor;
        private System.Windows.Forms.PictureBox pcbCyanKey;
        private System.Windows.Forms.PictureBox pcbFallingTrap;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.PictureBox pcbWall2;
    }
}
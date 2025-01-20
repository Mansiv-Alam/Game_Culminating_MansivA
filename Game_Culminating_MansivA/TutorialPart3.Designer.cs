namespace Game_Culminating_MansivA
{
    partial class TutorialPart3
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
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTutorialPt3Text = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pcbPlatform2 = new System.Windows.Forms.PictureBox();
            this.pcbWall = new System.Windows.Forms.PictureBox();
            this.pcbPlatform3 = new System.Windows.Forms.PictureBox();
            this.pcbLava = new System.Windows.Forms.PictureBox();
            this.pcbSpike = new System.Windows.Forms.PictureBox();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.pcbFallingTrap = new System.Windows.Forms.PictureBox();
            this.lblPlayerInventory = new System.Windows.Forms.Label();
            this.lblMainHand = new System.Windows.Forms.Label();
            this.pcbSword = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemy = new System.Windows.Forms.PictureBox();
            this.pcbBasicEnemySword = new System.Windows.Forms.PictureBox();
            this.pcbStrongEnemy = new System.Windows.Forms.PictureBox();
            this.pcbStrongEnemySword = new System.Windows.Forms.PictureBox();
            this.pcbPlatform4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStrongEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStrongEnemySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform4)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 722);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(80, 110);
            this.pcbPlayer.TabIndex = 3;
            this.pcbPlayer.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 5;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovement_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1097, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 75);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblTutorialPt3Text
            // 
            this.lblTutorialPt3Text.AutoSize = true;
            this.lblTutorialPt3Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblTutorialPt3Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTutorialPt3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorialPt3Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorialPt3Text.Location = new System.Drawing.Point(478, 32);
            this.lblTutorialPt3Text.Name = "lblTutorialPt3Text";
            this.lblTutorialPt3Text.Size = new System.Drawing.Size(218, 55);
            this.lblTutorialPt3Text.TabIndex = 5;
            this.lblTutorialPt3Text.Text = "Enemies";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 39);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score:";
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
            this.pcbGround.TabIndex = 13;
            this.pcbGround.TabStop = false;
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(921, 634);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(163, 50);
            this.pcbPlatform1.TabIndex = 14;
            this.pcbPlatform1.TabStop = false;
            // 
            // pcbPlatform2
            // 
            this.pcbPlatform2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform2.Location = new System.Drawing.Point(0, 516);
            this.pcbPlatform2.Name = "pcbPlatform2";
            this.pcbPlatform2.Size = new System.Drawing.Size(783, 50);
            this.pcbPlatform2.TabIndex = 15;
            this.pcbPlatform2.TabStop = false;
            // 
            // pcbWall
            // 
            this.pcbWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbWall.Location = new System.Drawing.Point(1135, 290);
            this.pcbWall.Name = "pcbWall";
            this.pcbWall.Size = new System.Drawing.Size(50, 545);
            this.pcbWall.TabIndex = 16;
            this.pcbWall.TabStop = false;
            // 
            // pcbPlatform3
            // 
            this.pcbPlatform3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform3.Location = new System.Drawing.Point(335, 243);
            this.pcbPlatform3.Name = "pcbPlatform3";
            this.pcbPlatform3.Size = new System.Drawing.Size(850, 50);
            this.pcbPlatform3.TabIndex = 17;
            this.pcbPlatform3.TabStop = false;
            // 
            // pcbLava
            // 
            this.pcbLava.BackColor = System.Drawing.Color.Firebrick;
            this.pcbLava.Location = new System.Drawing.Point(523, 516);
            this.pcbLava.Name = "pcbLava";
            this.pcbLava.Size = new System.Drawing.Size(137, 50);
            this.pcbLava.TabIndex = 25;
            this.pcbLava.TabStop = false;
            // 
            // pcbSpike
            // 
            this.pcbSpike.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pcbSpike.Location = new System.Drawing.Point(335, 465);
            this.pcbSpike.Name = "pcbSpike";
            this.pcbSpike.Size = new System.Drawing.Size(58, 54);
            this.pcbSpike.TabIndex = 30;
            this.pcbSpike.TabStop = false;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerHealth.Location = new System.Drawing.Point(18, 849);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(127, 39);
            this.lblPlayerHealth.TabIndex = 31;
            this.lblPlayerHealth.Text = "Health:";
            // 
            // pcbFallingTrap
            // 
            this.pcbFallingTrap.BackColor = System.Drawing.Color.MediumPurple;
            this.pcbFallingTrap.Location = new System.Drawing.Point(0, 95);
            this.pcbFallingTrap.Name = "pcbFallingTrap";
            this.pcbFallingTrap.Size = new System.Drawing.Size(118, 128);
            this.pcbFallingTrap.TabIndex = 32;
            this.pcbFallingTrap.TabStop = false;
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventory.Location = new System.Drawing.Point(585, 849);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(106, 25);
            this.lblPlayerInventory.TabIndex = 36;
            this.lblPlayerInventory.Text = "Inventory:";
            // 
            // lblMainHand
            // 
            this.lblMainHand.AutoSize = true;
            this.lblMainHand.BackColor = System.Drawing.Color.Gray;
            this.lblMainHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMainHand.Location = new System.Drawing.Point(246, 849);
            this.lblMainHand.Name = "lblMainHand";
            this.lblMainHand.Size = new System.Drawing.Size(193, 39);
            this.lblMainHand.TabIndex = 43;
            this.lblMainHand.Text = "Main Hand:";
            // 
            // pcbSword
            // 
            this.pcbSword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pcbSword.Location = new System.Drawing.Point(102, 752);
            this.pcbSword.Name = "pcbSword";
            this.pcbSword.Size = new System.Drawing.Size(58, 54);
            this.pcbSword.TabIndex = 44;
            this.pcbSword.TabStop = false;
            this.pcbSword.Visible = false;
            // 
            // pcbBasicEnemy
            // 
            this.pcbBasicEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pcbBasicEnemy.Location = new System.Drawing.Point(479, 159);
            this.pcbBasicEnemy.Name = "pcbBasicEnemy";
            this.pcbBasicEnemy.Size = new System.Drawing.Size(57, 87);
            this.pcbBasicEnemy.TabIndex = 45;
            this.pcbBasicEnemy.TabStop = false;
            // 
            // pcbBasicEnemySword
            // 
            this.pcbBasicEnemySword.BackColor = System.Drawing.Color.Gold;
            this.pcbBasicEnemySword.Location = new System.Drawing.Point(445, 185);
            this.pcbBasicEnemySword.Name = "pcbBasicEnemySword";
            this.pcbBasicEnemySword.Size = new System.Drawing.Size(36, 36);
            this.pcbBasicEnemySword.TabIndex = 46;
            this.pcbBasicEnemySword.TabStop = false;
            this.pcbBasicEnemySword.Visible = false;
            // 
            // pcbStrongEnemy
            // 
            this.pcbStrongEnemy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pcbStrongEnemy.Location = new System.Drawing.Point(899, 159);
            this.pcbStrongEnemy.Name = "pcbStrongEnemy";
            this.pcbStrongEnemy.Size = new System.Drawing.Size(57, 87);
            this.pcbStrongEnemy.TabIndex = 47;
            this.pcbStrongEnemy.TabStop = false;
            // 
            // pcbStrongEnemySword
            // 
            this.pcbStrongEnemySword.BackColor = System.Drawing.Color.Goldenrod;
            this.pcbStrongEnemySword.Location = new System.Drawing.Point(867, 185);
            this.pcbStrongEnemySword.Name = "pcbStrongEnemySword";
            this.pcbStrongEnemySword.Size = new System.Drawing.Size(36, 36);
            this.pcbStrongEnemySword.TabIndex = 48;
            this.pcbStrongEnemySword.TabStop = false;
            this.pcbStrongEnemySword.Visible = false;
            // 
            // pcbPlatform4
            // 
            this.pcbPlatform4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform4.Location = new System.Drawing.Point(124, 308);
            this.pcbPlatform4.Name = "pcbPlatform4";
            this.pcbPlatform4.Size = new System.Drawing.Size(121, 54);
            this.pcbPlatform4.TabIndex = 49;
            this.pcbPlatform4.TabStop = false;
            // 
            // TutorialPart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbPlatform4);
            this.Controls.Add(this.lblMainHand);
            this.Controls.Add(this.lblPlayerInventory);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.pcbLava);
            this.Controls.Add(this.pcbPlatform3);
            this.Controls.Add(this.pcbWall);
            this.Controls.Add(this.pcbPlatform2);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbSpike);
            this.Controls.Add(this.pcbFallingTrap);
            this.Controls.Add(this.lblTutorialPt3Text);
            this.Controls.Add(this.pcbBasicEnemy);
            this.Controls.Add(this.pcbBasicEnemySword);
            this.Controls.Add(this.pcbStrongEnemy);
            this.Controls.Add(this.pcbStrongEnemySword);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.pcbSword);
            this.KeyPreview = true;
            this.Name = "TutorialPart3";
            this.Text = "TutorialPart3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerMouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFallingTrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBasicEnemySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStrongEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStrongEnemySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblTutorialPt3Text;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.PictureBox pcbGround;
        private System.Windows.Forms.PictureBox pcbPlatform1;
        private System.Windows.Forms.PictureBox pcbPlatform2;
        private System.Windows.Forms.PictureBox pcbWall;
        private System.Windows.Forms.PictureBox pcbPlatform3;
        private System.Windows.Forms.PictureBox pcbLava;
        private System.Windows.Forms.PictureBox pcbSpike;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.PictureBox pcbFallingTrap;
        private System.Windows.Forms.Label lblPlayerInventory;
        private System.Windows.Forms.Label lblMainHand;
        private System.Windows.Forms.PictureBox pcbSword;
        private System.Windows.Forms.PictureBox pcbBasicEnemy;
        private System.Windows.Forms.PictureBox pcbBasicEnemySword;
        private System.Windows.Forms.PictureBox pcbStrongEnemy;
        private System.Windows.Forms.PictureBox pcbStrongEnemySword;
        private System.Windows.Forms.PictureBox pcbPlatform4;
    }
}
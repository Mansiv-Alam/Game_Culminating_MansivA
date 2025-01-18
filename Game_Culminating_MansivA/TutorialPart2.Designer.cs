namespace Game_Culminating_MansivA
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
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 701);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(93, 134);
            this.pcbPlayer.TabIndex = 2;
            this.pcbPlayer.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 10;
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
            this.lblTutorialPart2Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblTutorialPart2Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTutorialPart2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorialPart2Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorialPart2Text.Location = new System.Drawing.Point(45, 53);
            this.lblTutorialPart2Text.Name = "lblTutorialPart2Text";
            this.lblTutorialPart2Text.Size = new System.Drawing.Size(1046, 55);
            this.lblTutorialPart2Text.TabIndex = 4;
            this.lblTutorialPart2Text.Text = "This is where you will learn about Key Objects";
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Enabled = true;
            this.tmrGameTick.Interval = 20;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(-1, 831);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(1185, 80);
            this.pcbGround.TabIndex = 6;
            this.pcbGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
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
            this.pcbPlatform1.Location = new System.Drawing.Point(162, 627);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(163, 50);
            this.pcbPlatform1.TabIndex = 12;
            this.pcbPlatform1.TabStop = false;
            // 
            // pcbPlatform2
            // 
            this.pcbPlatform2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform2.Location = new System.Drawing.Point(392, 528);
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
            this.pcbCyanKey.BackColor = System.Drawing.Color.DarkCyan;
            this.pcbCyanKey.Location = new System.Drawing.Point(447, 442);
            this.pcbCyanKey.Name = "pcbCyanKey";
            this.pcbCyanKey.Size = new System.Drawing.Size(58, 57);
            this.pcbCyanKey.TabIndex = 34;
            this.pcbCyanKey.TabStop = false;
            // 
            // lblPlayerInventory
            // 
            this.lblPlayerInventory.AutoSize = true;
            this.lblPlayerInventory.BackColor = System.Drawing.Color.Gray;
            this.lblPlayerInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInventory.Location = new System.Drawing.Point(30, 853);
            this.lblPlayerInventory.Name = "lblPlayerInventory";
            this.lblPlayerInventory.Size = new System.Drawing.Size(170, 39);
            this.lblPlayerInventory.TabIndex = 35;
            this.lblPlayerInventory.Text = "Inventory:";
            // 
            // pcbLever
            // 
            this.pcbLever.BackColor = System.Drawing.Color.SandyBrown;
            this.pcbLever.Location = new System.Drawing.Point(219, 564);
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
            // TutorialPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbCyanKey);
            this.Controls.Add(this.pcbLever);
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
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.lblTutorialPart2Text);
            this.KeyPreview = true;
            this.Name = "TutorialPart2";
            this.Text = "TutorialPart2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart2_KeyUp);
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
    }
}
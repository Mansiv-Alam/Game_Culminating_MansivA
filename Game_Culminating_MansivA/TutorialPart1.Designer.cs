namespace Game_Culminating_MansivA
{
    partial class TutorialPart1
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
            this.tmrGameTick = new System.Windows.Forms.Timer(this.components);
            this.lblTutorial1Text = new System.Windows.Forms.Label();
            this.pcbGround = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1097, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 75);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSettings_Click);
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 701);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(93, 134);
            this.pcbPlayer.TabIndex = 1;
            this.pcbPlayer.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 5;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovementTick);
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Enabled = true;
            this.tmrGameTick.Interval = 10;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // lblTutorial1Text
            // 
            this.lblTutorial1Text.AutoSize = true;
            this.lblTutorial1Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblTutorial1Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTutorial1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorial1Text.Location = new System.Drawing.Point(299, 91);
            this.lblTutorial1Text.Name = "lblTutorial1Text";
            this.lblTutorial1Text.Size = new System.Drawing.Size(568, 55);
            this.lblTutorial1Text.TabIndex = 2;
            this.lblTutorial1Text.Text = "Welcome To the Tutorial";
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(0, 834);
            this.pcbGround.Name = "pcbGround";
            this.pcbGround.Size = new System.Drawing.Size(1185, 80);
            this.pcbGround.TabIndex = 5;
            this.pcbGround.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(118, 39);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(420, 536);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(325, 50);
            this.pcbPlatform1.TabIndex = 11;
            this.pcbPlatform1.TabStop = false;
            // 
            // TutorialPart1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.lblTutorial1Text);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.pcbPlayer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.Name = "TutorialPart1";
            this.Text = "TutorialPart1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.Label lblTutorial1Text;
        private System.Windows.Forms.PictureBox pcbGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pcbPlatform1;
    }
}
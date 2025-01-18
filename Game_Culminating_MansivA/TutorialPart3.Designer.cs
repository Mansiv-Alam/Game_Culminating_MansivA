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
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(25, 701);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(93, 134);
            this.pcbPlayer.TabIndex = 3;
            this.pcbPlayer.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 10;
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
            this.tmrGameTick.Interval = 20;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // pcbGround
            // 
            this.pcbGround.BackColor = System.Drawing.Color.Gray;
            this.pcbGround.Location = new System.Drawing.Point(0, 832);
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
            this.pcbPlatform3.Location = new System.Drawing.Point(256, 242);
            this.pcbPlatform3.Name = "pcbPlatform3";
            this.pcbPlatform3.Size = new System.Drawing.Size(929, 50);
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
            // TutorialPart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbLava);
            this.Controls.Add(this.pcbPlatform3);
            this.Controls.Add(this.pcbWall);
            this.Controls.Add(this.pcbPlatform2);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.pcbGround);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTutorialPt3Text);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbPlayer);
            this.KeyPreview = true;
            this.Name = "TutorialPart3";
            this.Text = "TutorialPart3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLava)).EndInit();
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
    }
}
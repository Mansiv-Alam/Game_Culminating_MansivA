﻿namespace Game_Culminating_MansivA
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
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
            this.btnSettings.UseWaitCursor = true;
            this.btnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSettings_Click);
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(12, 765);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(93, 134);
            this.pcbPlayer.TabIndex = 1;
            this.pcbPlayer.TabStop = false;
            this.pcbPlayer.UseWaitCursor = true;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 10;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.tmrPlayerMovementTick);
            // 
            // tmrGameTick
            // 
            this.tmrGameTick.Enabled = true;
            this.tmrGameTick.Interval = 20;
            this.tmrGameTick.Tick += new System.EventHandler(this.tmrGameTick_Tick);
            // 
            // lblTutorial1Text
            // 
            this.lblTutorial1Text.AutoSize = true;
            this.lblTutorial1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorial1Text.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblTutorial1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1Text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTutorial1Text.Location = new System.Drawing.Point(283, 228);
            this.lblTutorial1Text.Name = "lblTutorial1Text";
            this.lblTutorial1Text.Size = new System.Drawing.Size(568, 55);
            this.lblTutorial1Text.TabIndex = 2;
            this.lblTutorial1Text.Text = "Welcome To the Tutorial";
            this.lblTutorial1Text.UseWaitCursor = true;
            // 
            // TutorialPart1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.lblTutorial1Text);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.btnSettings);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.KeyPreview = true;
            this.Name = "TutorialPart1";
            this.Text = "TutorialPart1";
            this.UseWaitCursor = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Timer tmrGameTick;
        private System.Windows.Forms.Label lblTutorial1Text;
    }
}
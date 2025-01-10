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
            this.btnSettings = new System.Windows.Forms.Button();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.pcbPlatform1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).BeginInit();
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
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(35, 727);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(93, 134);
            this.pcbPlayer.TabIndex = 6;
            this.pcbPlayer.TabStop = false;
            // 
            // pcbPlatform1
            // 
            this.pcbPlatform1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlatform1.Location = new System.Drawing.Point(357, 501);
            this.pcbPlatform1.Name = "pcbPlatform1";
            this.pcbPlatform1.Size = new System.Drawing.Size(326, 54);
            this.pcbPlatform1.TabIndex = 8;
            this.pcbPlatform1.TabStop = false;
            // 
            // MainGamePt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbPlatform1);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.btnSettings);
            this.KeyPreview = true;
            this.Name = "MainGamePt1";
            this.Text = "MainGamePt1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlatform1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.PictureBox pcbPlatform1;
    }
}
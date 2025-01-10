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
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pcbPlayer.Location = new System.Drawing.Point(45, 731);
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
            // 
            // lblTutorialPt3Text
            // 
            this.lblTutorialPt3Text.AutoSize = true;
            this.lblTutorialPt3Text.BackColor = System.Drawing.SystemColors.Control;
            this.lblTutorialPt3Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTutorialPt3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorialPt3Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorialPt3Text.Location = new System.Drawing.Point(440, 160);
            this.lblTutorialPt3Text.Name = "lblTutorialPt3Text";
            this.lblTutorialPt3Text.Size = new System.Drawing.Size(218, 55);
            this.lblTutorialPt3Text.TabIndex = 5;
            this.lblTutorialPt3Text.Text = "Enemies";
            // 
            // TutorialPart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.lblTutorialPt3Text);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pcbPlayer);
            this.KeyPreview = true;
            this.Name = "TutorialPart3";
            this.Text = "TutorialPart3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblTutorialPt3Text;
    }
}
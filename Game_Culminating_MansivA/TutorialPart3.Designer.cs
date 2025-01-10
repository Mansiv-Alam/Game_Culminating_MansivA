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
            // TutorialPart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.pcbPlayer);
            this.KeyPreview = true;
            this.Name = "TutorialPart3";
            this.Text = "TutorialPart3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TutorialPart3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer tmrPlayerMovement;
    }
}
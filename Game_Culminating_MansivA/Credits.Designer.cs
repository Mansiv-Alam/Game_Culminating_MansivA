namespace Game_Culminating_MansivA
{
    partial class Credits
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblLeadProgrammer = new System.Windows.Forms.Label();
            this.lblSoundDesign = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(144, 87);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.Text = "Back to Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblLeadProgrammer
            // 
            this.lblLeadProgrammer.AutoSize = true;
            this.lblLeadProgrammer.BackColor = System.Drawing.SystemColors.Control;
            this.lblLeadProgrammer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLeadProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadProgrammer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLeadProgrammer.Location = new System.Drawing.Point(104, 505);
            this.lblLeadProgrammer.Name = "lblLeadProgrammer";
            this.lblLeadProgrammer.Size = new System.Drawing.Size(301, 74);
            this.lblLeadProgrammer.TabIndex = 9;
            this.lblLeadProgrammer.Text = "Lead Programmer:\r\n     Mansiv Alam";
            // 
            // lblSoundDesign
            // 
            this.lblSoundDesign.AutoSize = true;
            this.lblSoundDesign.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoundDesign.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSoundDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoundDesign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoundDesign.Location = new System.Drawing.Point(778, 321);
            this.lblSoundDesign.Name = "lblSoundDesign";
            this.lblSoundDesign.Size = new System.Drawing.Size(261, 74);
            this.lblSoundDesign.TabIndex = 10;
            this.lblSoundDesign.Text = "Sound Designer\r\n     Mansiv Alam";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.BackColor = System.Drawing.SystemColors.Control;
            this.lblDirector.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(104, 321);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(261, 74);
            this.lblDirector.TabIndex = 11;
            this.lblDirector.Text = "Game Director:\r\n     Mansiv Alam";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.SystemColors.Control;
            this.lblCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCredits.Location = new System.Drawing.Point(472, 123);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(183, 55);
            this.lblCredits.TabIndex = 12;
            this.lblCredits.Text = "Credits";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblSoundDesign);
            this.Controls.Add(this.lblLeadProgrammer);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "Credits";
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblLeadProgrammer;
        private System.Windows.Forms.Label lblSoundDesign;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblCredits;
    }
}
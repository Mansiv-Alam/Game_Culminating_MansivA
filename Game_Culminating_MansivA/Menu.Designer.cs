namespace Game_Culminating_MansivA
{
    partial class Menu
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
            this.btnGameStart = new System.Windows.Forms.Button();
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.btnTutorialStart = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblGameText = new System.Windows.Forms.Label();
            this.lblTutorial1Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGameStart
            // 
            this.btnGameStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStart.ForeColor = System.Drawing.Color.Black;
            this.btnGameStart.Location = new System.Drawing.Point(465, 260);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(250, 50);
            this.btnGameStart.TabIndex = 0;
            this.btnGameStart.TabStop = false;
            this.btnGameStart.Text = "Start Game";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSave.ForeColor = System.Drawing.Color.Black;
            this.btnLoadSave.Location = new System.Drawing.Point(465, 338);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(250, 50);
            this.btnLoadSave.TabIndex = 1;
            this.btnLoadSave.TabStop = false;
            this.btnLoadSave.Text = "Load Save";
            this.btnLoadSave.UseVisualStyleBackColor = true;
            // 
            // btnTutorialStart
            // 
            this.btnTutorialStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorialStart.ForeColor = System.Drawing.Color.Black;
            this.btnTutorialStart.Location = new System.Drawing.Point(465, 415);
            this.btnTutorialStart.Name = "btnTutorialStart";
            this.btnTutorialStart.Size = new System.Drawing.Size(250, 50);
            this.btnTutorialStart.TabIndex = 2;
            this.btnTutorialStart.TabStop = false;
            this.btnTutorialStart.Text = "Tutorial";
            this.btnTutorialStart.UseVisualStyleBackColor = true;
            this.btnTutorialStart.Click += new System.EventHandler(this.btnTutorialStart_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.Color.Black;
            this.btnCredits.Location = new System.Drawing.Point(465, 489);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(250, 50);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.TabStop = false;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(465, 561);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(250, 50);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblGameText
            // 
            this.lblGameText.AutoSize = true;
            this.lblGameText.Font = new System.Drawing.Font("Courier New", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameText.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGameText.Location = new System.Drawing.Point(318, 55);
            this.lblGameText.Name = "lblGameText";
            this.lblGameText.Size = new System.Drawing.Size(569, 111);
            this.lblGameText.TabIndex = 5;
            this.lblGameText.Text = "The Ruins";
            // 
            // lblTutorial1Text
            // 
            this.lblTutorial1Text.AutoSize = true;
            this.lblTutorial1Text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTutorial1Text.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblTutorial1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial1Text.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTutorial1Text.Location = new System.Drawing.Point(72, 202);
            this.lblTutorial1Text.Name = "lblTutorial1Text";
            this.lblTutorial1Text.Size = new System.Drawing.Size(0, 55);
            this.lblTutorial1Text.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 911);
            this.Controls.Add(this.lblTutorial1Text);
            this.Controls.Add(this.lblGameText);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnTutorialStart);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.btnGameStart);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Button btnLoadSave;
        private System.Windows.Forms.Button btnTutorialStart;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGameText;
        private System.Windows.Forms.Label lblTutorial1Text;
    }
}
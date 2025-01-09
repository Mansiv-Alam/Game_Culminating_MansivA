﻿namespace Game_Culminating_MansivA
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
            this.SuspendLayout();
            // 
            // btnGameStart
            // 
            this.btnGameStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameStart.ForeColor = System.Drawing.Color.Black;
            this.btnGameStart.Location = new System.Drawing.Point(400, 260);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(250, 50);
            this.btnGameStart.TabIndex = 0;
            this.btnGameStart.Text = "Start Game";
            this.btnGameStart.UseVisualStyleBackColor = true;
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSave.ForeColor = System.Drawing.Color.Black;
            this.btnLoadSave.Location = new System.Drawing.Point(400, 338);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(250, 50);
            this.btnLoadSave.TabIndex = 1;
            this.btnLoadSave.Text = "Load Save";
            this.btnLoadSave.UseVisualStyleBackColor = true;
            // 
            // btnTutorialStart
            // 
            this.btnTutorialStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorialStart.ForeColor = System.Drawing.Color.Black;
            this.btnTutorialStart.Location = new System.Drawing.Point(400, 415);
            this.btnTutorialStart.Name = "btnTutorialStart";
            this.btnTutorialStart.Size = new System.Drawing.Size(250, 50);
            this.btnTutorialStart.TabIndex = 2;
            this.btnTutorialStart.Text = "Tutorial";
            this.btnTutorialStart.UseVisualStyleBackColor = true;
            this.btnTutorialStart.Click += new System.EventHandler(this.btnTutorialStart_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.Color.Black;
            this.btnCredits.Location = new System.Drawing.Point(400, 489);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(250, 50);
            this.btnCredits.TabIndex = 3;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(400, 561);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(250, 50);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnTutorialStart);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.btnGameStart);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Button btnLoadSave;
        private System.Windows.Forms.Button btnTutorialStart;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnQuit;
    }
}
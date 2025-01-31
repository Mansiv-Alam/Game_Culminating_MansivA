﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Adds File IO library
using System.IO;

namespace Game_Culminating_MansivA
{
    public partial class Settings : Form
    {
        // Holds which form opened the settings form
        public static int intLevelOpened;
        // Player UI
        public static int intMainHandValue;
        public static string strMainHandItemName;
        public static int[] intInventoryValuesSaved = new int[5];
        public static string[] strInventoryNamesSaved = new string[5];
        public static int intPlayerScoreSaved = 0;
        // Game Environment Variables
        public Settings()
        {
            InitializeComponent();
        }
        // Runs if the Player wants Restarts the level
        private void btnRestartLevel_Click(object sender, EventArgs e)
        {
            // If conditions for each tutorial level and main level
            if (intLevelOpened == 1) { 
                TutorialPart1 tutorialPart1 = new TutorialPart1();
                tutorialPart1.Show();
            }
            if (intLevelOpened == 2) {
                TutorialPart2 tutorialPart2 = new TutorialPart2();
                tutorialPart2.Show();
            }
            if (intLevelOpened == 3)
            {
                TutorialPart3 tutorialPart3 = new TutorialPart3();
                tutorialPart3.Show();
            }
            if (intLevelOpened == 4)
            {
                MainGamePt1 mainGamePt1 = new MainGamePt1();
                mainGamePt1.Show();
            }
            if (intLevelOpened == 5)
            {
                MainGamePt2 mainGamePt2 = new MainGamePt2();
                mainGamePt2.Show();
            }
            if (intLevelOpened == 6)
            {
                MainGamePt3 mainGamePt3 = new MainGamePt3();
                mainGamePt3.Show();
            }
            if (intLevelOpened == 7)
            {
                MainGamePt4 mainGamePt4 = new MainGamePt4();
                mainGamePt4.Show();
            }
            if (intLevelOpened == 8)
            {
                MainGamePt5 mainGamePt5 = new MainGamePt5();
                mainGamePt5.Show();
            }
            if (intLevelOpened == 9)
            {
                MainGamePt6 mainGamePt6 = new MainGamePt6();
                mainGamePt6.Show();
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Quits all Forms / the Entire application
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Deletes all forms and shows the menu
            Application.Restart();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            // Makes File
            FileInfo FileX = new FileInfo("RuinsSaveLoad.txt");
            // Opens file /Writes Data into
            StreamWriter Text = FileX.CreateText();
            // Writes the level opened, Score saved, main hand item values, and the inventory array
            Text.WriteLine(intLevelOpened);
            Text.WriteLine(intPlayerScoreSaved);
            Text.WriteLine(intMainHandValue);
            Text.WriteLine(strMainHandItemName);
            for (int i = 0; i < intInventoryValuesSaved.Length; i++) {
                Text.WriteLine(intInventoryValuesSaved[i]);
            }
            for (int i = 0; i < strInventoryNamesSaved.Length; i++)
            {
                Text.WriteLine(strInventoryNamesSaved[i]);
            }
            Text.Close();
            MessageBox.Show("Saved Game");
        }
    }
}

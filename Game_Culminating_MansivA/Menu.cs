// Mansiv Alam
// January 8th 2025
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Addes File IO
using System.IO;

namespace Game_Culminating_MansivA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        // Occurs when the Quit button is clicked
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Closes the Game
            this.Close();
        }
        // Occurs when the tutorial button is clicked
        private void btnTutorialStart_Click(object sender, EventArgs e)
        {
            // If conditions for each tutorial level and main level
            if (Settings.intLevelOpened == 1)
            {
                TutorialPart1 tutorialPart1 = new TutorialPart1();
                tutorialPart1.Show();
            }
            if (Settings.intLevelOpened == 2)
            {
                TutorialPart2 tutorialPart2 = new TutorialPart2();
                tutorialPart2.Show();
            }
            if (Settings.intLevelOpened == 3)
            {
                TutorialPart3 tutorialPart3 = new TutorialPart3();
                tutorialPart3.Show();
            }
            if (Settings.intLevelOpened == 4)
            {
                MainGamePt1 mainGamePt1 = new MainGamePt1();
                mainGamePt1.Show();
            }
            if (Settings.intLevelOpened == 5)
            {
                MainGamePt2 mainGamePt2 = new MainGamePt2();
                mainGamePt2.Show();
            }
            if (Settings.intLevelOpened == 6)
            {
                MainGamePt3 mainGamePt3 = new MainGamePt3();
                mainGamePt3.Show();
            }
            if (Settings.intLevelOpened == 7)
            {
                MainGamePt4 mainGamePt4 = new MainGamePt4();
                mainGamePt4.Show();
            }
            if (Settings.intLevelOpened == 8)
            {
                MainGamePt5 mainGamePt5 = new MainGamePt5();
                mainGamePt5.Show();
            }
            if (Settings.intLevelOpened == 9)
            {
                MainGamePt6 mainGamePt6 = new MainGamePt6();
                mainGamePt6.Show();
            }
            // Runs the first level if there is nothing in the Settings.intLevelOpened
            else
            {
                MainGamePt1 mainGamePt1 = new MainGamePt1();
                mainGamePt1.Show();
            }
            Close();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Main Game 1 Form
            MainGamePt1 MainGamePt1 = new MainGamePt1();
            // Hides this form
            this.Hide();
            // Shows/Opens the Main Game
            MainGamePt1.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            // Makes a instance of the Credits Form
            Credits Credits = new Credits();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            Credits.Show();
        }
        // Reads Save File
        private void btnLoadSave_Click(object sender, EventArgs e)
        {
            // Opens File
            StreamReader Read = File.OpenText("RuinsSaveLoad.txt");
            // Gets the level opened, players score, and main hand values
            Settings.intLevelOpened = Int32.Parse(Read.ReadLine());
            Settings.intPlayerScoreSaved = Int32.Parse(Read.ReadLine());
            Settings.intMainHandValue = Int32.Parse(Read.ReadLine());
            Settings.strMainHandItemName = Read.ReadLine();
            // Gets the inventory values
            for (int i = 0; i < Settings.intInventoryValuesSaved.Length; i++) {
                Settings.intInventoryValuesSaved[i] = Int32.Parse(Read.ReadLine());
            }
            for (int i = 0; i < Settings.strInventoryNamesSaved.Length; i++)
            {
                Settings.strInventoryNamesSaved[i] = Read.ReadLine();
            }
            // Closes the file
            Read.Close();
        }
    }
}

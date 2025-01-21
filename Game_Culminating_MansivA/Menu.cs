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
using System.Diagnostics;

namespace Game_Culminating_MansivA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // Renders another screen not on the screen and then changes the rendered screen not on the screen onto the screen
            // helps with smoother animation and less lag (increases ram usage)
            this.DoubleBuffered = true;
            // Makes the background the ruins bg
            this.BackgroundImage = Resource1.RuinsBg;
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
            // Makes a instance of the Tutorial Part 1 Form
            TutorialPart1 TutorialPart1 = new TutorialPart1();
            // Hides this form
            this.Hide();
            // Shows/Opens the tutorial
            TutorialPart1.Show();
        }

        // pictureboxname.Image = resoucefilename.image.imagename 

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            // If conditions for each tutorial level and main level
            if (Settings.intLevelOpened == 0) {
                MainGamePt1 mainGamePt1 = new MainGamePt1();
                mainGamePt1.Show();
            }
            else if (Settings.intLevelOpened == 4)
            {
                MainGamePt1 mainGamePt1 = new MainGamePt1();
                mainGamePt1.Show();
            }
            else if (Settings.intLevelOpened == 5)
            {
                MainGamePt2 mainGamePt2 = new MainGamePt2();
                mainGamePt2.Show();
            }
            else if (Settings.intLevelOpened == 6)
            {
                MainGamePt3 mainGamePt3 = new MainGamePt3();
                mainGamePt3.Show();
            }
            else if (Settings.intLevelOpened == 7)
            {
                MainGamePt4 mainGamePt4 = new MainGamePt4();
                mainGamePt4.Show();
            }
            else if (Settings.intLevelOpened == 8)
            {
                MainGamePt5 mainGamePt5 = new MainGamePt5();
                mainGamePt5.Show();
            }
            else if (Settings.intLevelOpened == 9)
            {
                MainGamePt6 mainGamePt6 = new MainGamePt6();
                mainGamePt6.Show();
            }
            this.Hide();
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
            // does a try catch error to see if there is a save file
            try
            {
                // Opens File
                StreamReader Read = File.OpenText("RuinsSaveLoad.txt");
                // Gets the level opened, players score, and main hand values
                Settings.intLevelOpened = Int32.Parse(Read.ReadLine());
                Settings.intPlayerScoreSaved = Int32.Parse(Read.ReadLine());
                Settings.intMainHandValue = Int32.Parse(Read.ReadLine());
                Settings.strMainHandItemName = Read.ReadLine();
                // Gets the inventory values
                for (int i = 0; i < Settings.intInventoryValuesSaved.Length; i++)
                {
                    Settings.intInventoryValuesSaved[i] = Int32.Parse(Read.ReadLine());
                }
                for (int i = 0; i < Settings.strInventoryNamesSaved.Length; i++)
                {
                    Settings.strInventoryNamesSaved[i] = Read.ReadLine();
                }
                // Closes the file
                Read.Close();
                MessageBox.Show("Save Has been Loaded");
            }
            // uses exFileNotFound because e is already in use for the EventArgs
            catch (Exception exFileNotFound) {
                MessageBox.Show(exFileNotFound.Message);
            }
        }
    }
}

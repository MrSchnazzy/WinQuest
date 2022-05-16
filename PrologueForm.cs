using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuest
{
    public partial class PrologueForm : Form
    {
        int count;
        public static string playerName;
        public static int playerHp, playerMp, playerStr, playerMag, playerDef, playerRes;

        public PrologueForm()
        {
            count = 0;
            InitializeComponent();
            WinQuest.MainForm.TypeText("What is this?", this, 75);
            WinQuest.MainForm.TypeText("What is your name?", nameLabel, 75);
            WinQuest.MainForm.TypeText("Remember?", prologuebutton, 75);
            nameTextBox.Visible = true;

        }

        private async void prologuebutton_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                playerName = nameTextBox.Text;
                nameTextBox.Visible = false;
                WinQuest.MainForm.TypeText("A Dream?", this, 75);
                WinQuest.MainForm.TypeText($"Alright then, {playerName}", nameLabel, 75);
                await Task.Delay(50);
                healthPanel.Visible = true;
                WinQuest.MainForm.TypeText("Which is more important?\nPhysical or Mental Health?", healthLabel, 50);
                WinQuest.MainForm.TypeText("Physical Health", physicalRadioButton, 75);
                WinQuest.MainForm.TypeText("Mental Health", mentalRadioButton, 75);
                WinQuest.MainForm.TypeText("Answer", prologuebutton, 75);
                count++;
            } 
            else if (count == 1)
            {
                if (physicalRadioButton.Checked)
                {
                    playerHp = 50;
                    playerMp = 25;
                }
                if (mentalRadioButton.Checked)
                {
                    playerHp = 25;
                    playerMp = 50;
                }

                WinQuest.MainForm.TypeText("A Thought?", this, 75);
                healthPanel.Visible = false;
                await Task.Delay(50);
                problemPanel.Visible = true;
                WinQuest.MainForm.TypeText("How do you solve problems?", problemLabel, 50);
                WinQuest.MainForm.TypeText("Head on without much thought", headOnRadioButton, 75);
                WinQuest.MainForm.TypeText("Stop and make a plan first", planOutRadioButton, 75);
                count++;
            }
            else if (count == 2)
            {
                if (headOnRadioButton.Checked)
                {
                    playerStr = 8;
                    playerMag = 6;
                }
                if (planOutRadioButton.Checked)
                {
                    playerStr = 6;
                    playerMag = 8;
                }

                WinQuest.MainForm.TypeText("My Imagination?", this, 75);
                problemPanel.Visible = false;
                await Task.Delay(50);
                ghostPanel.Visible = true;
                WinQuest.MainForm.TypeText("Do you believe in ghosts?", ghostLabel, 50);
                WinQuest.MainForm.TypeText("Yes", yesGhostRadioButton, 75);
                WinQuest.MainForm.TypeText("No", noGhostRadioButton, 75);
                count++;
            }
            else if (count == 3)
            {
                if (yesGhostRadioButton.Checked)
                {
                    playerDef = 2;
                    playerRes = 4;
                }
                if (noGhostRadioButton.Checked)
                {
                    playerDef = 4;
                    playerRes = 2;
                }

                WinQuest.MainForm.TypeText("A Vision?", this, 75);
                ghostPanel.Visible = false;
                await Task.Delay(50);
                nameLabel.Visible = false;
                adventureLabel.Visible = true;
                WinQuest.MainForm.TypeText($"Well {playerName},\nIt's time to start your quest!", adventureLabel, 75);
                WinQuest.MainForm.TypeText("Start", prologuebutton, 75);
                count++;
            }
            else
            {
                this.Close();
            }

        }
    }
}

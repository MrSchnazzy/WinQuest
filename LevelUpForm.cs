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
    public partial class LevelUpForm : Form
    {
        int tempHp;
        int tempMp;
        int tempStr;
        int tempMag;
        int tempDef;
        int tempRes;

        public LevelUpForm()
        {
            InitializeComponent();

            tempHp = MainForm.playerMaxHp;
            tempMp = MainForm.playerMaxMp;
            tempStr = MainForm.playerStr;
            tempMag = MainForm.playerMag;
            tempDef = MainForm.playerDef;
            tempRes = MainForm.playerRes;

            MainForm.playerMaxHp += 5;
            MainForm.playerMaxMp += 5;
            MainForm.playerStr++;
            MainForm.playerMag++;
            MainForm.playerDef++;
            MainForm.playerRes++;



            maxHpButton.Enabled = true;
            maxMpButton.Enabled = true;
            strButton.Enabled = true;
            magButton.Enabled = true;
            defButton.Enabled = true;
            resButton.Enabled = true;

            MainForm.playerLvl += 1;

            if (MainForm.playerLvl == 2)
            {
                MainForm.TypeText($"You reached level {MainForm.playerLvl}!\nFire spell was learned!", levelUpLabel, 25);
            }
            else if (MainForm.playerLvl == 5)
            {
                MainForm.TypeText($"You reached level {MainForm.playerLvl}!\nShock spell was learned!", levelUpLabel, 25);
            }
            else if (MainForm.playerLvl == 10)
            {
                MainForm.TypeText($"You reached level {MainForm.playerLvl}!\nIce spell was learned!", levelUpLabel, 25);
            }
            else if (MainForm.playerLvl == 15) {
                MainForm.TypeText($"You reached level {MainForm.playerLvl}!\nHoly spell was learned!", levelUpLabel, 25);
            }
            else
            {
                MainForm.TypeText($"You reached level {MainForm.playerLvl}!", levelUpLabel, 25);
            }

            MainForm.TypeText($"{tempHp} --> {MainForm.playerMaxHp}",maxHpLabel,25);

            MainForm.playerHp += 5;
            if (MainForm.playerHp > MainForm.playerMaxHp)
                MainForm.playerHp = MainForm.playerMaxHp;

            MainForm.TypeText($"{tempMp} --> {MainForm.playerMaxMp}", maxMpLabel, 25);

            MainForm.playerMp += 5;
            if (MainForm.playerMp > MainForm.playerMaxMp)
                MainForm.playerMp = MainForm.playerMaxMp;

            MainForm.TypeText($"{tempStr} --> {MainForm.playerStr}", strLabel, 25);
            MainForm.TypeText($"{tempMag} --> {MainForm.playerMag}", magLabel, 25);
            MainForm.TypeText($"{tempDef} --> {MainForm.playerDef}", defLabel, 25);
            MainForm.TypeText($"{tempRes} --> {MainForm.playerRes}", resLabel, 25);
        }

        private async void RaiseStat(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch (button.Tag)
            {
                case "Hp":
                    tempHp = MainForm.playerMaxHp;
                    MainForm.playerMaxHp += 5;
                    MainForm.TypeText($"{tempHp} --> {MainForm.playerMaxHp}", maxHpLabel, 25);

                    MainForm.playerHp += 5;
                    if (MainForm.playerHp > MainForm.playerMaxHp)
                        MainForm.playerHp = MainForm.playerMaxHp;
                    break;

                case "Mp":
                    tempMp = MainForm.playerMaxMp;
                    MainForm.playerMaxMp += 5;
                    MainForm.TypeText($"{tempMp} --> {MainForm.playerMaxMp}", maxMpLabel, 25);

                    MainForm.playerMp += 5;
                    if (MainForm.playerMp > MainForm.playerMaxMp)
                        MainForm.playerMp = MainForm.playerMaxMp;
                    break;

                case "Str":
                    tempStr = MainForm.playerStr;
                    MainForm.playerStr++;
                    MainForm.TypeText($"{tempStr} --> {MainForm.playerStr}", strLabel, 25);
                    break;

                case "Mag":
                    tempMag = MainForm.playerMag;
                    MainForm.playerMag++;
                    MainForm.TypeText($"{tempMag} --> {MainForm.playerMag}", magLabel, 25);
                    break;

                case "Def":
                    tempDef = MainForm.playerDef;
                    MainForm.playerDef++;
                    MainForm.TypeText($"{tempDef} --> {MainForm.playerDef}", defLabel, 25);
                    break;

                case "Res":
                    tempRes = MainForm.playerRes;
                    MainForm.playerRes++;
                    MainForm.TypeText($"{tempRes} --> {MainForm.playerRes}", resLabel, 25);
                    break;
            }

            maxHpButton.Enabled = false;
            maxMpButton.Enabled = false;
            strButton.Enabled = false;
            magButton.Enabled = false;
            defButton.Enabled = false;
            resButton.Enabled = false;

            await Task.Delay(1000);

            this.Close();
        }
    }
}

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
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
            nameLabel.Text = MainForm.playerName;
            levelLabel.Text = MainForm.playerLvl.ToString();
            expLabel.Text = $"{MainForm.playerExp} / {MainForm.expToLevel}";
            hpLabel.Text = $"{MainForm.playerHp} / {MainForm.playerMaxHp}";
            mpLabel.Text = $"{MainForm.playerMp} / {MainForm.playerMaxMp}";
            strLabel.Text = MainForm.playerStr.ToString();
            magLabel.Text = MainForm.playerMag.ToString();
            defLabel.Text = MainForm.playerDef.ToString();
            resLabel.Text = MainForm.playerRes.ToString();

            if (MainForm.treantDead == true) { emeraldPictureBox.Load(@"..\..\Resources\emerald.gif"); }
            if (MainForm.leviDead == true) { sapphirePictureBox.Load(@"..\..\Resources\sapphire.gif"); }
            if (MainForm.dragonDead == true) { rubyPictureBox.Load(@"..\..\Resources\ruby.gif"); }
        }

        private void closeStatusButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

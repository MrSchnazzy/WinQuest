using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinQuest
{
    public partial class MainForm : Form
    {
        public Size bossSize = new Size(254, 199);
        public Size enemySize = new Size(182, 137);

        public Point bossLocation = new Point(286, 107);
        private Point enemyLocation = new Point(325, 169);

        public static string playerName;
        public static int playerLvl = 1;
        public static int expToLevel = 25 * playerLvl;
        public static int playerExp = 0;
        public static int playerMaxHp;
        public static int playerHp;
        public static int playerMaxMp;
        public static int playerMp;
        public static int playerStr;
        public static int playerMag;
        public static int playerDef;
        public static int playerRes;

        public bool isTutorial = true;
        public bool isDead = false;
        public static string currentText;
        public static Control currentControl;
        public int proceedCount = 0;
        public static bool treantDead = false;
        public static bool leviDead = false;
        public static bool dragonDead = false;

        PrologueForm prologue = new PrologueForm();

        public Enemy enemy;
        Enemy dummy = new Enemy("Training Dummy", @"..\..\Resources\trainingDummy.gif", 1, 10, 10, 5, 0, 10, 5, "Fire", "smiled back at you", false, false);

        SoundPlayer attack = new SoundPlayer(Properties.Resources.attacksfx);
        SoundPlayer defend = new SoundPlayer(Properties.Resources.defendsfx);
        SoundPlayer fire = new SoundPlayer(Properties.Resources.firesfx);
        SoundPlayer heal = new SoundPlayer(Properties.Resources.healsfx);
        SoundPlayer holy = new SoundPlayer(Properties.Resources.holysfx);
        SoundPlayer ice = new SoundPlayer(Properties.Resources.icesfx);
        SoundPlayer levelfx = new SoundPlayer(Properties.Resources.levelsfx);
        SoundPlayer run = new SoundPlayer(Properties.Resources.runsfx);
        SoundPlayer shock = new SoundPlayer(Properties.Resources.shocksfx);

        Random rng = new Random();

        public MainForm()
        {
            
            InitializeComponent();
            TypeText("WinQuest", this, 25);
            prologue.ShowDialog();
            Label.CheckForIllegalCrossThreadCalls = false;
            playerName = PrologueForm.playerName;
            playerMaxHp = PrologueForm.playerHp;
            playerMaxMp = PrologueForm.playerMp;
            playerStr = PrologueForm.playerStr;
            playerMag = PrologueForm.playerMag;
            playerDef = PrologueForm.playerDef;
            playerRes = PrologueForm.playerRes;
            playerHp = playerMaxHp;
            playerMp = playerMaxMp;
           
            TypeText($"Your starting stats are:\n" +
                $"Level {playerLvl}\n" +
                $"{playerHp} Hp  {playerMp} Mp\n" +
                $"{playerStr} Str\n" +
                $"{playerMag} Mag\n" +
                $"{playerDef} Def\n" +
                $"{playerRes} Res", textLabel, 25);

            Repose();
        }

        public static async void TypeText(string text, Control lbl, int time)
        {
            await Task.Yield();
            currentText = text;
            currentControl = lbl;
            lbl.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                lbl.Text += text[i];
                await Task.Delay(time);

                if (text != currentText && lbl == currentControl) { await Task.Yield(); lbl.Refresh(); return; }
            }
        }

        private void Battle(Control control)
        {
            battlePanel.Visible = true;
            reposePanel.Visible = false;

            if (control.Name == proceedButton.Name)
            {
                int level = rng.Next(playerLvl, playerLvl + 2);
                int monster = rng.Next(0, 5);
                isDead = false;

                if (isTutorial == true)
                {
                    backgroundPanel.BackgroundImage = WinQuest.Properties.Resources.trainingGround;
                    enemy = dummy;
                }

                if (proceedCount >= 1 && proceedCount <= 10)
                {
                    backgroundPanel.BackgroundImage = WinQuest.Properties.Resources.forest;
                                                                                                       //Level      MaxHp           Hp            EXP          DAM      DEF         RES          
                    Enemy[] forestEnemies = { new Enemy("Mandrake", @"..\..\Resources\mandrake.gif",     level, 10 + level * 5, 10 + level * 5, 5 * level, 6 + level, 6 + level, 4 + level, "Fire", "let out a blood curdling scream!", true, false),
                                              new Enemy("Fairy", @"..\..\Resources\fairy.gif",           level, 8 + level * 5, 8 + level * 5, 5 * level, 5 + level, 5 + level, 4 + level, "Shock", "cast a spell at you!", true, false),
                                              new Enemy("Slime", @"..\..\Resources\slime.gif",           level, 12 + level * 5, 12 + level * 5, 6 * level, 6 + level, 7 + level, 3 + level, "Shock", "spit goo at you!", false, false),
                                              new Enemy("Mushroom Man", @"..\..\Resources\mushroom.gif", level, 10 + level * 5, 10 + level * 5, 6 * level, 5 + level, 5 + level, 5 + level, "Fire", "puffed spores at you!", true, false),
                                              new Enemy("Skull Spider", @"..\..\Resources\spider.gif",   level, 8 + level * 5, 8 + level * 5, 4 * level, 4 + level, 4 + level, 4 + level, "Fire", "bit you!", false, false) };

                    enemy = forestEnemies[monster];
                }

                if (proceedCount == 11)
                {
                    enemyPictureBox.Size = bossSize;
                    enemyPictureBox.Location = bossLocation;

                    Enemy treant = new Enemy("Treant", @"..\..\Resources\treant.gif", 5, 75, 75, 100, 12, 10, 6, "Fire", "called roots out of the ground to attack!", false, true);

                    enemy = treant;
                }

                if (proceedCount >= 12 && proceedCount <= 21)
                {
                    backgroundPanel.BackgroundImage = WinQuest.Properties.Resources.coastalCave;
                    runButton.Enabled = true;

                    enemyPictureBox.Size = enemySize;
                    enemyPictureBox.Location = enemyLocation;
                                                                                                                  //Level      MaxHp           Hp            EXP          DAM      DEF         RES   
                    Enemy[] coastalEnemies = { new Enemy("Cave Bat", @"..\..\Resources\bat.gif",                   level, 10 + level * 5, 10 + level * 5, 7 * level, 8 + level, 6 + level, 6 + level, "Shock", "swooped down and bit you!", false, false),
                                               new Enemy("Giant Crab", @"..\..\Resources\crab.gif",                level, 12 + level * 5, 12 + level * 5, 8 * level, 9 + level, 8 + level, 7 + level, "Fire", "pinched you!", false, false),
                                               new Enemy("Fish Man", @"..\..\Resources\fishman.gif",               level, 15 + level * 5, 15 + level * 5, 10 * level, 10 + level, 7 + level, 7 + level, "Shock", "stabbed you with it's spear", false, false),
                                               new Enemy("Water Elemental", @"..\..\Resources\waterElemental.gif", level, 12 + level * 5, 12 + level * 5, 9 * level, 9 + level, 6 + level, 8 + level, "Shock", "sprayed you with water", true, false),
                                               new Enemy("Marid", @"..\..\Resources\marid.gif",                    level, 15 + level * 5, 15 + level * 5, 12 * level, 10 + level, 7 + level, 9 + level, "Shock", "summoned a whirlpool underneath you!", true, false) };

                    enemy = coastalEnemies[monster];
                }

                if (proceedCount == 22)
                {
                    enemyPictureBox.Size = bossSize;
                    enemyPictureBox.Location = bossLocation;

                    Enemy levi = new Enemy("Leviathan", @"..\..\Resources\leviathan.gif", 10, 100, 100, 150, 25, 12, 18, "Shock", "blasted you with fridged water!", true, true);

                    enemy = levi;
                }

                if (proceedCount >= 23 && proceedCount <= 32)
                {
                    backgroundPanel.BackgroundImage = WinQuest.Properties.Resources.mountain;
                    runButton.Enabled = true;

                    enemyPictureBox.Size = enemySize;
                    enemyPictureBox.Location = enemyLocation;
                                                                                                                //Level      MaxHp           Hp            EXP          DAM      DEF         RES 
                    Enemy[] mountainEnemies = { new Enemy("Goblin", @"..\..\Resources\goblin.gif",                level, 15 + level * 5, 15 + level * 5, 11 * level, 11 + level, 6 + level, 5 + level, "Fire", "smacked you with it's club!", false, false),
                                                new Enemy("Golem", @"..\..\Resources\golem.gif",                  level, 20 + level * 5, 20 + level * 5, 18 * level, 15 + level, 11 + level, 6 + level, "Ice", "threw a boulder at you!", false, false),
                                                new Enemy("Fire Elemental", @"..\..\Resources\fireElemental.gif", level, 15 + level * 5, 15 + level * 5, 13 * level, 12 + level, 7 + level, 10 + level, "Ice", "threw a fireball at you!", true, false),
                                                new Enemy("Harpy", @"..\..\Resources\harpy.gif",                  level, 17 + level * 5, 17 + level * 5, 15 * level, 13 + level, 8 + level, 9 + level, "Shock", "attacked you with her talons!", false, false),
                                                new Enemy("Phoenix", @"..\..\Resources\phoenix.gif",              level, 18 + level * 5, 18 + level * 5, 17 * level, 14 + level, 9 + level, 11 + level, "Ice", "created a scorching heatwave!", true, false) };

                    enemy = mountainEnemies[monster];
                }

                if (proceedCount == 33)
                {
                    enemyPictureBox.Size = bossSize;
                    enemyPictureBox.Location = bossLocation;
                                
                    Enemy dragon = new Enemy("Dragon", @"..\..\Resources\dragon.gif", 15, 125, 125, 225, 35, 26, 25, "Ice", "shot a breath of fire at you!", true, true);

                    enemy = dragon;
                }

                if (proceedCount >= 34 && proceedCount <= 43)
                {
                    backgroundPanel.BackgroundImage = WinQuest.Properties.Resources.crypt;
                    runButton.Enabled = true;

                    enemyPictureBox.Size = enemySize;
                    enemyPictureBox.Location = enemyLocation;
                                                                                                  //Level      MaxHp           Hp            EXP          DAM      DEF         RES
                    Enemy[] cryptEnemies = { new Enemy("Undead", @"..\..\Resources\undead.gif",     level, 15 + level * 5, 15 + level * 5, 15 * level, 15 + level, 8 + level, 9 + level, "Holy", "tried to eat your brains!", false, false),
                                             new Enemy("Skeleton", @"..\..\Resources\skeleton.gif", level, 16 + level * 5, 16 + level * 5, 16 * level, 16 + level, 11 + level, 10 + level, "Holy", "attcked with their sword!", false, false),
                                             new Enemy("Banshee", @"..\..\Resources\banshee.gif",   level, 14 + level * 5, 14 + level * 5, 15 * level, 15 + level, 9 + level, 13 + level, "Holy", "let out a haunting wail!", true, false),
                                             new Enemy("Shade", @"..\..\Resources\shade.gif",       level, 14 + level * 5, 14 + level * 5, 14 * level, 14 + level, 9 + level, 11 + level, "Holy", "engulfed you in shadows!", true, false),
                                             new Enemy("Wraith", @"..\..\Resources\wraith.gif",     level, 16 + level * 5, 16 + level * 5, 18 * level, 17 + level, 11 + level, 14 + level, "Holy", "chilled your very soul!", true, false)};

                    enemy = cryptEnemies[monster];
                }

                if (proceedCount == 44)
                {
                    enemyPictureBox.Size = bossSize;
                    enemyPictureBox.Location = bossLocation;

                    Enemy necro = new Enemy("Necromancer", @"..\..\Resources\necromancer.gif", 20, 150, 150, 300, 40, 28, 35, "Holy", "cast unholy magic at you!", true, true);

                    enemy = necro;
                }

                TypeText($"A level {enemy.Level} {enemy.Name} appeared!", textLabel, 25);
                toolTip.SetToolTip(enemyPictureBox, enemy.Name);
                enemyPictureBox.Load(enemy.File);
                proceedCount++;
            }
            if (control.Name == attackButton.Name)
            {
                Attack(enemy);
            }
            if (control.Name == defendButton.Name)
            {
                Defend(enemy);
            }
            if (control.Name == magicListBox.Name)
            {
                Magic(enemy);
            }
            if (control.Name == runButton.Name)
            {
                enemy.HP = enemy.MaxHp;
                Run();
            }

            if (enemy.IsBoss == true) { runButton.Enabled = false; }
        }

        private void Repose()
        {
            reposePanel.Visible = true;
            battlePanel.Visible = false;
        }

        private async void Attack(Enemy enemy)
        {
            if (playerHp > 0 && enemy.HP > 0)
            {
                int playerDamage = playerStr - enemy.Def + 7;
                int enemyDamage;

                if (enemy.IsMagic == true)
                    enemyDamage = enemy.Dam - playerRes;
                else
                    enemyDamage = enemy.Dam - playerDef;

                if (playerDamage < 0)
                    playerDamage = 0;

                if (enemyDamage < 0)
                    enemyDamage = 0;

                enemy.HP -= playerDamage;

                enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                attack.Play();
                enemyPictureBox.Load(@"..\..\Resources\slash.gif");
                await Task.Delay(250);
                enemyPictureBox.BackgroundImage = null;
                enemyPictureBox.Image = null;
                await Task.Delay(250);
                enemyPictureBox.Load(enemy.File);
                TypeText($"{playerDamage} damage to the {enemy.Name}", textLabel, 25);
                await Task.Delay(2000);

                if (enemy.HP <= 0)
                {
                    enemyPictureBox.Image = null;
                    TypeText($"The {enemy.Name} is defeated\n\n{enemy.Exp} Exp gained", textLabel, 25);
                    await Task.Delay(1000);
                    if (isDead != true)
                    {
                        playerExp += enemy.Exp;
                        if (playerExp >= expToLevel)
                        {
                            int remainingExp = playerExp - expToLevel;
                            playerExp = 0;
                            playerExp += remainingExp;
                            LevelUp();
                        }
                    }
                    isDead = true;
                    CheckBoss(enemy);
                    enemy.HP = enemy.MaxHp;
                    isTutorial = false;
                    Repose();
                }
                else
                {
                    if (enemy.Name == "Lich") { LichAttack(enemy.Dam); }
                    else
                    {
                        playerHp -= enemyDamage;

                        TypeText($"The {enemy.Name} {enemy.Text}\n\n" +
                                 $"{enemyDamage} damage to {playerName}\n" +
                                 $"{playerHp} Hp remaining", textLabel, 25);

                        if (playerHp <= 0)
                        {
                            Death();
                        }
                    }
                }
                
            }
        }

        private async void Magic(Enemy enemy)
        {
            string magicSelected = magicListBox.SelectedItem?.ToString();

            if (magicSelected != null)
            {
                if (playerHp > 0 && enemy.HP > 0)
                {
                    int playerDamage = playerMag - enemy.Res;
                    int weakDamage;
                    int enemyDamage;

                    if (enemy.IsMagic == true)
                        enemyDamage = enemy.Dam - playerRes;
                    else
                        enemyDamage = enemy.Dam - playerDef;

                    if (playerDamage < 0)
                        playerDamage = 0;

                    if (enemyDamage < 0)
                        enemyDamage = 0;

                    if (enemy.IsBoss == true) { runButton.Enabled = false; }

                    switch (magicSelected)
                    {
                        case "Heal":

                            if (playerHp != playerMaxHp)
                            {
                                if (playerMp >= 5)
                                {
                                    int healedHp = playerMag * 2;
                                    playerHp += healedHp;

                                    if (playerHp > playerMaxHp)
                                        playerHp = playerMaxHp;

                                    playerMp -= 5;

                                    heal.Play();

                                    TypeText($"You healed {healedHp} Hp\n" +
                                             $"{playerHp} Hp remaining\n" +
                                             $"{playerMp} Mp remaining", textLabel, 25);
                                    await Task.Delay(2000);
                                }
                                else
                                {
                                    TypeText("You do not have enough Mp to cast that", textLabel, 25);
                                    return;
                                }
                            }
                            else
                            {
                                TypeText("You are already at full health", textLabel, 25);
                                return;
                            }
                            break;

                        case "Fire":

                            if (playerMp >= 7)
                            {
                                if (enemy.Weak == "Fire")
                                {
                                    weakDamage = (playerDamage + 3) * 2;
                                    enemy.HP -= weakDamage;
                                    playerMp -= 7;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    fire.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\fire.gif");
                                    await Task.Delay(250);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"You hit their weakness!!\n{weakDamage} fire damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 15);
                                    await Task.Delay(2000);
                                }
                                else
                                {
                                    playerDamage += 3;
                                    enemy.HP -= playerDamage;
                                    playerMp -= 7;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    fire.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\fire.gif");
                                    await Task.Delay(250);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"{playerDamage} fire damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 25);
                                    await Task.Delay(2000);
                                }
                            }
                            else
                            {
                                TypeText("You do not have enough Mp to cast that", textLabel, 25);
                                return;
                            }
                            break;

                        case "Shock":

                            if (playerMp >= 10)
                            {
                                if (enemy.Weak == "Shock")
                                {
                                    weakDamage = (playerDamage + 5) * 2;
                                    enemy.HP -= weakDamage;
                                    playerMp -= 10;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    shock.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\shock.gif");
                                    await Task.Delay(250);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"You hit their weakness!!\n{weakDamage} shock damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 15);
                                    await Task.Delay(2000);
                                }
                                else
                                {
                                    playerDamage += 5;
                                    enemy.HP -= playerDamage;
                                    playerMp -= 10;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    shock.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\shock.gif");
                                    await Task.Delay(250);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"{playerDamage} shock damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 25);
                                    await Task.Delay(2000);
                                }
                            }
                            else
                            {
                                TypeText("You do not have enough Mp to cast that", textLabel, 25);
                                return;
                            }
                            break;

                        case "Ice":

                            if (playerMp >= 12)
                            {
                                if (enemy.Weak == "Ice")
                                {
                                    weakDamage = (playerDamage + 7) * 2;
                                    enemy.HP -= weakDamage;
                                    playerMp -= 12;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    ice.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\ice.gif");
                                    await Task.Delay(850);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"You hit their weakness!!\n{weakDamage} ice damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 15);
                                    await Task.Delay(2000);
                                }
                                else
                                {
                                    playerDamage += 7;
                                    enemy.HP -= playerDamage ;
                                    playerMp -= 12;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    ice.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\ice.gif");
                                    await Task.Delay(850);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"{playerDamage} ice damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 25);
                                    await Task.Delay(2000);
                                }
                            }
                            else
                            {
                                TypeText("You do not have enough Mp to cast that", textLabel, 25);
                                return;
                            }
                            break;

                        case "Holy":

                            if (playerMp >= 15)
                            {
                                if (enemy.Weak == "Holy")
                                {
                                    weakDamage = (playerDamage + 10) * 2;
                                    enemy.HP -= weakDamage;
                                    playerMp -= 15;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    holy.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\holy.gif");
                                    await Task.Delay(850);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"You hit their weakness!!\n{weakDamage} holy damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 15);
                                    await Task.Delay(2000);
                                }
                                else
                                {
                                    playerDamage += 10;
                                    enemy.HP -= playerDamage;
                                    playerMp -= 15;

                                    enemyPictureBox.BackgroundImage = Image.FromFile(enemy.File);
                                    holy.Play();
                                    enemyPictureBox.Load(@"..\..\Resources\holy.gif");
                                    await Task.Delay(850);
                                    enemyPictureBox.BackgroundImage = null;
                                    enemyPictureBox.Image = null;
                                    await Task.Delay(250);
                                    enemyPictureBox.Load(enemy.File);
                                    TypeText($"{playerDamage} holy damage to the {enemy.Name}\n{playerMp} Mp remaining", textLabel, 25);
                                    await Task.Delay(2000);
                                }
                            }
                            else
                            {
                                TypeText("You do not have enough Mp to cast that", textLabel, 25);
                                return;
                            }
                            break;
                    }

                    if (enemy.HP <= 0)
                    {
                        enemyPictureBox.Image = null;
                        TypeText($"The {enemy.Name} is defeated\n\n{enemy.Exp} Exp gained", textLabel, 25);
                        await Task.Delay(1000);
                        if (isDead != true)
                        {
                            playerExp += enemy.Exp;
                            if (playerExp >= expToLevel)
                            {
                                int remainingExp = playerExp - expToLevel;
                                playerExp = 0;
                                playerExp += remainingExp;
                                LevelUp();
                            }
                        }
                        isDead = true;
                        CheckBoss(enemy);
                        enemy.HP = enemy.MaxHp;
                        isTutorial = false;
                        Repose();
                    }
                    else
                    {
                        if (enemy.Name == "Lich") { LichAttack(enemy.Dam); }
                        else
                        {
                            playerHp -= enemyDamage;

                            TypeText($"The {enemy.Name} {enemy.Text}\n\n" +
                                     $"{enemyDamage} damage to {playerName}\n" +
                                     $"{playerHp} Hp remaining", textLabel, 25);

                            if (playerHp <= 0)
                            {
                                Death();
                            }
                        }
                    }
                }
                if (enemy.IsBoss == true) { runButton.Enabled = false; }
            }
            else
            {
                attackButton.Enabled = true;
                defendButton.Enabled = true;
                runButton.Enabled = true;
                magicButton.Visible = true;
                magicListBox.Visible = false;
                if (enemy.IsBoss == true) { runButton.Enabled = false; }
            }
        }

        private void Defend(Enemy enemy)
        {
            if (playerHp > 0)
            {
                if (enemy.Name == "Lich") { LichDefend(enemy.Dam); }
                else
                {
                    int enemyDamage;

                    if (enemy.IsMagic == true)
                        enemyDamage = enemy.Dam - playerRes;
                    else
                        enemyDamage = enemy.Dam - playerDef;

                    if (enemyDamage < 0)
                        enemyDamage = 0;

                    enemyDamage /= 2;

                    playerHp -= enemyDamage;
                    playerMp += 5;

                    if (playerMp > playerMaxMp)
                        playerMp = playerMaxMp;

                    defend.Play();

                    TypeText($"You defended while the {enemy.Name} {enemy.Text}\n\n" +
                             $"{enemyDamage} damage to {playerName}\n" +
                             $"{playerHp} Hp remaining\n" +
                             $"{playerMp} Mp remaining", textLabel, 25);

                    if (playerHp <= 0)
                    {
                        Death();
                    }
                }
            }
        }

        private void Run()
        {
            if (isTutorial == true)
            {
                TypeText("Don't run from the Training Dummy\n\nLearn how to fight!", textLabel, 25);
            }
            else
            {
                enemyPictureBox.Image = null;
                run.Play();
                TypeText("You ran from the battle", textLabel, 25);
                Repose();
            }
        }

        private void LevelUp()
        {
            levelfx.Play();
            LevelUpForm levelUp = new LevelUpForm();
            levelUp.ShowDialog(this);
            if (playerLvl == 2)
            {
                magicListBox.Items.Add("Fire");
            }
            if (playerLvl == 5)
            {
                magicListBox.Items.Add("Shock");
            }
            if (playerLvl == 10)
            {
                magicListBox.Items.Add("Ice");
            }
            if (playerLvl == 15)
            {
                magicListBox.Items.Add("Holy");
            }

            expToLevel = 25 * playerLvl;
        }

        private void Death()
        {
            MessageBox.Show("You have died! The world is doomed!", "Death");
            this.Close();
        }

        private void CheckBoss(Enemy boss)
        {
            if (boss.Name == "Treant") { TypeText("You received the emerald!", textLabel, 25); treantDead = true; }
            if (boss.Name == "Leviathan") { TypeText("You received the sapphire!", textLabel, 25); leviDead = true; }
            if (boss.Name == "Dragon") { TypeText("You received the ruby!", textLabel, 25); dragonDead = true; }

            if (boss.Name == "Necromancer")
            {
                MessageBox.Show("You did it! The world is saved!", "Success");
                MessageBox.Show("Wait...What is happening?..", "Huh?");

                Enemy lich = new Enemy("Lich", @"..\..\Resources\lich.gif", 25, 200, 200, 300, 40, 32, 37, "Holy", "cast unholy magic at you!", true, true);

                enemy = lich;

                isDead = false;
                TypeText($"The Necromancer used the last of his power to become a Lich!!", textLabel, 25);
                toolTip.SetToolTip(enemyPictureBox, enemy.Name);
                enemyPictureBox.Load(enemy.File);

                return;
            }

            if (boss.Name == "Lich") { MessageBox.Show("You finally did it! The world is saved!", "Finally"); this.Close(); }
        }

        private void LichAttack(int lichDam)
        {
            int enemyDamage;
            int lichChoice = rng.Next(2);

            if (lichChoice == 0)
            {
                enemyDamage = lichDam - playerDef;

                if (enemyDamage < 0) { enemyDamage = 0; }

                playerHp -= enemyDamage;

                TypeText($"The {enemy.Name} performed a melee attack on you!\n\n" +
                         $"{enemyDamage} damage to {playerName}\n" +
                         $"{playerHp} Hp remaining", textLabel, 25);

                if (playerHp <= 0)
                {
                    Death();
                }

            }
            else
            {
                enemyDamage = lichDam - playerRes;
                int lichHeal = enemyDamage / 2;

                enemy.HP += lichHeal;
                if ( enemy.HP > enemy.MaxHp) { enemy.HP = enemy.MaxHp; }

                if (enemyDamage < 0) { enemyDamage = 0; }

                playerHp -= enemyDamage;

                TypeText($"The {enemy.Name} drained your lifeforce!\n" +
                         $"The {enemy.Name} healed {lichHeal} Hp\n\n" +
                         $"{enemyDamage} damage to {playerName}\n" +
                         $"{playerHp} Hp remaining", textLabel, 25);

                if (playerHp <= 0)
                {
                    Death();
                }
            }
        }

        private void LichDefend(int lichDam)
        {
            int enemyDamage;
            int lichChoice = rng.Next(2);

            if (lichChoice == 0)
            {
                enemyDamage = (lichDam - playerDef) / 2;

                if (enemyDamage < 0) { enemyDamage = 0; }

                playerHp -= enemyDamage;
                playerMp += 5;

                defend.Play();

                TypeText($"You blocked while the {enemy.Name} performed a melee attack on you!\n\n" +
                         $"{enemyDamage} damage to {playerName}\n" +
                         $"{playerHp} Hp remaining", textLabel, 25);

                if (playerHp <= 0)
                {
                    Death();
                }

            }
            else
            {
                enemyDamage = (lichDam - playerRes) / 2;
                int lichHeal = enemyDamage / 2;

                enemy.HP += lichHeal;
                if (enemy.HP > enemy.MaxHp) { enemy.HP = enemy.MaxHp; }

                if (enemyDamage < 0) { enemyDamage = 0; }

                playerHp -= enemyDamage;
                playerMp += 5;

                defend.Play();

                TypeText($"You blocked while the {enemy.Name} drained your lifeforce!\n" +
                         $"The {enemy.Name} healed {lichHeal} Hp\n\n" +
                         $"{enemyDamage} damage to {playerName}\n" +
                         $"{playerHp} Hp remaining", textLabel, 25);

                if (playerHp <= 0)
                {
                    Death();
                }
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (isDead == false)
            {

                Battle(attackButton);
            }
            else
            {
                return;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            restButton.Enabled = true;
            Battle(proceedButton);
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;
            defendButton.Enabled = false;
            runButton.Enabled = false;
            magicButton.Visible = false;
            magicListBox.Visible = true;
        }

        private void magicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Battle(magicListBox);
            attackButton.Enabled = true;
            defendButton.Enabled = true;
            if (enemy.IsBoss == false) { runButton.Enabled = true; }
            magicButton.Visible = true;
            magicListBox.Visible = false;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Battle(runButton);
        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            Battle(defendButton);
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            StatusForm status = new StatusForm();
            status.ShowDialog();
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            if (playerHp == playerMaxHp && playerMp == playerMaxMp)
            {

                TypeText("You are already fully rested", textLabel, 25);
            
            }
            else
            {
                playerHp += playerMaxHp / 2;
                if (playerHp > playerMaxHp)
                    playerHp = playerMaxHp;

                playerMp += playerMaxMp / 2;
                if (playerMp > playerMaxMp)
                    playerMp = playerMaxMp;

                TypeText($"You rested and healed\n\n{playerHp} Hp remaining\n{playerMp} Mp remaining", textLabel, 25);
            }

            restButton.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinQuest
{
    public class Enemy
    {
        public Enemy(string name, string file, int lvl, int maxHp, int hp, int exp, int dam, int def, int res, string weak, string text, bool isMagic, bool isBoss)
        {
            Name = name;
            File = file;
            Level = lvl;
            MaxHp = maxHp;
            HP = hp;
            Exp = exp;
            Dam = dam;
            Def = def;
            Res = res;
            Weak = weak;
            Text = text;
            IsMagic = isMagic;
            IsBoss = isBoss;
        }

        public string Name { get; set; }
        public string File { get; set; }
        public int Level { get; set; }
        public int MaxHp { get; set; }
        public int HP { get; set; }
        public int Exp { get; set; }
        public int Dam { get; set; }
        public int Def { get; set; }
        public int Res { get; set; }
        public string Weak { get; set; }
        public string Text { get; set; }
        public bool IsMagic { get; set; }
        public bool IsBoss { get; set; }
    }
}

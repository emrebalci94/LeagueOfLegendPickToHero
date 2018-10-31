using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
     class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int AttackPower { get; set; }
        public HeroTypes Type { get; set; }
        public Hero()
        {
            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
        }

        public string GetToStatistics()
        {
            return $"Tip:{Type}\nİsim:{Name}\nSağlık:{Hp}\nAtak Gücü:{AttackPower}";
        }

    }
}

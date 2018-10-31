using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    class Warrior : Hero
    {
        private readonly HeroTypes _type;
        public Warrior()
        {

            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
            _type = HeroTypes.Warrior;
        }

        public override string GetToStatistics()
        {
            return $"Tip:{_type}\nİsim:{Name}\nSağlık:{Hp}\nAtak Gücü:{AttackPower}";
        }
    }
}

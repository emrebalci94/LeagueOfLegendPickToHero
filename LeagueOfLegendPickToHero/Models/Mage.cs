using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    class Mage : Hero
    {
        private readonly HeroTypes _type;
        public Mage()
        {

            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
            _type = HeroTypes.Mage;
        }

        public override string GetToStatistics()
        {
            return $"Tip:{_type}\nİsim:{Name}\nSağlık:{Hp}\nAtak Gücü:{AttackPower}";
        }
    }
}

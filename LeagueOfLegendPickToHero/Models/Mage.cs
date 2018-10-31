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
        public Mage(HealthTypes health)
        {

            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
            _type = HeroTypes.Mage;
            switch (health)
            {
                case HealthTypes.MaviBuyu:
                    Hp += 50;
                    break;
                case HealthTypes.YesilBuyu:
                    Hp += 30;
                    break;
                default:
                    Hp += 0;
                    break;
            }
        }

        public override string GetToStatistics()
        {
            return $"Tip:{_type}\nİsim:{Name}\nSağlık:{Hp}\nAtak Gücü:{AttackPower}";
        }
    }
}

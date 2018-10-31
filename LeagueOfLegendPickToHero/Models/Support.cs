using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    class Support : Hero
    {
        private readonly HeroTypes _type;
        public Support(WeaponTypes weapon)
        {

            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
            _type = HeroTypes.Support;
            switch (weapon)
            {
                case WeaponTypes.Kılıç:
                    AttackPower += 10;
                    break;
                case WeaponTypes.Silah:
                    AttackPower += 20;
                    break;
                default:
                    AttackPower += 0;
                    break;
            }

        }

        public override string GetToStatistics()
        {
            return $"Tip:{_type}\nİsim:{Name}\nSağlık:{Hp}\nAtak Gücü:{AttackPower}";
        }
    }
}

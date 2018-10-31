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
        public Warrior(WeaponTypes weapon,HealthTypes health)
        {

            Name = HeroNameHelper.Instance.GetToRandomName();
            AttackPower = RandomHelper.Instance.Next(100);
            Hp = RandomHelper.Instance.Next(100);
            _type = HeroTypes.Warrior;
            switch (weapon)
            {
                case WeaponTypes.Kılıç:
                    AttackPower += 20;
                    break;
                case WeaponTypes.Silah:
                    AttackPower += 50;
                    break;
                default:
                    AttackPower += 0;
                    break;
            }

            switch (health)
            {
                case HealthTypes.MaviBuyu:
                    Hp += 10;
                    break;
                case HealthTypes.YesilBuyu:
                    Hp += 5;
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

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
        public Warrior(WeaponTypes weapon,HealthTypes health)
        {
            Type = HeroTypes.Warrior;
            switch (weapon)
            {
                case WeaponTypes.Sword:
                    AttackPower += 20;
                    break;
                case WeaponTypes.Pistol:
                    AttackPower += 50;
                    break;
                default:
                    AttackPower += 0;
                    break;
            }

            switch (health)
            {
                case HealthTypes.BlueSpell:
                    Hp += 10;
                    break;
                case HealthTypes.GreenSpell:
                    Hp += 5;
                    break;
                default:
                    Hp += 0;
                    break;
            }
        }

    }
}

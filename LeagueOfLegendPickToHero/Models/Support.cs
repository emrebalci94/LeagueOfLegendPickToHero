using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    class Support : Hero
    {
        public Support(WeaponTypes weapon)
        {
            Type = HeroTypes.Support;
            switch (weapon)
            {
                case WeaponTypes.Sword:
                    AttackPower += 10;
                    break;
                case WeaponTypes.Pistol:
                    AttackPower += 20;
                    break;
                default:
                    AttackPower += 0;
                    break;
            }

        }

    }
}

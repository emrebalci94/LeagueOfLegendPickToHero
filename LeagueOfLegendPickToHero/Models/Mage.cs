using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    class Mage : Hero
    {
        public Mage(HealthTypes health)
        {       
            Type = HeroTypes.Mage;
            switch (health)
            {
                case HealthTypes.BlueSpell:
                    Hp += 50;
                    break;
                case HealthTypes.GreenSpell:
                    Hp += 30;
                    break;
                default:
                    Hp += 0;
                    break;
            }
        }

    }
}

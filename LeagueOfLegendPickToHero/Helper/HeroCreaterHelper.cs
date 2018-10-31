using LeagueOfLegendPickToHero.Models;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Helper
{
    class HeroCreaterHelper
    {
        private HeroCreaterHelper()
        {

        }
        private static HeroCreaterHelper instance;
        public static HeroCreaterHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeroCreaterHelper();
                }
                return instance;
            }
        }

        public Hero GetHero(HeroTypes type)
        {
            switch (type)
            {
                case HeroTypes.Warrior:
                    return new Warrior();
                case HeroTypes.Mage:
                    return new Mage();
                case HeroTypes.Support:
                    return new Support();
                default:
                    return new Warrior();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LeagueOfLegendPickToHero.Models.Enums
{
    enum HeroTypes
    {
        [Description("Savaşçı")]
        Warrior = 1,
        [Description("Büyücü")]
        Mage,
        [Description("Destek")]
        Support
    }
}

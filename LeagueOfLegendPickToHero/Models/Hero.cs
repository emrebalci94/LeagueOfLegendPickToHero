using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Models
{
    abstract class Hero
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int AttackPower { get; set; }

        public abstract string GetToStatistics();

    }
}

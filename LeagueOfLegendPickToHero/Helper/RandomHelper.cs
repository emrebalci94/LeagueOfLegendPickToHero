using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueOfLegendPickToHero.Helper
{
    class RandomHelper
    {
        private RandomHelper()
        {

        }
        private static Random instance;
        public static Random Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Random();
                }
                return instance;
            }
        }
    }
}

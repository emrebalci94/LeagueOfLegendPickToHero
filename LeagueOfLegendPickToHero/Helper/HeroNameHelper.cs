using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeagueOfLegendPickToHero.Helper
{
    class HeroNameHelper
    {
        private  readonly string[] _names;
        private HeroNameHelper()
        {
            string names = File.ReadAllText("Helper/heroNames.txt");
            _names = names.Split('\n');
        }

        public string GetToRandomName()
        {
            Random random = new Random();
            int index = random.Next(_names.Length);
            return _names[index];
        }

        private static HeroNameHelper instance;
        public static HeroNameHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeroNameHelper();
                }
                return instance;
            }
        }


    }
}

using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.IO;

namespace LeagueOfLegendPickToHero
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("League Of Legend'a HOŞGELDİNİZ !");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN TİPİNİ SEÇİNİZ----------------");

            foreach (HeroTypes item in Enum.GetValues(typeof(HeroTypes)))
            {
                Console.Write($"{item}({(int)item}) \t");

            }
            Console.Write("\t :");
            bool isSelected = int.TryParse(Console.ReadLine(), out int selectedType);
            
            if (isSelected && Enum.IsDefined(typeof(HeroTypes), selectedType))
            {
                Enum.TryParse(selectedType.ToString(), out HeroTypes heroType);
                Hero hero = HeroCreaterHelper.Instance.GetHero(heroType);
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine(hero.GetToStatistics());
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Lütfen geçerli bir tip seçiniz.");
            }

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------KAPATMAK İÇİN BİR TUŞA BASINIZ-------------------");

            Console.ReadKey();
        }
    }
}

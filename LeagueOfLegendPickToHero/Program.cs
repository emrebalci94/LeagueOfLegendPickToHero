using LeagueOfLegendPickToHero.Helper;
using LeagueOfLegendPickToHero.Models;
using LeagueOfLegendPickToHero.Models.Enums;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LeagueOfLegendPickToHero
{
    class Program
    {
        static void ForEachToEnum(Type _enum)
        {
            foreach (IConvertible item in Enum.GetValues(_enum))
            {
                Console.Write($"{item.GetDescription()}({(int)item}) \t");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("League Of Legend'a HOŞGELDİNİZ !");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN TİPİNİ SEÇİNİZ----------------");

            foreach (HeroTypes item in Enum.GetValues(typeof(HeroTypes)))
            {
                Console.Write($"{item.GetDescription()}({(int)item}) \t");

            }
            Console.Write("\t :");
            bool isSelected = int.TryParse(Console.ReadLine(), out int selectedType);

            if (isSelected && Enum.IsDefined(typeof(HeroTypes), selectedType))
            {

                Console.Write("\t :");
                Enum.TryParse(selectedType.ToString(), out HeroTypes heroType);
                Hero hero = null;
                bool isHealthSelected, isWeaponSelected;
                int selectedHealth, selectedWeapon;
                switch (heroType)
                {
                    case HeroTypes.Warrior:
                        Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN SİLAHINI SEÇİNİZ----------------");
                        ForEachToEnum(typeof(WeaponTypes));
                        Console.Write("\t :");
                        isWeaponSelected = int.TryParse(Console.ReadLine(), out selectedWeapon);
                        if (isWeaponSelected && Enum.IsDefined(typeof(WeaponTypes), selectedWeapon))
                        {
                            Enum.TryParse(selectedWeapon.ToString(), out WeaponTypes weapon);

                            Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN SAĞLIĞINI SEÇİNİZ----------------");
                            ForEachToEnum(typeof(HealthTypes));
                            Console.Write("\t :");
                            isHealthSelected = int.TryParse(Console.ReadLine(), out selectedHealth);
                            if (isHealthSelected && Enum.IsDefined(typeof(HealthTypes), selectedHealth))
                            {
                                Enum.TryParse(selectedHealth.ToString(), out HealthTypes health);

                                hero = new Warrior(weapon, health);
                            }
                            else
                            {
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("Lütfen geçerli bir sağlık seçiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Lütfen geçerli bir silah seçiniz.");
                        }
                        break;
                    case HeroTypes.Mage:
                        Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN SAĞLIĞINI SEÇİNİZ----------------");
                        ForEachToEnum(typeof(HealthTypes));
                        Console.Write("\t :");
                        isHealthSelected = int.TryParse(Console.ReadLine(), out selectedHealth);
                        if (isHealthSelected && Enum.IsDefined(typeof(HealthTypes), selectedHealth))
                        {
                            Enum.TryParse(selectedHealth.ToString(), out HealthTypes health);
                            hero = new Mage(health);
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Lütfen geçerli bir sağlık seçiniz.");
                        }
                        break;
                    case HeroTypes.Support:
                        Console.WriteLine("----------------LÜTFEN KAHRAMANINIZIN SİLAHINI SEÇİNİZ----------------");
                        ForEachToEnum(typeof(WeaponTypes));
                        Console.Write("\t :");
                        isWeaponSelected = int.TryParse(Console.ReadLine(), out selectedWeapon);
                        if (isWeaponSelected && Enum.IsDefined(typeof(WeaponTypes), selectedWeapon))
                        {
                            Enum.TryParse(selectedWeapon.ToString(), out WeaponTypes weapon);
                            hero = new Support(weapon);
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Lütfen geçerli bir silah seçiniz.");
                        }
                        break;
                    default:
                        break;
                }



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

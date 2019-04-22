using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameContext())
            {
               var sword = new Weapon
               {
                   Name = "Адский клинок",
                   Damage=9999
               };
               var firstHero = new Hero
               {
                   Nickname = "Покоритель хаоса",
                   Level = 100,
                   Weapon=sword
               };
               var secondHero = new Hero
               {
                   Nickname = "Владыка преисподней",
                   Level = 101,
                   Weapon = sword
               };

                //context.Weapons.Add(sword);
                //context.Heroes.Add(firstHero);
                //context.Heroes.Add(secondHero);
                //context.SaveChanges();
                //  ---------------------------------------------LINQ запросы
                //    List<Hero> result = new List<Hero>();
                //foreach(var hero in context.Heroes.ToList())
                //    {
                //        if(hero.Nickname.Contains("а"))
                //        {
                //            result.Add(hero);
                //        }
                //    }
                //--------------------------------------------------2 СПОСОБ LINQ ЗАПРОСЫ
                var result = from hero 
                             in context.Heroes
                             where hero.Nickname.Contains("а")
                             orderby hero.Nickname 
                             descending
                             select hero;
                foreach (var Heroes in result)
                    Console.WriteLine(Heroes);
                //var anotherResult = context.Heroes.Where(hero => hero.Nickname.Contains("а")).ToList();
                //var sword = context.Weapons.SingleOrDefault();

                //var name = "Vasya";
                //int length = name.GetLenght();
            }
   
        }
    }
}

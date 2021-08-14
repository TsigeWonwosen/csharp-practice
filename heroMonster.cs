using System;

namespace heroMonster
{
    public class HeroMonster
    {
        public string winner()
        {
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int loss = dice.Next(1, 11);
                monster -= loss;
                Console.WriteLine($"Monster was damaged and lost {loss} health and now has {monster} health.");
                if (monster > 0)
                {
                    loss = dice.Next(1, 11);
                    hero -= loss;
                    Console.WriteLine($"Hero was damaged and lost {loss} health and now has {hero} health.");
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"{hero} -- {monster}");

            } while (hero > 0 && monster > 0);
            Console.WriteLine($"{hero} -- {monster}");

            return hero > 0 ? "Hero is winner" : "monster is winner";
        }


    }
}
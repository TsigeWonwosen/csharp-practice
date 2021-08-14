using System;
using taskManager;
using heroMonster;
using dataTypes;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroMonster result = new HeroMonster();
            DataTypes data = new DataTypes();

            data.dataTypes();
            Console.WriteLine(result.winner());

            foreach (string b in args)
                Console.WriteLine(b + "   ");

            TaskManager test = new TaskManager();

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
            test.stuff();
            Console.WriteLine(test.Reverse("Wondwosen"));

        }


    }
}

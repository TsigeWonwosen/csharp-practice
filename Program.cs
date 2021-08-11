using System;
using taskManager;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(Reverse("Wondwosen"));

        }

        private static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

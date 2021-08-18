using System;

namespace firstProject.task
{
    public class ArrayMethods
    {
        public void arrayMethods()
        {

            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("Clear Array Element.");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            if (pallets[0] != null)
                Console.WriteLine($"After: {pallets[0].ToLower()}");

            Console.WriteLine("Resize Array .");
            Array.Resize(ref pallets, pallets.Length + 2);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            Console.WriteLine("Clearing Array by Resize Method. From end of the array.");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*******");
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] pangramArray = pangram.Split(" ");
            string[] reversePangram = new string[pangramArray.Length];
            // Console.WriteLine($"{pangramArray.ToString()}");
            int i = 0;
            foreach (var word in pangramArray)
            {

                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                reversePangram[i] = new string(charArray);
                i++;
            }

            string res = String.Join(" ", reversePangram);
            Console.WriteLine(res);
            Console.WriteLine($"{reversePangram[0]}");

            Console.WriteLine("*******");

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            // Your code here

            string[] newOrder = orderStream.Split(",");

            foreach (var word in newOrder)
            {
                if (word.StartsWith('B'))
                {
                    Console.WriteLine(word);
                }
            }
        }




    }


}
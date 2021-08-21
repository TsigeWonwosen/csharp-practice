using System;
using System.Collections;

namespace firstProject
{

    // the ArrayList is a non-generic collection of objects whose size increases dynamically.
    class ArrayListClass
    {
        public ArrayListClass()
        {

            var arrayList = new ArrayList();

            arrayList.Add("wonde");
            arrayList.Add("Abel");
            arrayList.Add("");
            arrayList.Add("Chuchu");
            arrayList.Add(4.5);

            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();

            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("Ethiopia");

            arrayList.AddRange(arlist2);
            arrayList.AddRange(myQ);
            arrayList.AddRange(arr);

            foreach (var i in arrayList)
            {
                Console.Write(i + "  ");

            }

            for (int i = 0; i < arrayList.Count; i++)
                System.Console.Write(i + " ");
            System.Console.WriteLine();
            arrayList.Remove(null); //Removes first occurance of null
            arrayList.RemoveAt(4); //Removes element at index 4
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item 

            Console.WriteLine("\n Aftter Remove.\n");
            foreach (var i in arrayList)
            {
                Console.Write(i + "  ");

            }
            Console.WriteLine("Example: Check for Elements.");
            Console.WriteLine(arrayList.Contains(300)); // true
            Console.WriteLine(arrayList.Contains("Bill")); // true
            Console.WriteLine(arrayList.Contains(10)); // false
            Console.WriteLine(arrayList.Contains("Steve")); // false
            System.Console.WriteLine("Capacity : " + arrayList.Capacity);
            Console.WriteLine(" \n End. ");
        }
    }

}
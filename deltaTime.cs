using System;
using System.Collections;

namespace firstProject
{

    // the ArrayList is a non-generic collection of objects whose size increases dynamically.
    class DeltaTime
    {


        public string deltaTime()
        {
            Console.WriteLine("Delta Time ");

            string time1 = "14:01:57 12:47:11";

            string[] timeArray = time1.Split(' ');

            string result = "";
            int[] timeArray1 = Array.ConvertAll(timeArray[0].Split(":"), int.Parse);
            int[] timeArray2 = Array.ConvertAll(timeArray[1].Split(":"), int.Parse);
            for (int i = 0; i < timeArray1.Length; i++)
            {
                int res = timeArray1[i] - timeArray2[i];
                result += $"{res} : ";

                Console.Write(timeArray1[i] + " : ");

            }
            Console.WriteLine();

            return $"Delta Time {result}";
        }
    }

}
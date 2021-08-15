using System;

namespace taskManager
{
    public class TryParse
    {
        public void tryparse()
        {

            string value = "200";
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }

            // Since it is defined outside of the if statement, 
            // it can be accessed later in your code.
            if (result > 0)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");


            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string Message = "";
            float Total = 0;
            foreach (string word in values)
            {

                float num;
                if (float.TryParse(word, out num))
                {

                    Total += num;
                }
                else
                {

                    Message += word;
                }




            }
            Console.WriteLine("Message: " + Message);
            Console.WriteLine("Result: " + Total);

            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;
            int result1 = value1 / (int)value2;
            decimal result2 = value2 / (decimal)value3;
            float result3 = value3 / (float)value1;
            // Your code here to set result1
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }




    }


}
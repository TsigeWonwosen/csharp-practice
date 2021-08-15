using System;

namespace taskManager
{
    public class TaskManager
    {
        public void stuff()
        {

            string[] tasks = { "study C#", "test 1", "test 2" };
            Console.WriteLine("Task Manger :  ");

            Console.WriteLine("Padding Formating. >>> ");

            string input = "Pad this.";
            Console.WriteLine(input.PadLeft(12));

            // ID:1-6 ,Name 7 -30, Amount 31 -40

            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6, '-');
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);
            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);

            Console.WriteLine("****** Formating .");

            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = $"Dear {customerName}, \n";
            comparisonMessage += $"As a customer of our{currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return";
            comparisonMessage += $"Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.\n";
            comparisonMessage += $"Our new product, {newProduct} offers a return of {newReturn:P2}.Given your current volume,your potential profit would be {newProfit:N2}";


            // Your logic here

            Console.WriteLine(comparisonMessage);

            Console.WriteLine("\n Here's a quick comparison:\n");

            string outputValue = String.Format("{0:P}", currentReturn).PadRight(10);
            string outputProfit = String.Format("{0:C}", currentProfit).PadRight(20);
            string newReturnOut = String.Format("{0:P}", newReturn).PadRight(10);
            string newProfitOut = String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine($"{currentProduct.PadRight(20)} {outputValue:P2} {outputProfit:C}");
            Console.WriteLine($"{newProduct.PadRight(20)} {newReturnOut} {newProfitOut}");






            Console.WriteLine("****** Formating End.");


            foreach (string task in tasks) Console.WriteLine(task);

            string taskInput = "";

            Console.ForegroundColor = ConsoleColor.Green;

            while (taskInput != "q" && taskInput != "exit")
            {
                Array.Resize(ref tasks, tasks.Length + 1);

                Console.WriteLine("Enter task:");
                Console.WriteLine("****");

                taskInput = Console.ReadLine();

                if ((taskInput != "exit" && taskInput != "q" && taskInput != ""))
                {

                    tasks[tasks.Length - 1] = taskInput;
                }
            }
            //foreach(string task in tasks) Console.WriteLine(task);

            foreach (string task in tasks)
            {
                Console.Write(task);
                Console.Write("\t");
            }
            Console.WriteLine();
            Console.WriteLine(tasks.Length);

            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
        }
        public string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }


}
using System;

namespace taskManager {
    public class TaskManager {
        public void stuff() {
 
           string[] tasks = {"study C#","test 1","test 2"};
            Console.WriteLine("Task Manger :  ");
            
            foreach(string task in tasks) Console.WriteLine(task);

            string taskInput ="";

            Console.ForegroundColor = ConsoleColor.Green;
        
            while(taskInput != "q" && taskInput != "exit"){
                Array.Resize(ref tasks, tasks.Length + 1);
            
            Console.WriteLine("Enter task:");
             Console.WriteLine("****");

            taskInput = Console.ReadLine();

            if((taskInput != "exit" && taskInput != "q" && taskInput != "")){

            tasks[tasks.Length - 1] =  taskInput;
            }
            }
            //foreach(string task in tasks) Console.WriteLine(task);

        foreach(string task in tasks) {
            Console.Write(task);
            Console.Write("\t");
        }
         Console.WriteLine();
        Console.WriteLine(tasks.Length);
        }
        }

        
    
}
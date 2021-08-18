using System;
using System.Linq;
using System.Collections.Generic;

using taskManager;
using firstProject.task;
using heroMonster;
using dataTypes;
using dateTime;

namespace firstProject
{
    class Program
    {

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            HeroMonster result = new HeroMonster();
            DataTypes data = new DataTypes();
            TryParse parse = new TryParse();
            ArrayMethods array = new ArrayMethods();
            // IndexOfSubstring indexOf = new IndexOfSubstring();
            DateAndTime dt = new DateAndTime();

            // array.arrayMethods();

            // parse.tryparse();

            // data.dataTypes();
            //     Console.WriteLine(result.winner());

            // foreach (string b in args)
            //     Console.WriteLine(b + "   ");

            // TaskManager test = new TaskManager();

            WeekDays myVar = WeekDays.Monday;
            Console.WriteLine(myVar); // Monday
            Console.WriteLine(WeekDays.Tuesday); // Tuesday
            Console.WriteLine(WeekDays.Wednesday); // Wednesday
            Console.WriteLine(WeekDays.Thursday); // Thursday
            Console.WriteLine(WeekDays.Friday); // Friday
            Console.WriteLine(WeekDays.Saturday); // Saturday
            Console.WriteLine(WeekDays.Sunday); // Sunday

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                // Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            // Console.WriteLine($"We have {sum} items in inventory.");
            // test.stuff();
            // Console.WriteLine(test.Reverse("Wondwosen"));

            Console.WriteLine("Linq - Array of List.");


            IList<Student> studentList = new List<Student>() {
                        new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
                        new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
                        new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
                        new Student() { StudentID = 4, StudentName = "Ram" , age = 20  } ,
                        new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
                    };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName, Age = s.age };
            Console.WriteLine("Id".ToString().PadRight(5) + "Name".ToString().PadRight(5) + "Age".ToString().PadLeft(10));
            foreach (var stud in students)
                Console.WriteLine(stud.Id.ToString().PadRight(5) + stud.Name.ToString().PadRight(5) + stud.Age.ToString().PadLeft(9));

        }


    }
}

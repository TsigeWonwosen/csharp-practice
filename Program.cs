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


            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, bool> oddCheck = x => x % 2 != 0;
            Func<int[], int> sumOfArray = x =>
            {
                int res = 0;
                foreach (var item in x)
                {
                    res += item;
                }
                return res;
            };

            foreach (var item in number)
            {
                Console.WriteLine($"{item} :  {oddCheck(item)} ");
            }

            Console.WriteLine();
            var OddNumbers = number.Where(oddCheck).ToList();

            OddNumbers.ForEach(a =>
            {

                Console.WriteLine($"{a} ==> {oddCheck(a)}");

            });
            Console.WriteLine("Array Sum ----> ");
            int[] ArrayList = { 10, 20, 30, 40, 50, 300, 2, 212, 33, 22, 61 };
            Console.WriteLine(sumOfArray(ArrayList));

            Console.WriteLine("Array Sum --- LINQ ");

            int LinqSum = ArrayList.Sum(a => a);
            int LinqMax = ArrayList.Max();
            int LinqMin = ArrayList.Min();

            Console.WriteLine("LINQ Sum: " + LinqSum + "Max :" + LinqMax + " Min : " + LinqMin);
            Console.WriteLine(" ***** ");

            var NumberLINQ = from i in ArrayList
                             where i > 20
                             orderby i descending
                             select i;
            // NumberLINQ = NumberLINQ.Where(num => num > 30);
            foreach (var item in NumberLINQ)
            {
                Console.Write($" {item}");

            }
            System.Console.WriteLine();






            // array.arrayMethods();

            // parse.tryparse();

            // data.dataTypes();
            //     Console.WriteLine(result.winner());

            // foreach (string b in args)
            //     Console.WriteLine(b + "   ");

            // TaskManager test = new TaskManager();

            WeekDays myVar = WeekDays.Monday;
            // Console.WriteLine(myVar); // Monday
            // Console.WriteLine(WeekDays.Tuesday); // Tuesday
            // Console.WriteLine(WeekDays.Wednesday); // Wednesday
            // Console.WriteLine(WeekDays.Thursday); // Thursday
            // Console.WriteLine(WeekDays.Friday); // Friday
            // Console.WriteLine(WeekDays.Saturday); // Saturday
            // Console.WriteLine(WeekDays.Sunday); // Sunday

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

            var newStudent = new Student { StudentID = 6, StudentName = "Tesema", age = 30 };
            studentList.Add(newStudent);

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName, Age = s.age };

            // Console.WriteLine("Id".ToString().PadRight(5) + "Name".ToString().PadRight(5) + "Age".ToString().PadLeft(10));
            foreach (var stud in students)
                Console.WriteLine(stud.Id.ToString().PadRight(5) + stud.Name.ToString().PadRight(5) + stud.Age.ToString().PadLeft(9));



            foreach (Student stud in studentList)
                Console.WriteLine(stud.StudentID.ToString().PadRight(5) + stud.StudentName.ToString().PadRight(10) + stud.age.ToString().PadLeft(9));


            Console.WriteLine("Interface ---> \n");

            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("Wonde");

            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:

                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }

            Console.WriteLine("Generic Class ...");

            DataStore<string> student = new DataStore<string>();
            DataStore<int> id = new DataStore<int>();
            student.AddOrUpdate(0, "Wonde");
            student.AddOrUpdate(1, "Abel");
            student.AddOrUpdate(2, "Chuchu");

            id.AddOrUpdate(0, 100);
            id.AddOrUpdate(1, 200);
            id.AddOrUpdate(2, 300);
            id.AddOrUpdate(3, 400);


            // Console.WriteLine(student.GetData(2));
            // Console.WriteLine(student.GetData(0));
            // Console.WriteLine(student.GetData(1));

            // Console.WriteLine(id.GetData(2));
            // Console.WriteLine(id.GetData(0));
            // Console.WriteLine(id.GetData(1));

            // Console.WriteLine("ArrayLink ...");

            ArrayListClass list = new ArrayListClass();

            DeltaTime dTime = new DeltaTime();

            Console.WriteLine(dTime.deltaTime());


        }


    }
}

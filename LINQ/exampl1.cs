using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace ProjectTwo
{
    class LinqProject
    {

        public void LinqtEST()
        {
            Console.WriteLine(" LINQ  IEnumerable vs IEnumerator. ");
            ArrayList Id = new ArrayList() { 10, 20, 30, 40, 50, 300, 2, 212, 33, 22, 61 };
            Id.Add(555);
            Id.Add(666);
            List<int> integer = new List<int> { 1, 2, 3, 5, 690 };
            IEnumerator<int> age = integer.GetEnumerator();


            while (age.MoveNext())
            {
                System.Console.WriteLine(age.Current);
            }


            IEnumerable<int> intArray = new[] { 1, 2, 3, 4, 5 };
            IEnumerable<int> list = new List<int>(intArray);
            var List = list.ToList();

            StudentCollaction students = new StudentCollaction();

            foreach (var item in Id)
            {

                List.Add((int)item);
            }
            int orderString;

            Console.WriteLine("Order By :  Name Or Lname Or Age");
            orderString = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Student> filteredItem = (from Student i in students where i.Id != orderString orderby i.Name select i);

            for (int i = 0; i < students.StudentLists().Count; i++)
            {
                System.Console.WriteLine(students.StudentLists()[i].Name + " Age : " + students.StudentLists()[i].Age);
            }
            foreach (Student i in filteredItem)
            {
                System.Console.WriteLine($"{i.Id} - {i.Name} {i.Lname} {i.Age}");
            }

        }


    }
}

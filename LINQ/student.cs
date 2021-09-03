using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectTwo
{
    [Table("tblStudent")]
    class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last Name is Required.")]

        public string Lname { get; set; }
        public int Age { get; set; }


    }

    class StudentCollaction : IEnumerable
    {

        List<Student> students = new List<Student>(){
             new Student {Id=1,Name="Wonde",Lname="Shi",Age=20},
                new Student {Id=2,Name="Abel",Lname="Wondwosen",Age=30},
                new Student {Id=3,Name="Chuchu",Lname="Tsige",Age=33},
                new Student {Id=4,Name="Tedo",Lname="Getu",Age=34}
        };

        public StudentCollaction() => students.Add(new Student { Id = 5, Name = "Mokke", Lname = "Aragawu", Age = 36 });
        public List<Student> StudentLists()
        {
            return students.ToList();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)students).GetEnumerator();
        }



    }
}

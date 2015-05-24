using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HumanStudentAndWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Georgiev", "10000");
            Student student2 = new Student("Petar", "Ivanov", "10001");
            Student student3 = new Student("Kiril", "Petrov", "10002");
            Student student4 = new Student("Maria", "Georgieva", "10003");
            Student student5 = new Student("Ivanka", "Grigorova", "10004");
            Student student6 = new Student("Petia", "Petrova", "10005");
            Student student7 = new Student("Borislava", "Kirilova", "10006");
            Student student8 = new Student("Petar", "Ivanov", "10007");
            Student student9 = new Student("Desislava", "Petkova", "10008");
            Student student10 = new Student("Gosho", "Nikolov", "10009");

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);
            students.Add(student9);
            students.Add(student10);

            var sortStudents =
                from student in students
                orderby student.FacNumber ascending
                select student;
            Console.WriteLine("Sorted students ---> ");
            foreach (var item in sortStudents)
            {
                Console.WriteLine("First name: {0} , Last name: {1} , Number: {2}",
                    item.FirstName, item.LastName, item.FacNumber);
            }

            var sortFNameLName = students.OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);
            Console.WriteLine("Sort by first name and last name ---->");
            foreach (var item in sortFNameLName)
            {
                Console.WriteLine("First name: {0} , Last name {1}",
                    item.FirstName, item.LastName);
            }
        }
    }
}

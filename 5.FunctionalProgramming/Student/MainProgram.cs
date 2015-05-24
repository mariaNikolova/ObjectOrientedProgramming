using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<int> marks1 = new List<int>() {2,3,4};
            Student student1 = new Student("Maria", "Angelova", 35, 44563,
                "08097654321", "maria@abv.bg",marks1, 2);

            List<int> marks2 = new List<int>() { 2, 5, 6 };
            Student student2 = new Student("Pesho", "Nikolov", 20, 44654,
                "08097654321", "pesho@abv.bg", marks2, 3);

            List<int> marks3 = new List<int>() {6,6,6};
            Student student3 = new Student("Angel", "Nikolov", 22, 44655,
                "08097654321", "gosho@abv.bg", marks3, 2);

            List<int> marks4 = new List<int>() { 2, 2};
            Student student4 = new Student("Dancho", "Grigorov", 22, 44656,
                "08097654321", "dancho@abv.bg", marks3, 2);


            List<Student> listStudent = new List<Student>();
            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            var studentsByGroup =
            from student in listStudent
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

            foreach (var item in studentsByGroup)
            {
                Console.Write("First name: {0}\n", item.FirstName);
            }

            var studentsByFirstAndLastName =
                from student in listStudent
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            foreach (var item in studentsByFirstAndLastName)
            {
                Console.WriteLine("First name: {0}\nLast name: {1} \n",
                                    item.FirstName, item.LastName);
            }
            var studentsByAge =
                from student in listStudent
                where student.Age<24 && student.Age>18
                select new { student.FirstName, student.LastName, student.Age };
            foreach (var item in studentsByAge)
            {
                Console.WriteLine("First name: {0} Last name: {1} Age: {2} \n",
                                    item.FirstName, item.LastName,item.Age);
            }

            var sortStudents = listStudent.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var item in sortStudents)
            {
                Console.WriteLine("Name: {0} {1}",item.FirstName,item.LastName);
            }

            Console.WriteLine();
            var sortStudentLINQ =
                from student in listStudent
                orderby student.FirstName descending, student.LastName descending
                select student;
            foreach (var item in sortStudentLINQ)
            {
                Console.WriteLine("Name: {0} {1}", item.FirstName, item.LastName);
            }

            Console.WriteLine();
            var excellentStudents =
                from student in listStudent
                where student.Marks.Contains(6)
                select new { student.FirstName, student.LastName, student.Marks};
            foreach (var item in excellentStudents)
            {
                Console.WriteLine("{0} {1} {{ {2} }}", 
                    item.FirstName,item.LastName, string.Join(", ", item.Marks));
            }
            Console.WriteLine();
            var twoTwos = listStudent.Where(st => st.Marks.Where(m => m == 2).Count() == 2);
            foreach (var item in twoTwos)
            {
                Console.WriteLine(item.ToString());
            }
            

        }
    }
}

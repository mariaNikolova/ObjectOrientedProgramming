using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Disciplines mat = new Disciplines("mat", 3, 20);
            Disciplines bio = new Disciplines("bio", 1, 25);
            Disciplines BEL = new Disciplines("BEL", 3, 23);
            Disciplines sport = new Disciplines("sport", 4, 30);

            List<Disciplines> disciplisnesOne = new List<Disciplines>();
            disciplisnesOne.Add(mat);
            disciplisnesOne.Add(bio);
            disciplisnesOne.Add(BEL);

            List<Disciplines> disciplisnesTwo = new List<Disciplines>();
            disciplisnesTwo.Add(mat);
            disciplisnesTwo.Add(bio);
            disciplisnesTwo.Add(BEL);
            disciplisnesTwo.Add(sport);

            Teachers teacher1 = new Teachers("Pesheva", disciplisnesOne);
            Teachers teacher2 = new Teachers("Grigorov", disciplisnesTwo);

            List<Teachers> teachers = new List<Teachers>() ;
            teachers.Add(teacher1) ;
            teachers.Add(teacher2) ;

            Student student = new Student("Georgi", 16);
            student.Talk();
            Console.WriteLine(student.toStringStudent());
            Class class5A = new Class("5A", teachers) ;
            Console.WriteLine(class5A.ToString());
        }
    }
}

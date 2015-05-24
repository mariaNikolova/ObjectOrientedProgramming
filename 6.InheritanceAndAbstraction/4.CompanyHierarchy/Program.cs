using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Mariq", "Nikolova");
           // person.toString();
            Department job = Department.Production;
            Employee employee1 = new Employee(2, "Stanimir", "Mirchev", 5000, job);
            Employee employee2 = new Employee(3, "Stanimir", "Mirchev", 5000, job);
            Employee employee3 = new Employee(4, "Stanimir", "Mirchev", 5000, job);
            Employee employee4 = new Employee(6, "Stanimir", "Mirchev", 5000, job);


            //employeeOne.toString();
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            Manager manager= new Manager(7,"Hristo","Petrov",1000,job,employees) ;
           // manager.toString();

            DateTime date1 = new DateTime(43253254365);
            Sale sale1 = new Sale("Samsung",date1,220.50);

            DateTime date2 = new DateTime(43253254365);
            Sale sale2 = new Sale("Samsung", date1, 220.50);

            DateTime date3 = new DateTime(43253254365);
            Sale sale3 = new Sale("Samsung", date1, 220.50);

            List<Sale> sales = new List<Sale>();
            sales.Add(sale1);
            sales.Add(sale2);
            sales.Add(sale3);

            SalesEmployee saleEmployee = new SalesEmployee(8,"Gosho","Ivanov",300,job,sales);
           // saleEmployee.toString();

            State state1 = State.Open;
            Project project1 = new Project("Malinka", date1, "dobyr project", state1);
            Project project2 = new Project("Kalinka", date1, "dobyr project", state1);
            Project project3 = new Project("Pepinka", date1, "dobyr project", state1);

            List<Project> manyProjects = new List<Project>();
            manyProjects.Add(project1);
            manyProjects.Add(project2);
            manyProjects.Add(project3);

            Developer stanimir = new Developer(324, "Stanimir", "Mirchev", 50000, job, manyProjects);
           // stanimir.toString();

            List<Person> listPerson = new List<Person>();
            listPerson.Add(manager);
            listPerson.Add(saleEmployee);
            listPerson.Add(stanimir);

            foreach (var item in listPerson)
            {
                item.toString();
            }

        }
    }
}

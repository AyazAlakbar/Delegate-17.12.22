using System;
using System.Collections.Generic;

namespace Predicate_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //Person person = new Person();

            //Predicate<double> personSalary = pers => pers > 1000;
            //person.FullInfo(personSalary);
            #endregion

            #region Book
            //Book book = new Book();

            //Predicate<string> authorBook = b => b == "Nizami";
            //book.ShowBookInfo(authorBook);
            #endregion

            #region Employee
            Employee emp1 = new Employee();
            emp1.Name = "A";
            emp1.Age = 22;
            emp1.Salary = 1000;

            Employee emp2 = new Employee();
            emp2.Name = "B";
            emp2.Age = 38;
            emp2.Salary = 2000;

            Employee emp3 = new Employee();
            emp3.Name = "C";
            emp3.Age = 18;
            emp3.Salary = 100;

            Employee emp4 = new Employee();
            emp4.Name = "D";
            emp4.Age = 39;
            emp4.Salary = 3000;

            List<Employee> list = new List<Employee>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);

            int totalSalary = 0;
            int count = 0;

            List<Employee> emp = list.FindAll(emp => emp.Age > 20 && emp.Age < 40);

            foreach (var item in emp)
            {

                totalSalary += item.Salary;
                count++;


            }
            Console.WriteLine(totalSalary / count);

            #endregion
        }


    }
    
}

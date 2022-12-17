using System;
using System.Collections.Generic;
using System.Text;

namespace Predicate_task
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }



        public void FullInfo(Predicate<double> person)
        {
            Person person1 = new Person();
            person1.Name = "Alfa";
            person1.Surname = "X";
            person1.Adress = "Baku";
            person1.Salary = 2500;

            Person person2 = new Person();
            person2.Name = "Betta";
            person2.Surname = "Y";
            person2.Adress = "Moscow";
            person2.Salary = 900;

            Person person3 = new Person();
            person3.Name = "Gamma";
            person3.Surname = "Z";
            person3.Adress = "London";
            person3.Salary = 1400;

            List<Person> pers = new List<Person>();
            pers.Add(person1);
            pers.Add(person2);
            pers.Add(person3);

            foreach (var item in pers)
            {
                if (person(item.Salary))
                {
                    Console.WriteLine(item.Name+" "+item.Surname+" "+item.Adress);
                }
            }

        }
    }

}

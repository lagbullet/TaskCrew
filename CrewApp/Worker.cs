using System;

namespace CrewApp
{
    class Worker
    {
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }

        public Worker(string surname, string firstname, string patronymic,int age, string position, float salary)
        {
            SurName = surname;
            FirstName = firstname;
            Patronymic = patronymic;
            Age = age;
            Position = position;
            Salary = salary;
        }

        public int CompareTo(Worker other)
        {
            return Position.CompareTo(other.Position);
        }

        public void Show()
        {
            Console.WriteLine("Surname - {0}; Firstname - {1}; Patronymic - {2}; Age - {3}; Position - {4}; Salary - {5}.",SurName,FirstName,Patronymic,Age,Position,Salary);
        }
    }
}

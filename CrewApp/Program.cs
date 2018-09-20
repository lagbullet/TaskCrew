using System;

namespace CrewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("surname1", "firstname1", "patronymic1", 1, "position1", 100);
            Crew crew = new Crew
            {
                worker,
                new Worker("surname2", "firstname2", "patronymic2", 2, "position2", 200),
                new Worker("surname4", "firstname4", "patronymic4", 4, "position4", 400),
                new Worker("surname3", "firstname3", "patronymic3", 3, "position3", 300),
                new Worker("surname6", "firstname6", "patronymic6", 6, "position6", 600),
                new Worker("surname5", "firstname5", "patronymic5", 5, "position5", 500),
                new Worker("surname8", "firstname8", "patronymic8", 8, "position8", 800)
            };
            crew.ShowCrew();
            crew.Sort();
            Console.ReadLine();
            crew.ShowCrew();
            Console.ReadLine();
        }
    }
}

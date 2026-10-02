using System;

namespace Homework
{
    internal class Program
    {

        enum University // домашнее задание 3.1
        {
            КГУ,
            КАИ,
            КХТИ

        }
        struct Worker
        {
            public string name;
            public University place;

            public void Print()
            {
                Console.WriteLine($"работник - {name}, ВУЗ - {place}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("домашнее задание 3.1");
            Worker worker = new Worker();
            worker.name = "Иван Петров";
            worker.place = University.КАИ;
            worker.Print();
        }
    }
}
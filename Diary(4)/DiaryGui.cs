using System;

namespace ConsoleApp6
{
    public class DiaryGui
    {
        private Diary _diary;

        public DiaryGui(Diary diary)
        {
            _diary = diary;
        }
        public void Update()
        {
            Console.Clear();
            Console.WriteLine("Доступные команды >> add|show");
            string command = Console.ReadLine();
            switch (command)
            {
                case "add":
                    foreach (var name in _diary.GetNamesOfGroup())
                    {
                        Console.Write(name + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('-', 15));
                    Console.WriteLine("Куда вы хотите добавить цель?");
                    string listName = Console.ReadLine()?.ToLower(); //то что введёт пользователь переведённое в нижний регистр
                    Console.WriteLine("Что это за цель?");
                    string goal = Console.ReadLine();
                    _diary.AddGoalInList(listName, goal);
                    break;
                case "show":
                    Console.WriteLine();
                    Console.WriteLine("Откуда показать цели");
                    string nameofList = Console.ReadLine()?.ToLower();
                    Console.WriteLine("Вот список дел на сегодня");
                    Console.WriteLine(new string('-',15));
                    foreach (var e in _diary.GetList(nameofList))
                    {
                        Console.WriteLine(e);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
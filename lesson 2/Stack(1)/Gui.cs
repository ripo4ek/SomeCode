using System;

namespace Stack_1_
{
    class Gui
    {
        private readonly Stack _pancakes;
        private readonly Random _random = new Random();

        public Gui(Stack pancakes)
        {
            _pancakes = pancakes;
        }


        public void Update()
        {
            Console.WriteLine("Что вы хотите?");
            string command = Console.ReadLine();

            switch (command)
            {
                case "Скушать":
                    if (_pancakes.Count>0)
                    {
                        Console.WriteLine($"В блинчике {_pancakes.Pop()} калорий");
                    }
                    else
                    {
                        Console.WriteLine("Сначала надо испечь блинчик!");
                    }
                    break;
                case "Испечь":
                    int calories = _random.Next(1, 20);
                    Console.WriteLine($"Вы испекли блинчик с ${calories} калориями");
                    _pancakes.Push(calories);
                    break;

                default:
                    break;
            }
        }
    }
}
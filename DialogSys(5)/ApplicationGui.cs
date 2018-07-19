using System;

namespace DialogSys_5_
{
    public class ApplicationGui
    {
        private DialogGui _dialogGui;
        private readonly  DialogCollection _collection = new DialogCollection();

        public void Update()
        {
            Console.Clear();
            Console.WriteLine("Доступные команды >> ShowAll|Start[int]");
            var splitedComand = Console.ReadLine()?.Split(' ');
            string command = splitedComand[0];
            int posArg = Convert.ToInt32(splitedComand[1]);
            switch (command)
            {
                case "ShowAll":
                    Console.WriteLine();
                    Console.WriteLine("Список доступных диалогов:");
                    Console.WriteLine(new string('-',15));
                    foreach (var dialogInfo in _collection.GetNames())
                    {
                        Console.WriteLine($"{dialogInfo.Key} - {dialogInfo.Value}");
                    }

                    Console.ReadLine(); 
                    break; 
                case "Start":
                    _dialogGui = new DialogGui(_collection.GetDialog(posArg));
                    Console.WriteLine();
                    Console.WriteLine("Режим диалога");
                    Console.WriteLine(new string('-',15));
                    _dialogGui.Update();
                    break;
            }
        }

    }
}
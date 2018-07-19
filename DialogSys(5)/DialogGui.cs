using System;

namespace DialogSys_5_
{
    public class DialogGui
    {
        private readonly Dialog _dialog;

        public DialogGui(Dialog dialog)
        {
            _dialog = dialog;
        }

        public void Update()
        {
            Console.WriteLine("Доступные варианты ответа >> Да/Нет");
            foreach (var pair in _dialog.Root)
            {
                Console.WriteLine(pair.Key);
                switch (Console.ReadLine())
                {
                    case "Да":
                        continue;
                    case "Нет":
                        _dialog.State = false;
                        break;
                }                    
                break;
            }
            if (_dialog.State)
            {
                Console.WriteLine("Красиво делаешь красиво будет");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Лох и опозорился");
            Console.ReadLine();
        }
    }
}
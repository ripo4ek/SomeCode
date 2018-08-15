using System;

namespace ActionsAndTriggers
{
    class CommandGui
    {
        private Command _command;

        public void Update()
        {
            Console.WriteLine("commands : create|run");
            switch (Console.ReadLine())
            {
                case "create":
                    IActionable action = ActionSelector();
                    Console.Clear();
                    ITriggerable trigger = TriggerSelector();
                    Console.Clear();
                    if (action == null && trigger == null)
                    {
                        return;
                    }                  
                    _command = new Command(trigger,action);
                    Console.WriteLine("Trigger created");
                    break;
                case "run":
                    _command?.Start();
                    break;

            }

        }

        private IActionable ActionSelector()
        {
            Console.WriteLine("-->reboot");
            Console.WriteLine("-->shutdown");
            Console.WriteLine("-->logout");
            Console.WriteLine("-->hardreboot");
            Console.WriteLine("-->hardshutdown");
            Console.WriteLine(new string('-',15));
            Console.WriteLine("Example: for reboot insert: \"reboot\" ");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "reboot":
                    return new Reboot();
                    
                case "shutdown":
                    return new Shutdown();
                    
                case "logout":
                    return new LogOut();
                    
                case "hardreboot":
                    return new HardReboot();
                    
                case "hardshutdown":
                    return new HardShutdown();
                default:
                    return null;
            }
        }

        private ITriggerable TriggerSelector()
        {
            Console.WriteLine("-->battery");
            Console.WriteLine("-->time");
            Console.WriteLine("-->timer");
            Console.WriteLine(new string('-', 15));
            Console.WriteLine("Example: for reboot insert: \"reboot\" ");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "battery":
                    Console.WriteLine("Low level? (number)");
                    int batteryLevel = Convert.ToInt32(Console.ReadLine());
                    return new BatteryTrigger(batteryLevel);

                case "time":
                    Console.WriteLine("Input time");
                    DateTime time = Convert.ToDateTime(Console.ReadLine());
                    return new TimeTrigger(time);

                case "timer":
                    Console.WriteLine("How many time do we have? :)");
                    int seconds = Convert.ToInt32(Console.ReadLine());
                    return new TimerTrigger(seconds);
                default:
                    return null;
            }
        }
    }
}
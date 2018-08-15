using System;

namespace ActionsAndTriggers
{
    class Command
    {
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();
        private readonly ITriggerable _trigger;
        private readonly IActionable _action;

        public Command(ITriggerable trigger, IActionable action)
        {
            _trigger = trigger;
            _action = action;
            _timer.Elapsed += CheckTrigger;
        }

        public void Start()
        {
            _timer.Start();
            _trigger.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void CheckTrigger(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (_trigger.IsTriggered)
            {
                _timer.Stop();
                
                _action.DoAction();
            }
        }

    }
}
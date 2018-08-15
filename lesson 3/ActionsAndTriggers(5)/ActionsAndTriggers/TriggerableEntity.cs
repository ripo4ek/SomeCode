using System;

namespace ActionsAndTriggers
{
    abstract class TriggerableEntity : ITriggerable
    {
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();
        public bool IsTriggered { get; protected set; }

        protected TriggerableEntity()
        {
            IsTriggered = false;
            _timer.Elapsed += CheckСondition;

        }
        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        protected abstract void CheckСondition(Object source, System.Timers.ElapsedEventArgs e);
    }
}
using System.Timers;
using System.Windows.Forms;

namespace ActionsAndTriggers
{
    //в секундах (int) сделал для разнообразия, понимаю что лучше datetime
    class TimerTrigger : TriggerableEntity
    {
        private PowerStatus _powerStatus;

        public int TriggerTime { get;}

        private int _timer; 

        public TimerTrigger(int triggerTime)
        {
            TriggerTime = triggerTime;
            _powerStatus = SystemInformation.PowerStatus;
        }
        protected override void CheckСondition(object source, ElapsedEventArgs e)
        {
            IncrementTimer();
            if (_timer > TriggerTime)
            {
                IsTriggered = true;
                base.Stop();
            }
        }
        private void IncrementTimer()
        {
            _timer++;
        }
    }
}
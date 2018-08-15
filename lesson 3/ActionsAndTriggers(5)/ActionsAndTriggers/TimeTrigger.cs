using System;
using System.Timers;
using System.Windows.Forms;

namespace ActionsAndTriggers
{
    class TimeTrigger : TriggerableEntity
    {
        private PowerStatus _powerStatus;

        public DateTime TriggerTime { get; }

        public TimeTrigger(DateTime triggerTime)
        {
            TriggerTime = triggerTime;
            _powerStatus = SystemInformation.PowerStatus;
        }
        protected override void CheckСondition(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now == TriggerTime)
            {
                IsTriggered = true;
                base.Stop();
            }
        }
    }
}
using System.Timers;
using System.Windows.Forms;

namespace ActionsAndTriggers
{
    class BatteryTrigger : TriggerableEntity
    {
        private PowerStatus _powerStatus;

        public int BatteryCondition { get; set; }

        public BatteryTrigger(int batteryCondition)
        {
            BatteryCondition = batteryCondition;
            _powerStatus = SystemInformation.PowerStatus;
        }
        protected override void CheckСondition(object source, ElapsedEventArgs e)
        {
            if (BatteryStatus() > BatteryCondition)
            {
                IsTriggered = true;
                base.Stop();
            }
        }
        private int BatteryStatus()
        {
            return SystemInformation.PowerStatus.BatteryLifeRemaining;
        }
    }
}
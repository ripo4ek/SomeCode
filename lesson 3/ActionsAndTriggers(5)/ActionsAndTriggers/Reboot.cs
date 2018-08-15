namespace ActionsAndTriggers
{
    class Reboot : ActionableEntity
    {
        //Доп функционал в случае reboot'a

        public override void DoAction()
        {
            SysManagmentOperator.Initialize(OptionState.Reboot);
        }
    }
}
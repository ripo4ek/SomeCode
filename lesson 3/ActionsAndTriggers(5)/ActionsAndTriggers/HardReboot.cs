namespace ActionsAndTriggers
{
    class HardReboot : ActionableEntity
    {
        //Доп функционал в случае HardReboot'a

        public override void DoAction()
        {
            SysManagmentOperator.Initialize(OptionState.HardReboot);
        }
    }
}
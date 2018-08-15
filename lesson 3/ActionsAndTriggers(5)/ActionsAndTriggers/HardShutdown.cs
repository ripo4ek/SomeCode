namespace ActionsAndTriggers
{
    class HardShutdown : ActionableEntity
    {
        //Доп функционал в случае HardShutdown'a

        public override void DoAction()
        {
            SysManagmentOperator.Initialize(OptionState.HardShutdown);
        }
    }
}
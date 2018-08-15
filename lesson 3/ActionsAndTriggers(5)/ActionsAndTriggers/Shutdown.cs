namespace ActionsAndTriggers
{
    class Shutdown : ActionableEntity
    {
        //Доп функционал в случае Shutdown'a

        public override void DoAction()
        {
            SysManagmentOperator.Initialize(OptionState.Shutdown);
        }
    }
}
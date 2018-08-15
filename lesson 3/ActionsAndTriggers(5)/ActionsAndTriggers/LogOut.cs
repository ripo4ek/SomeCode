namespace ActionsAndTriggers
{
    class LogOut : ActionableEntity
    {
        //Доп функционал в случае Logout'a

        public override void DoAction()
        {
            SysManagmentOperator.Initialize(OptionState.LogOut);
        }
    }
}
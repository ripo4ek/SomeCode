namespace ActionsAndTriggers
{
    abstract class ActionableEntity : IActionable
    {       
        public abstract void DoAction();
        public SystemManagmentOperator SysManagmentOperator;
        protected ActionableEntity()
        {
            SysManagmentOperator = new SystemManagmentOperator();
        }


    }
}
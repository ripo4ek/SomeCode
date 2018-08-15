namespace ActionsAndTriggers
{
    interface ITriggerable
    {
        bool IsTriggered { get; }

        void Start();

        void Stop();
    }
}

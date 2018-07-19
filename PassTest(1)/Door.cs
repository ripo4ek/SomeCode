namespace IMJunior
{
    public struct Door
    {

        public bool IsOpened { get; private set; }

        public void ChangeStage()
        {
            IsOpened = !IsOpened;
        }
    }
}
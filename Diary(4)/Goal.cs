namespace ConsoleApp6
{
    public struct Goal
    {
        public string Text { get;}

        public Goal(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
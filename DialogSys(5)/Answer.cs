public struct Answer
{
    public string Text { get; }

    public Answer(string text)
    {
        Text = text;
    }

    public override string ToString()
    {
        return Text;
    }
}
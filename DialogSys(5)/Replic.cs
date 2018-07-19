public struct Replic
{
    public string Text { get; }

    public Replic(string text)
    {
        Text = text;
    }

    public override string ToString()
    {
        return Text;
    }
}
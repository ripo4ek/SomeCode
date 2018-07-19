using System.Collections.Generic;

public class Dialog
{
    public int Id { get; }
    public string Name { get; }
    public bool State { get; set; }

    public Dictionary<Replic, Answer> Root { get; } = new Dictionary<Replic, Answer>()
    {
        {new Replic("Вы орк?"),new Answer("Да")},
        { new Replic("А ваша мама была орком?"),new Answer("Да")},
    };

    public Dialog(int id, string name)
    {
        Id = id;
        Name = name;
        State = true;
    }

    public void AddRoot(Replic replic, Answer answer)
    {
        Root.Add(replic, answer);
    }
}
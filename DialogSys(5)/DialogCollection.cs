using System;
using System.Collections.Generic;
using System.Linq;

public class DialogCollection //условно, без интерфейсов это скорее составной объект
{
    private readonly List<Dialog> _dialogs = new List<Dialog>()
    {
        new Dialog(1,"orks"),
        new Dialog(3,"aliance sasatt"),
        new Dialog(1488,"net ubludkam iz alianca"),
    };
    public void AddDialog(Dialog dialog)
    {
        _dialogs.Add(dialog);
    }

    public Dialog GetDialog(int id)
    {
        if (_dialogs.Exists(p => p.Id == id))
        {
            return _dialogs.FirstOrDefault(d => d.Id == id);
        }
        throw  new ArgumentException();
            
    }

    public Dictionary<string,int> GetNames() //не очень хорошее решение но лучше не придумал
    {
        Dictionary<string, int> rezult = new Dictionary<string, int>();
        foreach (var dialog in _dialogs)
        {
            rezult.Add(dialog.Name,dialog.Id);
        }

        return rezult;
    }

}
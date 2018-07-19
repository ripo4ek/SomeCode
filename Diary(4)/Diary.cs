using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    public class Diary
    {
        private List<GoalsList> _list = new List<GoalsList>()
        {
            new GoalsList("домашний"),
            new GoalsList("рабочий"),
            new GoalsList("семейный")
        };

        public void CreateGoalsList(string name)
        {
            _list.Add(new GoalsList(name.ToLower()));
        }

        public GoalsList GetList(string name)
        {
            return _list.FirstOrDefault(g => g.Name == name);
        }

        public void AddGoalInList(string nameofList, string text)
        {
            _list.FirstOrDefault(g => g.Name == nameofList)?.Add(text);
        }

        public IEnumerable GetNamesOfGroup()
        {
            foreach (var goalsList in _list)
            {
                yield return goalsList.Name;
            }
        }
    }
}
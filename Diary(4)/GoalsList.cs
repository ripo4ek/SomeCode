using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class GoalsList: IEnumerable
    {
        public string Name { get; } //надо ли было создавить ещё и группу как объект?
        private readonly List<Goal> _goals = new List<Goal>();

        public GoalsList(string name)
        {
            Name = name;
        }

        public void Add(string goalText)
        {
            _goals.Add(new Goal(goalText));
        }

        public IEnumerator GetEnumerator()
        {
            return _goals.GetEnumerator();
        }

        public Goal this[int index]
        {
            get => _goals[index];
            set => _goals[index] = value;
        }
       

    }
}
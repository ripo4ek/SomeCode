namespace IMJunior
{
    public class Stage
    {
        public Question Question { get; }
        public Answer[] Answers { get; }
        public Door Door { get; set; }

        public Stage(Question question, Answer[] arrayAnswers)
        {
            Question = question;
            Answers = arrayAnswers;
            Door = new Door();
        }

    }
}
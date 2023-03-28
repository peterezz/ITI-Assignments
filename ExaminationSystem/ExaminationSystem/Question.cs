namespace ExaminationSystem
{
    public abstract class Question
    {
        public string QuestionId { get; set; } = Guid.NewGuid().ToString();
        protected string Header { get; set; }

        public string Body { get; set; }

        public int Marks { get; set; }

        public float StudentMark { get; set; }
        public string CorrectAnswer { get; set; }




        public abstract void PrintQuestion();

        public abstract string GetMarks();

        public abstract void FetchAnswer();
 
    }
}

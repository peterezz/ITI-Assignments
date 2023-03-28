using ExaminationSystem.FlieManager;
using ExaminationSystemModified.ENUMs;

namespace ExaminationSystem
{
    internal class RightWrong : Question
    {
 
        public Answer<bool> StudentAnswer { get; set; }
        public RightWrong(string header, string body, int marks, Answer<bool> correctAnswer)
        {
            Header = header;
            Body = body;
            Marks = marks;
     
            LogQuestion(correctAnswer);
        }

        public override string ToString()
        {
            string Tip = "(Answer with True or False)";
            return $"{Header}. {Body}? {Tip} \t ({Marks} Mark(s))";
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(ToString());
        }

        public override void FetchAnswer()
        {
            bool Answer;
            do
            {

            } while (!bool.TryParse(Console.ReadLine(), out Answer));
            StudentAnswer = new Answer<bool>(Answer);

        }

        public override string GetMarks()
        {
            var questions = Logger.ReadFile(nameof(RightWrong),nameof(FileNames.ModelAnswers));
            string CorrectAnswer = string.Empty;

            if (questions.TryGetValue(QuestionId, out CorrectAnswer) && StudentAnswer.Equals(CorrectAnswer))
            {
                this.CorrectAnswer = CorrectAnswer;

                StudentMark = Marks;
                    return $"{StudentMark} / {Marks}";
                }
            

            StudentMark = 0;
            return $"0 / {Marks}";
        }

        public void LogQuestion(Answer<bool> CorrectAnswer)
        {
            Logger.Log($"{nameof(RightWrong)}{FileNames.Questions}", String.Join(';', this.QuestionId, this.Body), true);
            Logger.Log($"{nameof(RightWrong)}{FileNames.ModelAnswers}", String.Join(';', this.QuestionId,CorrectAnswer), true);

        }
    }
}

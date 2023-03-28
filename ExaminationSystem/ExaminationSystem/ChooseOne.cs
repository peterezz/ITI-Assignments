using ExaminationSystem.FlieManager;
using ExaminationSystemModified.ENUMs;
using System.Text.RegularExpressions;

namespace ExaminationSystem
{
    internal class ChooseOne : Choose
    {

       public Answer<string> StudentAnswer { get; set; }
        public ChooseOne(string header, string body, int marks, List<string> options, Answer<string> correctAnswer)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Options = options;
            LogQuestion(correctAnswer);
        }

        public override string ToString()
        {
            string Tip = "(Choose the correct index)";
            return $"{Header}. {Body}? {Tip} \t ({Marks} Mark(s))";
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(ToString());
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Options[i]}");
            }
        }

        public override void FetchAnswer()
        {
            Regex regex = new Regex("^[1-4]$");
            string Answer;
            do
            {
                Answer = Console.ReadLine();
            } while (!regex.IsMatch(Answer) || Answer is null);
            StudentAnswer = new Answer<string>(Answer);


        }

        public override string GetMarks()
        {
            var questions = Logger.ReadFile(nameof(ChooseOne),nameof(FileNames.ModelAnswers));
            string CorrectAnswer = string.Empty;

            if ( questions.TryGetValue(QuestionId, out CorrectAnswer) &&  StudentAnswer.Equals(CorrectAnswer))
            {
                this.CorrectAnswer = CorrectAnswer;
                StudentMark = Marks;
                return $"{StudentMark} / {Marks}";
            }


            StudentMark = 0;
            return $"0 / {Marks}";
        }

        public void LogQuestion(Answer<string> CorrectAnswer)
        {
            Logger.Log($"{nameof(ChooseOne)}{FileNames.Questions}", String.Join(';', this.QuestionId, this.Body), true);
            Logger.Log($"{nameof(ChooseOne)}{FileNames.ModelAnswers}", String.Join(';', this.QuestionId, CorrectAnswer), true);

        }
    }
}

using ExaminationSystem.FlieManager;
using ExaminationSystemModified.ENUMs;
using System.Text.RegularExpressions;

namespace ExaminationSystem
{
    internal class ChooseAll : Choose
    {
       
        public Answer<List<string>> StudentAnswer { get; set; }
        public ChooseAll(string header, string body, int marks, List<string> options, Answer<string> correctAnswer)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Options = options;

            LogQuestion(correctAnswer);
        }

        public override string ToString()
        {
            string Tip = "(Choose only the correct index(s) (ex: 1,2,3)):";
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
            Regex Rx = new Regex("^[1-9](,[1-9])*$");
            string? Answer;
            do
            {
                Answer = Console.ReadLine();
            } while (Answer is null || !Rx.IsMatch(Answer));
            List<string> stdAnswer = Answer.Split(',').ToList();

            StudentAnswer = new Answer<List<string>>(stdAnswer);
        }

        public override string GetMarks()
        {

            float TotalMarks = 0f;
            var questions = Logger.ReadFile(nameof(ChooseAll),nameof(FileNames.ModelAnswers));
            List<string> CorrectAnswers = new List<string>();
            string correctAnswer = string.Empty;
            if (questions.TryGetValue(QuestionId, out correctAnswer))
            {
                CorrectAnswer = correctAnswer;
                CorrectAnswers = correctAnswer.Split(",").ToList();


                float Mark = (float)Marks / CorrectAnswers.Count;

                foreach (string Answer in StudentAnswer.data)
                {
                    if (CorrectAnswers.Contains(Answer))
                    {
                        TotalMarks += Mark;
                    }
                    else
                    {
                        TotalMarks -= Mark;
                    }
                }

                if (TotalMarks < 0)
                {
                    TotalMarks = 0;
                }
            }

            StudentMark = TotalMarks;
            return $"{StudentMark} / {Marks}";
        }

        public  void LogQuestion(Answer<string> CorrectAnswer)
        {
            Logger.Log($"{nameof(ChooseAll)}{FileNames.Questions}", String.Join(';', this.QuestionId, this.Body), true);
            Logger.Log($"{nameof(ChooseAll)}{FileNames.ModelAnswers}", String.Join(';', this.QuestionId, CorrectAnswer), true);

        }
    }
}

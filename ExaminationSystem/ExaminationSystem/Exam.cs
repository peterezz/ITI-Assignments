namespace ExaminationSystem
{
    internal class Exam
    {
        public Exam(ExamType type, int time, int noOfQuestions, List<Question> questions, Status status)
        {
            Type = type;
            Time = time;
            NoOfQuestions = noOfQuestions;
            Questions = questions;
            Status = status;
        }

        public ExamType Type { get; }

        public int Time { get; set; } // Time in Seconds!

        public int NoOfQuestions { get; }

        public List<Question> Questions { get; } 

        public Status Status { get; set; }

        internal void AnswerExam()
        {
            Console.WriteLine ("---------- Start Exam ----------\n");

            var Section1 = Questions.Where(q => q is RightWrong).ToList();
           var Section2 = Questions.Where(q => q is ChooseOne).ToList();
           var Section3 = Questions.Where(q => q is ChooseAll).ToList();

            DateTime StartTime = DateTime.UtcNow;
            TimeSpan BreakDuration = TimeSpan.FromMinutes((double)Time / 60);

            Console.WriteLine ("===== Start True Or False ======\n");
            foreach (Question Question in Section1)
            {
                Question.PrintQuestion();
                if (DateTime.UtcNow - StartTime < BreakDuration)
                {
                    Question.FetchAnswer();
                }
                else
                {
                  
                    Console.WriteLine("Time Finished!");
                }

            }
            Console.WriteLine( "===== End True Or False ======\n");

            Console.WriteLine ("===== Start Choose One ======\n");
            foreach (Question Question in Section2)
            {
                Question.PrintQuestion();
                if (DateTime.UtcNow - StartTime < BreakDuration)
                {
                    Question.FetchAnswer();
                }
                else
                {
                   
                    Console.WriteLine("Time Finished!");
                }

            }
            Console.WriteLine ("===== End Choose One ======\n");

            Console.WriteLine ("===== Start Choose All ======\n");
            foreach (Question Question in Section3)
            {
                Question.PrintQuestion();
                if (DateTime.UtcNow - StartTime < BreakDuration)
                {
                    Question.FetchAnswer();
                }
                else
                {
                   
                    Console.WriteLine("Time Finished!");
                }
            }
            Console.WriteLine ("===== End Choose All ======\n");

            Console.WriteLine ("---------- End Exam ------------\n");
        }

        internal void ShowExamResult()
        {
            Console.WriteLine ("---------- Start Exam Result ----------\n");
            foreach (Question Question in Questions)
            {
                Question.PrintQuestion();
                var RW = Question as RightWrong;
                var CA = Question as ChooseAll;
                var CO = Question as ChooseOne;
                string stdAnswer = string.Empty;
                if (RW != null && RW.StudentAnswer != null) stdAnswer = RW.StudentAnswer.ToString();
                else if (CO != null && CO.StudentAnswer != null) stdAnswer = CO.StudentAnswer.ToString();
                else if (CA != null && CA.StudentAnswer != null) stdAnswer = string.Join('-', CA.StudentAnswer.data);
                var Output = (stdAnswer is null || stdAnswer.Length == 0) ? "Timeout, Empty!" : stdAnswer;
                Console.WriteLine($"Your answer: {Output}");

                if (Type == ExamType.Practice)
                {
                    Console.WriteLine($"Correct answer: {Question.CorrectAnswer}");
                }
                Console.WriteLine($"Your mark: {Question.GetMarks()??"0"}\n");
            }

            IsPassed();
            Console.WriteLine ("---------- End Exam Result ------------\n");
        }

        private void IsPassed()
        {
            int TotalQuestionsMarks = 0;

            float TotalStudentMarks = 0;

            foreach (Question Question in Questions)
            {
                TotalQuestionsMarks += Question.Marks;
                TotalStudentMarks += Question.StudentMark;
            }

            if ((TotalStudentMarks / TotalQuestionsMarks) >= 0.5f)
            {
                Status = Status.Passed;
            }
            else
            {
                Status = Status.Failed;
            }

            Console.WriteLine($"Your final mark is {TotalStudentMarks} / {TotalQuestionsMarks}");
            Console.Write($"You ");
            Console.WriteLine (Status);
            Console.WriteLine();
        }
    }
}

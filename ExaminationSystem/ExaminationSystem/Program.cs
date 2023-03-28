namespace ExaminationSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine ("***** Welcome to ITI - Examination System *****");
            Console.WriteLine();

            Console.WriteLine("Choose one of the following Subjects using the index.\n");
            Console.WriteLine("Subjects:\n");

            Subject[] Subjects = InitSubjects();

            StartSystem(Subjects);
        }

        private static void StartSystem(Subject[] Subjects)
        {
            int _Level1Input = 0;
            int _Level2Input = 0;

            do
            {
                if (_Level1Input < Subjects.Length + 1 && _Level1Input > 0)
                {
                    do
                    {
                        Subject SelectedSubject = Subjects[_Level1Input - 1];

                        if (_Level2Input < 3 && _Level2Input > 0)
                        {
                            Exam Exam = (_Level2Input == 1) ? SelectedSubject.PracticeExam : SelectedSubject.FinalExam;
                            Exam.AnswerExam();
                            Exam.ShowExamResult();
                            Console.WriteLine("Enter anything to go back..");
                        }
                        else
                        {
                            DisplayLevel2(SelectedSubject);
                        }

                    } while (!int.TryParse(Console.ReadLine(), out _Level2Input) || _Level2Input != 3);
                    DisplayLevel1(Subjects);

                }
                else
                {
                    DisplayLevel1(Subjects);
                }

            } while (!int.TryParse(Console.ReadLine(), out _Level1Input) || _Level1Input != Subjects.Length + 1);
        }

        private static void DisplayLevel1(Subject[] Subjects)
        {
            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.Write($"{i + 1} - {Subjects[i].Name} ({Subjects[i].Code}) [");
                Console.WriteLine (Subjects[i].Status);
                Console.WriteLine($"    {Subjects[i].Description}");
            }
            Console.WriteLine($"{Subjects.Length + 1} - Exit");
        }

        private static void DisplayLevel2(Subject SelectedSubject)
        {
            Exam PracticeExam = SelectedSubject.PracticeExam;
            Exam FinalExam = SelectedSubject.FinalExam;

            Status FinalExamStatus = FinalExam.Status;
            SelectedSubject.Status = FinalExamStatus;

            Console.Write($"1- Practice Exam ({PracticeExam.NoOfQuestions} Question(s), Duration: {PracticeExam.Time} Seconds) [");
            Console.WriteLine (PracticeExam.Status);
            Console.Write($"2- Final Exam ({FinalExam.NoOfQuestions} Question(s), Duration: {FinalExam.Time} Seconds) [");
            Console.WriteLine (FinalExamStatus);
            Console.WriteLine("3- Back");
        }

        private static Subject[] InitSubjects()
        {
            Subject[] Subjects = new Subject[2];
            Subject CSharp = InitCSharpSubject();
            Subject Math = InitMathSubject();

            Subjects[0] = CSharp;
            Subjects[1] = Math;
            return Subjects;
        }

        private static Subject InitCSharpSubject()
        {
            // True Or False Questions
            RightWrong TOF_Q1 = new RightWrong(header: "1", body: "Is Main() an entry point in C# console program", marks: 5, correctAnswer: new Answer<bool>(true));
            RightWrong TOF_Q2 = new RightWrong("2", "Is string a reference type in C#", 5, new Answer<bool>(true));
            // Choose One Questions
            ChooseOne CO_Q1 = new ChooseOne(header: "1", body: "Struct is a _____", marks: 5, options: new List<string> { "Reference Type", "Value Type", "Class Type", "String Type" }, correctAnswer: new Answer<string>("2"));
            ChooseOne CO_Q2 = new ChooseOne("2", "Which of the following datatype can be used with enum", 5, new List<string> { "int", "string", "boolean", "All of the above" }, new Answer<string>("1"));
            // Choose All Questions
            ChooseAll CA_Q1 = new ChooseAll(header: "1", body: "Which statement is allowed", marks: 5, options: new List<string> { "int x = 10;", "string x = 10;", "int x = '1';", "char x = 10;" }, correctAnswer: new Answer<string>("1,3"));

            // Exams
            Exam PracticeExam = new Exam(type: ExamType.Practice, time: 5, noOfQuestions: 5, questions: new List<Question>() { TOF_Q1, TOF_Q2, CO_Q1, CO_Q2, CA_Q1 }, Status.NotExamedYet);
            Exam FinalExam = new Exam(ExamType.Final, 300, 5, new List<Question>() { TOF_Q1, TOF_Q2, CO_Q1, CO_Q2, CA_Q1 }, Status.NotExamedYet);

            return new Subject(name: "C#", description: "C# (pronounced C sharp) is a general-purpose high-level programming language.", code: "CSE101", status: Status.NotExamedYet, practiceExam: PracticeExam, finalExam: FinalExam);
        }

        private static Subject InitMathSubject()
        {
            // True Or False Questions
            RightWrong TOF_Q1 = new RightWrong("1", "2 x 5 = 10", 5, new Answer<bool>(true));
            RightWrong TOF_Q2 = new RightWrong("2", "13 % 3 = 3", 5, new Answer<bool>(false));
            // Choose One Questions
            ChooseOne CO_Q1 = new ChooseOne("1", "3 x 10 + 5", 5, new List<string> { "45", "35", "54", "53" }, new Answer<string>("2"));
            ChooseOne CO_Q2 = new ChooseOne("2", "2 - 3 - 5 - 7 - ____", 5, new List<string> { "8", "9", "10", "11" }, new Answer<string>("4"));
            // Choose All Questions
            ChooseAll CA_Q1 = new ChooseAll("1", "8 x 2 =", 5, new List<string> { "16", "10", "16", "5" }, new Answer<string>("1,3"));
            ChooseAll CA_Q2 = new ChooseAll("2", "5 x 10 =", 5, new List<string> { "50", "5", "15", "51" }, new Answer<string>("1"));

            // Exams
            Exam PracticeExam = new Exam(ExamType.Practice, 300, 6, new List<Question>() { TOF_Q1, TOF_Q2, CO_Q1, CO_Q2, CA_Q1, CA_Q2 }, Status.NotExamedYet);
            Exam FinalExam = new Exam(ExamType.Final, 300, 6, new List<Question>() { TOF_Q1, TOF_Q2, CO_Q1, CO_Q2, CA_Q1, CA_Q2 }, Status.NotExamedYet);

            return new Subject("Math", "Mathematics is an area of knowledge that includes the topics of numbers, formulas.", "CSE102", Status.NotExamedYet, PracticeExam, FinalExam);
        }
    }
}
namespace ExaminationSystem
{
    internal class Subject
    {
        public Subject(string name, string description, string code, Status status, Exam practiceExam, Exam finalExam)
        {
            Name = name;
            Description = description;
            Code = code;
            Status = status;
            PracticeExam = practiceExam;
            FinalExam = finalExam;
        }

        internal string Name { get; set; }

        internal string Description { get; set; }

        internal string Code { get; set; }

        internal Status Status { get; set; }

        internal Exam PracticeExam { get; set; }

        internal Exam FinalExam { get; set; }
    }
}
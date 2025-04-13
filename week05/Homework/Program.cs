using System; // Keep this
using HomeworkLibrary; // Updated namespace

namespace Homework // Keep the Homework namespace here
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test MathAssignment
            MathAssignment mathAssignment = new MathAssignment("Jane Doe", "Algebra", "Section 2.3", "Problems 1-10");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());

            // Test WritingAssignment
            WritingAssignment writingAssignment = new WritingAssignment("John Smith", "History", "The Causes of World War II");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }

    class Assignment
    {
        private string studentName;
        private string subject;

        public Assignment(string studentName, string subject)
        {
            this.studentName = studentName;
            this.subject = subject;
        }

        public string GetSummary()
        {
            return $"Student: {studentName}, Subject: {subject}";
        }
    }

    class MathAssignment : Assignment
    {
        private string section;
        private string problems;

        public MathAssignment(string studentName, string subject, string section, string problems)
            : base(studentName, subject)
        {
            this.section = section;
            this.problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section: {section}, Problems: {problems}";
        }
    }

    class WritingAssignment : Assignment
    {
        private string title;

        public WritingAssignment(string studentName, string subject, string title)
            : base(studentName, subject)
        {
            this.title = title;
        }

        public string GetWritingInformation()
        {
            return $"Title: {title}";
        }
    }
}
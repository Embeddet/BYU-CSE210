namespace HomeworkLibrary
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        // Constructor that calls the base class constructor
        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
            : base(studentName, topic) // Call the base class constructor
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        // Method to get the homework list
        public string GetHomeworkList()
        {
            return $"Textbook Section: {_textbookSection}, Problems: {_problems}";
        }
    }
}
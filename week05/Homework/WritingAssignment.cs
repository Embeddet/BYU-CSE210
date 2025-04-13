namespace HomeworkLibrary
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        // Constructor that calls the base class constructor
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic) // Call the base class constructor
        {
            _title = title;
        }

        // Method to get writing information
        public string GetWritingInformation()
        {
            // Use the GetStudentName method from the base class to access the student's name
            return $"Student: {GetStudentName()}, Title: {_title}";
        }
    }
}
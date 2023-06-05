using System;

namespace Learning04
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment(string studentname, string topic)
        {
            _topic = topic;
            _studentName = studentname;
        }

        public string GetSummary(string studentname, string topic)
        {
            Console.WriteLine($"{studentname} - {topic}");
            return studentname;
        }
    }
}
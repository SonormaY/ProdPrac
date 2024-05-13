namespace TaskLast
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int Hours { get; set; }
        public Course(string courseName, string teacher, int hours)
        {
            CourseName = courseName;
            Teacher = teacher;
            Hours = hours;
        }
        public override string ToString()
        {
            return $"{CourseName} {Teacher} {Hours}";
        }
        public string ToFile()
        {
            return $"{CourseName},{Teacher},{Hours}";
        }
    }
}

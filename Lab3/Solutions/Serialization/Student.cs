namespace Serialization
{
    public class Student : Person
    {
        public required string IndexNumber { get; set; }
        public required string GroupNumber { get; set; }
        public Student(string firstName, string lastName, int age, DateTime birthDate, string indexNumber, string groupNumber)
            : base(firstName, lastName, age, birthDate)
        {
            IndexNumber = indexNumber;
            GroupNumber = groupNumber;
        }

        public Student() { }
    }
}

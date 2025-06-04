namespace Serialization
{
    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string firstName, string lastName, int age, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDate = birthDate;
        }

        public Person() { }
    }
}

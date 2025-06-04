using Serialization;

List<Person> people = new List<Person>
              {
                  new Person { FirstName = "Andy", LastName = "Smith", Age = 30, BirthDate = new DateTime(1968, 5, 10) },
                  new Person { FirstName = "John", LastName = "Doe", Age = 40, BirthDate = new DateTime(1968, 3, 12) }
              };

List<Student> students = new List<Student>
              {
                  new Student { FirstName = "Anna", LastName = "Kowalski", Age = 21, BirthDate = new DateTime(2000, 1, 15), IndexNumber = "S123", GroupNumber = "G1" },
                  new Student { FirstName = "Christopher", LastName = "Chain", Age = 22, BirthDate = new DateTime(2002, 11, 23), IndexNumber = "S124", GroupNumber = "G1" }
              };

string peopleXmlPath = "people.xml";
string studentsXmlPath = "students.xml";
string peopleJsonPath = "people.json";
string studentsJsonPath = "students.json";

// XML Serialization
FileTransformer.SerializeToXml(people, peopleXmlPath);
FileTransformer.SerializeToXml(students, studentsXmlPath);

// JSON Serialization
FileTransformer.SerializeToJson(people, peopleJsonPath);
FileTransformer.SerializeToJson(students, studentsJsonPath);

// XML Deserialization
var loadedPeopleFromXml = FileTransformer.DeserializeFromXml<List<Person>>(peopleXmlPath) ?? new List<Person>();
var loadedStudentsFromXml = FileTransformer.DeserializeFromXml<List<Student>>(studentsXmlPath) ?? new List<Student>();

// JSON Deserialization
var loadedPeopleFromJson = FileTransformer.DeserializeFromJson<List<Person>>(peopleJsonPath) ?? new List<Person>();
var loadedStudentsFromJson = FileTransformer.DeserializeFromJson<List<Student>>(studentsJsonPath) ?? new List<Student>();

Console.WriteLine("\nPeople from XML:");

foreach (var person in loadedPeopleFromXml)
    Console.WriteLine($"{person.FirstName} {person.LastName} - Age: {person.Age}, BirthDate: {person.BirthDate.ToShortDateString()}");

Console.WriteLine("\nStudents from JSON:");

foreach (var student in loadedStudentsFromJson)
    Console.WriteLine($"{student.FirstName} {student.LastName} - Index: {student.IndexNumber}, Group: {student.GroupNumber}");

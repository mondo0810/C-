namespace GenericExample
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public override string ToString()
        {
            return $"Student - Id: {Id}, Name: {StudentName}";
        }
    }
}
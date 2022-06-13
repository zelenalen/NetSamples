namespace NetSamples.Classes
{
    public class Employee
    {

        public readonly int Id;
        public string DateOfBirth { get; }
        
        public string Position { get; set; }

        public Employee(int id, string dateOfBirth, string position)
        {
            Id = id;
            DateOfBirth = dateOfBirth;
            Position = position;
        }

        public void Do()
        {

        }
    }
}

namespace Mooo.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department? Department { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}

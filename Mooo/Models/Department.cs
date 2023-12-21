namespace Mooo.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Section>? Sections {  get; set; }
    }
}

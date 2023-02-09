namespace moment3.Models
{
    public class Artist
    {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }

        // Relationship with record
        public List<Record> Record { get; set; }
    }
}

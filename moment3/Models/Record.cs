namespace moment3.Models
{
    public class Record
    {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Year { get; set; }

        // Relationship with artist
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}

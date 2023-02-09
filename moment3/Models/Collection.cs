using System.ComponentModel.DataAnnotations;

namespace moment3.Models
{
    public class Artist
    {
        // Properties
        public int Id { get; set; }

        [Display(Name= "Namn")]
        public string? Name { get; set; }

        // Relationship with record
        public List<Record>? Record { get; set; }
    }

    public class Record
    {
        // Properties
        public int Id { get; set; }

        [Display(Name = "Namn på album")]
        public string? Name { get; set; }

        [Display(Name = "Utgivningsår")]
        public string? Year { get; set; }

        // Relationship with artist

        [Display(Name = "Artist")]

        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}

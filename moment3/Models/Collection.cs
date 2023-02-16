using System.ComponentModel.DataAnnotations;

namespace moment3.Models
{
    public class Artist
    {
        // Properties
        public int Id { get; set; }

        [Display(Name= "Namn")]
        [Required(ErrorMessage = "Du måste ange artistens namn")]
        public string? Name { get; set; }

        // Relationship with record
        public List<Record>? Record { get; set; }
    }

    public class Record
    {
        // Properties
        public int Id { get; set; }

        [Display(Name = "Namn på album")]
        [Required(ErrorMessage = "Du måste ange albumets namn")]
        public string? Name { get; set; }

        [Display(Name = "Utgivningsår")]
        [Required(ErrorMessage = "Du måste ange utgivningsår")]
        public string? Year { get; set; }

        // Relationship with artist

        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}

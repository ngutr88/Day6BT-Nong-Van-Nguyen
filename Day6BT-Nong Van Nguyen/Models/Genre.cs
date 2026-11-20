using System.ComponentModel.DataAnnotations;

namespace Day6BT_Nong_Van_Nguyen.Models;

public class Genre
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a genre name.")]
    [StringLength(100)]
    [Display(Name = "Genre Name")]
    public string Name { get; set; } = string.Empty;

    public ICollection<Movie> Movies { get; set; } = new List<Movie>();
}

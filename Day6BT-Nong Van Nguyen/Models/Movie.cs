using System.ComponentModel.DataAnnotations;

namespace Day6BT_Nong_Van_Nguyen.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a movie title.")]
    [StringLength(200)]
    [Display(Name = "Title")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 1440, ErrorMessage = "Duration must be between 1 and 1440 minutes.")]
    [Display(Name = "Duration (minutes)")]
    public int Duration { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Please select a genre.")]
    [Display(Name = "Genre")]
    public int GenreId { get; set; }

    [Display(Name = "Genre")]
    public Genre? Genre { get; set; }
}

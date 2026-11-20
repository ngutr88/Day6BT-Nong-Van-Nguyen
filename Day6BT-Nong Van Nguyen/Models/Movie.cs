using System.ComponentModel.DataAnnotations;

namespace Day6BT_Nong_Van_Nguyen.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập tên phim.")]
    [StringLength(200)]
    [Display(Name = "Tên phim")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [Display(Name = "Ngày phát hành")]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 1440, ErrorMessage = "Thời lượng phải từ 1 đến 1440 phút.")]
    [Display(Name = "Thời lượng (phút)")]
    public int Duration { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn thể loại.")]
    [Display(Name = "Thể loại")]
    public int GenreId { get; set; }

    [Display(Name = "Thể loại")]
    public Genre? Genre { get; set; }
}

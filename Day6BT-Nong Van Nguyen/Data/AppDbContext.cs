using Day6BT_Nong_Van_Nguyen.Models;
using Microsoft.EntityFrameworkCore;

namespace Day6BT_Nong_Van_Nguyen.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Một thể loại có nhiều phim. Không xóa thể loại khi vẫn còn phim.
        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Genre)
            .WithMany(g => g.Movies)
            .HasForeignKey(m => m.GenreId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Movie>().Property(m => m.ReleaseDate).HasColumnType("date");
    }
}

using Microsoft.EntityFrameworkCore;

namespace PgDatabaseFirst.Models{
    public class GuestBookDataContext : DbContext
    {
        public GuestBookDataContext(DbContextOptions<GuestBookDataContext> options) :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestBook>().ToTable("guestbook");
            modelBuilder.Entity<GuestBook>(entity =>
            {
               entity.Property(e => e.Id).HasColumnName("id");
               entity.Property(e => e.Email).HasColumnName("email");
               entity.Property(e => e.Name).HasColumnName("name");
               entity.Property(e => e.Message).HasColumnName("message");
            });
            modelBuilder.Entity<GuestBook>().HasKey(e => new { e.Id});
        }
        public virtual DbSet<GuestBook> GuestBooks { get; set; }
    }
}
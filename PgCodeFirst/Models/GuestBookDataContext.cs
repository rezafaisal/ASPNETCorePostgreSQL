using Microsoft.EntityFrameworkCore;

namespace PgCodeFirst.Models
{
    public class GuestBookDataContext : DbContext
    {
        public GuestBookDataContext(DbContextOptions<GuestBookDataContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestBook>().HasKey(e => new { e.Id});
        }

        public virtual DbSet<GuestBook> GuestBooks { get; set; }
    }
}
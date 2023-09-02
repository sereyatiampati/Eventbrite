using Eventbrite.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventbrite.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Events)
        //        .WithOne(e => e.User)
        //        .HasForeignKey(e => e.UserId)
        //        .OnDelete(DeleteBehavior.Cascade);
        //}
    }
}

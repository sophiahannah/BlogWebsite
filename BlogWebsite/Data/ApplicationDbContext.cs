using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Models;

namespace BlogWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        
        public DbSet<Post> Posts { get; set; }
    }
}
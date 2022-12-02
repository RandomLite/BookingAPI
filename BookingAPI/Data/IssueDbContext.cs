using BookingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.Data
{
    public class IssueDbContext:DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
        { }
        public DbSet<Issue> Issue { get; set; }  
    }
}

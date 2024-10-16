using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using StringingStore.Models.Entities;

namespace StringingStore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
           
        }
        public DbSet<StringJob> stringJobs { get; set; }
    }
}

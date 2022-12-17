using Jeevithaproject.Models;
using Microsoft.EntityFrameworkCore;

namespace Jeevithaproject.Data
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) 
        {
        }
        public DbSet<SchoolDetails> Schols { get; set; }

    }
}

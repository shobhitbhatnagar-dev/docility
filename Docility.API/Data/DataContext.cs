using Docility.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Docility.API.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
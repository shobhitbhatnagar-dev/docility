using Docility.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Docility.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<Workgroup> Workgroups { get; set; }


    }
}
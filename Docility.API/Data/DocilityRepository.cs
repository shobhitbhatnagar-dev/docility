using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docility.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Docility.API.Data
{
    public class DocilityRepository : IDocilityRepository
    {
        private readonly DataContext _context;
        public DocilityRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Bug> GetBug(int id)
        {
           var Bug = await _context.Bugs
            .Include( p => p.Project)
            .Include( m => m.Module)
            .Include( c => c.Communications)
            .Include( a => a.Attachments)
            .Include( w => w.Workgroup )
            .FirstOrDefaultAsync(b => b.Id == id);
            return Bug;
        }

        public async Task<IEnumerable<Bug>> GetBugs()
        {
            var Bugs = await _context.Bugs
            .Include( p => p.Project)
            .Include( m => m.Module)
            .Include( c => c.Communications)
            .Include( a => a.Attachments)
            .Include( w => w.Workgroup )
            .ToListAsync();

            return Bugs;
        }

        public async Task<Module> GetModule(int id)
        {
            var module = await _context.Modules.FirstOrDefaultAsync(m => m.Id == id);

            return module;
        }

        public async Task<IEnumerable<Module>> GetModules()
        {
            var modules = await _context.Modules.Include(p => p.Projects).ToListAsync();
            return modules;
        }

        public async Task<IEnumerable<Module>> GetModulesByProject(int projectId)
        {
            var modules = await _context.Modules.Include(p=> p.Projects).Where(m => m.ProjectId == projectId).ToListAsync();
            return modules;
        }

        public async Task<Project> GetProject(int id)
        {
            var project = await _context.Projects.Include(m => m.Modules).FirstOrDefaultAsync(p => p.Id == id);
            return project;
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            var projects = await _context.Projects.Include(m => m.Modules).ToListAsync();
            return projects;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);          
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
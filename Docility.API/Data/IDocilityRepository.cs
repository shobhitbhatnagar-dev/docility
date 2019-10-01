using System.Collections.Generic;
using System.Threading.Tasks;
using Docility.API.Models;

namespace Docility.API.Data
{
    public interface IDocilityRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<IEnumerable<Project>> GetProjects();
        Task<Project> GetProject(int id);
        Task<IEnumerable<Module>> GetModules();
        Task<Module> GetModule(int id);
        Task<IEnumerable<Module>> GetModulesByProject(int projectId);
        Task<IEnumerable<Bug>> GetBugs();
        Task<Bug> GetBug(int id);
         

    }
}
using AutoMapper;
using Docility.API.Dtos;
using Docility.API.Models;
using System.Linq;

namespace Docility.API.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public  AutomapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<Module, ModuleByProjectDto>();
            CreateMap<Project, ProjectswithoutModulesDto>();
        }   
    }
}
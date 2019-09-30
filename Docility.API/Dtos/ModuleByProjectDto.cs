using System;

namespace Docility.API.Dtos
{
    public class ModuleByProjectDto
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; } 
        public int ProjectId { get; set; }
        public string ProjectsName { get; set; }
    }
}
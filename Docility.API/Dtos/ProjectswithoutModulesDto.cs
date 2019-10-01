using System;

namespace Docility.API.Dtos
{
    public class ProjectswithoutModulesDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; } 
    }
}
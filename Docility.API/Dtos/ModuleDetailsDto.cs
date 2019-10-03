using System;

namespace Docility.API.Dtos
{
    public class ModuleDetailsDto
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; }
        public ProjectSingleDto Projects { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }
    }
}
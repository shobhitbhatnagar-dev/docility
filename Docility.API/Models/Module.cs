using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Docility.API.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ProjectName is requried")]
        public string ModuleName { get; set; }
        [DefaultValue("admin")]
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Project Projects { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }
    }
}
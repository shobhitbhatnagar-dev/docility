using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Docility.API.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ProjectName is requried")]
        public string ProjectName { get; set; }
        [DefaultValue("dev")]
        public string Createdby { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public ICollection<Module> Modules { get; set; }
        public bool IsActive { get; set; }
    }
}
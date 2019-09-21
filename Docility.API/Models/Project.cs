using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Docility.API.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ProjectName is requried")]
        public string ProjectName { get; set; }

        [DefaultValue("admin")]
        public string createdby { get; set; }
    
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
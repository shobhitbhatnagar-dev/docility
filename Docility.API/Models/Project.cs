using System;
using System.ComponentModel;

namespace Docility.API.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        [DefaultValue("admin")]
        public string createdby { get; set; }
    
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
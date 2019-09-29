using System;
using System.Collections.Generic;

namespace Docility.API.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ModuleId { get; set; }
        public string MouleName { get; set; }
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int ReproducibilityId { get; set; }
        public string Reproducibility { get; set; }
        public string ExpectedResults { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int ReportedBy { get; set; }
        public string ReportedByName { get; set; }
        //Reported On Is auto Populated
        public DateTime ReportedOn { get; set; } = DateTime.Now;
        public int AssignedTo { get; set; }
        public string AssignedToName { get; set; }
        public DateTime AssignedOn { get; set; }
        public string ClosingRemark { get; set; }
        public DateTime ClosedOn { get; set; }
        public Workgroup Workgroup { get; set; }
        public ICollection<Communication> Communications { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Docility.API.Models;

namespace Docility.API.Dtos
{
    public class BugDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProjectSingleDto Project { get; set; }
        public ModuleSingleDto Module { get; set; }
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
        public DateTime ReportedOn { get; set; }
        public int AssignedTo { get; set; }
        public string AssignedToName { get; set; }
        public DateTime AssignedOn { get; set; }
        public string ClosingRemark { get; set; }
        public DateTime ClosedOn { get; set; }
        public WorkgroupSingleDto Workgroup { get; set; }
        public ICollection<AttachmentDetailsDto> Attachments { get; set; }
    }
}
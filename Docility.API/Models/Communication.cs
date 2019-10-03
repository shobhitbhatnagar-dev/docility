using System;

namespace Docility.API.Models
{
    public class Communication
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public User User { get; set; }
        public Bug Bug { get; set; }
        public int BugId { get; set; }
        public bool IsPrivate { get; set; }
        public Workgroup Workgroup { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
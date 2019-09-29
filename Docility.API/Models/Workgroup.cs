using System;

namespace Docility.API.Models
{
    public class Workgroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
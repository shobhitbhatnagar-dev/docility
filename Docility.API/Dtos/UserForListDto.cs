using System;
using Docility.API.Models;

namespace Docility.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailId { get; set; }
        public string role { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastActive { get; set; }
        public Workgroup Workgroup { get; set; }
    }
}
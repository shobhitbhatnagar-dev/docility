using System;
using System.Collections.Generic;

namespace Docility.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string EmailId { get; set; }
        [System.ComponentModel.DefaultValue("dev")]
        public string role { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }
    }
}
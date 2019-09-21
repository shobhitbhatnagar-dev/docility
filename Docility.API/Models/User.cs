using System;

namespace Docility.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        [System.ComponentModel.DefaultValue("admin")]
        public string role { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
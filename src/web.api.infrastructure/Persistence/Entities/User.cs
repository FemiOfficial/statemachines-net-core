using System;

namespace src.web.api.infrastructure.Persistence.Entities
{
    public class User
    {
        public int Id { get; set; } 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; } 
        public bool IsAdmin { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestHub.Interfaces.Models;

namespace TestHub.Models.DB
{
    public class User : IUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Username { get; set; }

        [Index("EmailIndex", IsClustered =false, IsUnique = false)]
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        [Key]
        public int UserID { get; set; }

        public string TempPassword { get; set; }

        public DateTimeOffset ExpirationDate { get; set; }

        public DateTimeOffset TempExpirationDate { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public DateTimeOffset LastLogin { get; set; }
    }
}

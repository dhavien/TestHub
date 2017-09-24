using System;
using System.Collections.Generic;
using System.Text;

namespace TestHub.Interfaces.Models
{
    public interface IUser
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }

        string Username { get; set; }

        string Email { get; set; }

        string PasswordHash { get; set; } 

        string PasswordSalt { get; set; }

        string PhoneNumber { get; set; }

        string City { get; set; }

        int UserID { get; set; }

        string TempPassword { get; set; }

        DateTimeOffset ExpirationDate { get; set; }

        DateTimeOffset TempExpirationDate { get; set; }

        DateTimeOffset LastUpdated { get; set; }

        DateTimeOffset LastLogin { get; set; }
    }
}

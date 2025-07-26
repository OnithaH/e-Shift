using System;

namespace e_Shift.Models
{
    public class Admin
    {
        // Properties matching your database schema
        public int AdminID { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Constructor
        public Admin()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
            Role = "Admin";
        }

        // Parameterized constructor
        public Admin(string username, string firstName, string lastName, string email, string role = "Admin")
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
        }

        // Methods
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetDisplayInfo()
        {
            return $"{Username} - {GetFullName()} ({Role})";
        }

        public bool IsSuperAdmin()
        {
            return Role.Equals("SuperAdmin", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsValidEmail()
        {
            if (string.IsNullOrEmpty(Email))
                return false;

            return Email.Contains("@") && Email.Contains(".");
        }

        public override string ToString()
        {
            return GetDisplayInfo();
        }
    }
}
using System;

namespace e_Shift.Utils
{
    public static class UserSession
    {
        // Current user properties
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static string Email { get; private set; }
        public static string UserType { get; private set; } // "Admin" or "Customer"
        public static string Role { get; private set; } // For Admin: "SuperAdmin", "Manager", etc.
        public static DateTime LoginTime { get; private set; }
        public static bool IsLoggedIn { get; private set; }

        // Login method for Admin
        public static void LoginAdmin(int adminId, string username, string firstName,
                                    string lastName, string email, string role)
        {
            UserId = adminId;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserType = "Admin";
            Role = role;
            LoginTime = DateTime.Now;
            IsLoggedIn = true;
        }

        // Login method for Customer
        public static void LoginCustomer(int customerId, string customerNumber,
                                       string firstName, string lastName, string email)
        {
            UserId = customerId;
            Username = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserType = "Customer";
            Role = "Customer";
            LoginTime = DateTime.Now;
            IsLoggedIn = true;
        }

        // Logout method
        public static void Logout()
        {
            UserId = 0;
            Username = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            UserType = string.Empty;
            Role = string.Empty;
            LoginTime = DateTime.MinValue;
            IsLoggedIn = false;
        }

        // Get full name
        public static string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Check if user is admin
        public static bool IsAdmin()
        {
            return UserType == "Admin";
        }

        // Check if user is customer
        public static bool IsCustomer()
        {
            return UserType == "Customer";
        }

        // Check if user is super admin
        public static bool IsSuperAdmin()
        {
            return UserType == "Admin" && Role == "SuperAdmin";
        }

        // Get session duration
        public static TimeSpan GetSessionDuration()
        {
            if (IsLoggedIn)
                return DateTime.Now - LoginTime;
            return TimeSpan.Zero;
        }
    }
}
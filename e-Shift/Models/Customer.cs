using System;

namespace e_Shift.Models
{
    public class Customer
    {
        // Properties matching your database schema
        public int CustomerID { get; set; }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte[] Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        // Constructor
        public Customer()
        {
            RegistrationDate = DateTime.Now;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
        }

        // Parameterized constructor for creating new customer
        public Customer(string firstName, string lastName, string email, string phone = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            RegistrationDate = DateTime.Now;
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
            return $"{CustomerNumber} - {GetFullName()}";
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
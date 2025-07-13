using System;
using System.Security.Cryptography;
using System.Text;

namespace e_Shift.Utils
{
    public static class PasswordUtils
    {
        // Generate salt for password hashing
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        // Hash password with salt
        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                return sha256.ComputeHash(saltedPassword);
            }
        }

        // Verify password
        public static bool VerifyPassword(string password, byte[] salt, byte[] hashedPassword)
        {
            byte[] hashToCheck = HashPassword(password, salt);

            if (hashToCheck.Length != hashedPassword.Length)
                return false;

            for (int i = 0; i < hashToCheck.Length; i++)
            {
                if (hashToCheck[i] != hashedPassword[i])
                    return false;
            }

            return true;
        }

        // Validate password strength
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                return false;

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasNumber = true;
            }

            return hasUpper && hasLower && hasNumber;
        }

        // Get password validation message
        public static string GetPasswordValidationMessage()
        {
            return "Password must be at least 6 characters long and contain at least one uppercase letter, one lowercase letter, and one number.";
        }
    }
}
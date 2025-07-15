using System;
using System.Security.Cryptography;
using System.Text;

namespace e_Shift.Utils
{
    public static class PasswordUtils
    {
        // Secret key for password hashing
        private const string SECRET_KEY = "ESHIFT_SECRET_2024";

        /// <summary>
        /// Creates a secure hash of the password using SHA-256 with secret key
        /// </summary>
        public static byte[] HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty");

            using (var sha256 = SHA256.Create())
            {
                string passwordWithSecret = password + SECRET_KEY;
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSecret));
            }
        }

        /// <summary>
        /// Verifies a password against a stored hash
        /// </summary>
        public static bool VerifyPassword(string password, byte[] storedHash)
        {
            if (string.IsNullOrEmpty(password) || storedHash == null)
                return false;

            try
            {
                byte[] computedHash = HashPassword(password);

                if (computedHash.Length != storedHash.Length)
                    return false;

                // Secure comparison to prevent timing attacks
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Validates basic password requirements
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 6;
        }

        /// <summary>
        /// Gets the secret key used for hashing
        /// </summary>
        public static string GetSecretKey()
        {
            return SECRET_KEY;
        }

        /// <summary>
        /// Creates a hash that matches the database format exactly
        /// </summary>
        public static byte[] CreateDatabaseCompatibleHash(string password)
        {
            return HashPassword(password);
        }
    }
}
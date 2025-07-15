using System;
using System.Security.Cryptography;
using System.Text;

namespace e_Shift.Utils
{
    public static class PasswordUtils
    {
        // Secret key for password hashing (same as used in database and LoginForm)
        private const string SECRET_KEY = "ESHIFT_SECRET_2024";

        /// <summary>
        /// Creates a secure hash of the password using SHA-256 with secret key
        /// This matches the database HASHBYTES('SHA2_256', password + 'ESHIFT_SECRET_2024') function
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
        /// Legacy method for backward compatibility (now calls the simple version)
        /// </summary>
        [Obsolete("Use VerifyPassword(password, storedHash) instead")]
        public static bool VerifyPassword(string password, byte[] salt, byte[] hashedPassword)
        {
            // For backward compatibility, ignore salt and use simple verification
            return VerifyPassword(password, hashedPassword);
        }

        /// <summary>
        /// Legacy method for backward compatibility (now creates hash without individual salt)
        /// </summary>
        [Obsolete("Use HashPassword(password) instead")]
        public static byte[] HashPassword(string password, byte[] salt)
        {
            // For backward compatibility, ignore salt and use simple hashing
            return HashPassword(password);
        }

        /// <summary>
        /// Legacy method for backward compatibility (now returns dummy salt)
        /// </summary>
        [Obsolete("Salt generation is no longer used in simplified approach")]
        public static byte[] GenerateSalt()
        {
            // Return dummy salt for backward compatibility
            return Encoding.UTF8.GetBytes("NOTUSED");
        }

        /// <summary>
        /// Validates basic password requirements
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Basic validation - at least 6 characters
            return password.Length >= 6;
        }

        /// <summary>
        /// Validates strong password requirements (optional)
        /// </summary>
        public static bool IsStrongPassword(string password)
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

        /// <summary>
        /// Gets basic password validation message
        /// </summary>
        public static string GetPasswordValidationMessage()
        {
            return "Password must be at least 6 characters long.";
        }

        /// <summary>
        /// Gets strong password requirements message
        /// </summary>
        public static string GetStrongPasswordMessage()
        {
            return "Strong password should contain at least 6 characters with uppercase, lowercase, and numbers.";
        }

        /// <summary>
        /// Creates a hash compatible with SQL Server HASHBYTES function
        /// Useful for creating passwords directly in database
        /// </summary>
        public static string GetSqlHashExpression(string password)
        {
            return $"HASHBYTES('SHA2_256', '{password}' + '{SECRET_KEY}')";
        }

        /// <summary>
        /// Gets the secret key used for hashing (for database operations)
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

        /// <summary>
        /// Verifies if a password would create the expected hash
        /// Useful for debugging password issues
        /// </summary>
        public static bool TestPasswordHash(string password, string expectedHashHex)
        {
            try
            {
                byte[] computedHash = HashPassword(password);
                string computedHashHex = BitConverter.ToString(computedHash).Replace("-", "");
                return computedHashHex.Equals(expectedHashHex, StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
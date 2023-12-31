﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    // Class User inherits from BaseClass and represents a user entity with various properties.
    public class User : BaseClass
    {
        public User()
        {
            Salt = GenerateSalt();
        }

        

        // Public properties to hold user information that can be accessed and modified externally.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DietType? Diet {  get; set; } // Enum to represent user's diet type.
        public decimal? Weight { get; set; }

        private decimal height;

        public decimal? Height
        {
            get { return height; }
            set 
            {
                if (value > 2.5m)
                {
                    value = value / 100;
                }

                height = (decimal)value; 
            }
        }

        //public decimal? Height { get; set; }
        public string Username { get; set; }
        
        public GoalType? Goal { get; set; } // Enum to represent user's dietary goal.
        public ICollection<Meal> UserMeals { get; set; } // Collection of meals consumed by the user up to that point.
        private decimal bmi;

        public decimal? BMI { get; set; }

        public UserType Type { get; set; }
        public decimal? HedefKalori { get; set; }


        // Private field to store the hashed password, which is not directly accessible outside the class.
        private string _hashedPassword;

        // Public property to set the password. The set method hashes the password and stores it.
        public string Password
        {
            private get { return _hashedPassword; }
            set 
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Şifre 6 karakterden kısa olamaz.");
                }
                if (!value.Any(char.IsUpper))
                {
                    throw new ArgumentException("Şifre en az 1 büyük harf içermeli.");
                }
                if (!value.Any(char.IsLower)) 
                {
                    throw new ArgumentException("Şifre en az 1 küçük harf içermeli.");
                }
                if (!value.Any(char.IsDigit)) 
                {
                    throw new ArgumentException("Şifre en az 1 rakam içermeli.");
                }

                _hashedPassword = HashPassword(value); 
            }
        }

        // Method to verify if the provided password matches the stored hashed password.
        public bool VerifyPassword(string password)
        {
            // Hashes the input password and compares it with the stored hashed password.
            return HashPassword(password) == _hashedPassword;
        }

        // Private method to hash the password using SHA256.
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedPassword = string.Concat(password, _salt);
                // Computes the SHA256 hash of the password bytes.
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedPassword));
                // Converts the byte array to a hexadecimal string.
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public void ChangePassword(string password)
        {
            Salt = GenerateSalt();
            Password = password;
            
        }

        //private string _salt;

        private string _salt;

        public string? Salt
        {
            get { return _salt; }
            set { _salt = value; }
        }


        private string GenerateSalt()
        {
            byte[] randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create()) 
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);

        }

    }
}

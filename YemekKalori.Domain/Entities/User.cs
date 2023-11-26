﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    // Class User inherits from BaseClass and represents a user entity with various properties.
    public class User : BaseClass
    {
        // Public properties to hold user information that can be accessed and modified externally.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DietType Diet {  get; set; } // Enum to represent user's diet type.
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Username { get; set; }
        public AccountStatus Status { get; set; } // Enum to represent the user's account status.
        public GoalType Goal { get; set; } // Enum to represent user's dietary goal.
        public ICollection<Meal> Meals { get; set; } // Collection of meals consumed by the user up to that point.

        // Private field to store the hashed password, which is not directly accessible outside the class.
        private string _hashedPassword;

        // Public property to set the password. The set method hashes the password and stores it.
        public string Password
        {
            
            set { _hashedPassword = HashPassword(value); }
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
                // Computes the SHA256 hash of the password bytes.
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Converts the byte array to a hexadecimal string.
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }



    }
}
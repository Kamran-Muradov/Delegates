﻿
namespace Delegates_Homework.Models
{
    internal class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

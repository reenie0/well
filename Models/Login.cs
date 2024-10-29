﻿namespace ScheduleApp.Models
{
    public class LoginViewModel
    {
        public required string Email { get; set; }
        public required  string Password { get; set; }
        public required string UserType { get; set; } // "Student" or "Lecturer"
    }
}


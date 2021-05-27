using System;
using System.ComponentModel.DataAnnotations;
using BlazorDemo.Data.Annotations;

namespace BlazorDemo.Data {
    public class UserDataBase {
        [Required(ErrorMessage = "The Username value should be specified.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "The Password value should be specified.")]
        [MinPasswordLength(6, "The Password must be at least 6 characters long.")]
        public string Password { get; set; }
    }

    public class UserData: UserDataBase {
        public static DateTime BirthDateNullValue { get; set; } = new DateTime(1970, 1, 1);

        [Required(ErrorMessage = "The Email value should be specified.")]
        [Email(ErrorMessage = "The Email value is invalid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Phone value should be specified.")]
        public string Phone { get; set; }

        [DateInPast(YearsAgo = 18,  ErrorMessage = "Users should be at least 18 years old to register.")]
        public DateTime BirthDate { get; set; } = BirthDateNullValue;
        public string Occupation { get; set; }
        public string Notes { get; set; }
    }
}

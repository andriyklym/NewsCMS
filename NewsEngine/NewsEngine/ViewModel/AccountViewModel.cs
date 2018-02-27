using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewsEngine.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(5)]
        public string Login;

        [Required]
        [EmailAddress]
        public string Email;

        [Required]
        [MinLength(5)]
        public string Password;

        [Required]
        [MinLength(5)]
        public string ConfirmPassword;

        [Required]
        [MinLength(3)]
        public string Name;
    }
}
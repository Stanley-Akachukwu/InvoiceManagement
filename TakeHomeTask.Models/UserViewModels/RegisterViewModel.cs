using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.UserViewModels;

namespace TakeHome.Models.UserModels
{
    public class RegisterViewModel: UserManagerResponse
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email does not match!")]
        public string ConfirmEmail { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [CompareProperty("Password", ErrorMessage = "Password and Confirm Password does not match!")]
        public string ConfirmPassword { get; set; }
    }
}

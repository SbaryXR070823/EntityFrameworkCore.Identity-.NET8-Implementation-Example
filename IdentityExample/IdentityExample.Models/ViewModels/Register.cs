using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IdentityExample.Models.ViewModels
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [DataType(DataType.EmailAddress)] 
        public string? Email { get; set;}

        [Required(ErrorMessage = "Username is required!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirmation password is required!")]
        [Compare("Password", ErrorMessage ="Passwords don't match!")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}

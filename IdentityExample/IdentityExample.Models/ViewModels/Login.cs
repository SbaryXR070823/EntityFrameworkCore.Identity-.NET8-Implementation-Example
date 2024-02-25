﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityExample.Models.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "Username is required!")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Password is required!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remeber me")]
        public bool RemembeMe { get; set; }
    }
}

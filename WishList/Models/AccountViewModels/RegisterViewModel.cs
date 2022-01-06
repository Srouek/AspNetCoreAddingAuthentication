﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required,StringLength(100),MinLength(8)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare("Password")]
        public String ConfirmPassword { get; set; }


    }
}
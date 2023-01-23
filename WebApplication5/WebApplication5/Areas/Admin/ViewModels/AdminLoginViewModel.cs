﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Areas.Admin.ViewModels
{
    public class AdminLoginViewModel
    {
        [Required]
        [StringLength(maximumLength: 20)]
        public string UserName { get; set;}

        [Required]
        [StringLength(maximumLength: 20,MinimumLength =8)]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}

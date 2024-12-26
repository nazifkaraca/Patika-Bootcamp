﻿using System.ComponentModel.DataAnnotations;

namespace Week14_2_Pratik.ViewModel
{
    public class CreateAccountViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
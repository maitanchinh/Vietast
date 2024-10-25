﻿using System.ComponentModel.DataAnnotations;

namespace Vietast.Web.Models
{
    public class LoginRequestDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

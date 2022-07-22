using System;
using System.ComponentModel.DataAnnotations;

namespace TRY.Models
{
    public class Register
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
      
     
    }
}


using System;
using System.ComponentModel.DataAnnotations;
namespace Account.Entity { 
    
    public class Account
    {
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$",ErrorMessage ="Weak Password")]
        public string Password { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

    }
}

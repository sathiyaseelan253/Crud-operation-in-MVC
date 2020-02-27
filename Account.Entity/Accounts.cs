using System;
using System.ComponentModel.DataAnnotations;
namespace Account.Entity { 
    
    public class Accounts
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "City required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Qualification required")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "ContactNo required")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; } 
        [Required(ErrorMessage = "Gender required")]
        public string Gender { get; set; }

    }
}

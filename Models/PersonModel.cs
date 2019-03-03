using System;
using System.ComponentModel.DataAnnotations;

namespace Cucumber.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Required]
        [Display(Name = "Number")]
        public decimal Money { get; set; }
        public string MoneyInWords { get; set; }
    }
}
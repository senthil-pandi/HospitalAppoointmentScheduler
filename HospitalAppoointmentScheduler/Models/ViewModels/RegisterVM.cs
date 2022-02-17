using System.ComponentModel.DataAnnotations;

namespace HospitalAppointmentScheduler.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="The {0} must be atleast {2} characters long", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Please enter the same password you entered above")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name ="Your Role")]
        public string RoleName { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace HospitalAppointmentScheduler.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

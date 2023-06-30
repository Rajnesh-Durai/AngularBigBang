using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BigBangAngular30thJune.Models
{
    public class DoctorDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? DoctorName { get; set; }
        public string? Specialization { get; set; }
        public int YearsOfExperience { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}

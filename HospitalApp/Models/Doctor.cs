namespace HospitalApp.Models
{
    public class Doctor : Person
    {
        public Guid HospitalId { get; set; }
        public string? Speciality { get; set; }

    }
}

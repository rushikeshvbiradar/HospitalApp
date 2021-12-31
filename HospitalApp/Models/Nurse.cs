namespace HospitalApp.Models
{
    public class Nurse: Person
    {
        public Guid HospitalId { get; set; }
        public int WardNumber { get; set; }

    }
}

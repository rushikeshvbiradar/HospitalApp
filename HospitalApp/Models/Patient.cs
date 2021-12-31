namespace HospitalApp.Models
{
    public class Patient: Person
    {
        public Guid HospitalId { get; set; }
        public string? Disease { get; set; }
        public int WardNumber { get; set; }
        public int BedNumber { get; set; }

    }
}

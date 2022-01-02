namespace HospitalApp.Models
{
    public class Appointment : BaseModel
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Appointment()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}

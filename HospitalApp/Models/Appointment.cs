namespace HospitalApp.Models
{
    public class Appointment : BaseModel
    {
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}

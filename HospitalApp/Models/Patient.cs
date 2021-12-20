namespace HospitalApp.Models
{
    public class Patient: Person
    {
        public string disease { get; set; }

        public int wardNumber { get; set; }

        public int bedNumber { get; set; }

        public Patient(string _disease, int _wardNumber, int _bedNumber) {
            disease = _disease;
            wardNumber = _wardNumber;
            bedNumber = _bedNumber;
        }
    }
}

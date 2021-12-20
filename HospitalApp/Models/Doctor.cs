

namespace HospitalApp.Models
{
    public class Doctor : Person
    {
        public int hospitalId { get; set; }

        public string speciality { get; set; }

        public string grade { get; set; }

        public Doctor(int _hospitalId, string _speciality, string _grade) {
            hospitalId = _hospitalId;
            speciality = _speciality;
            grade = _grade;
        }
    }
}

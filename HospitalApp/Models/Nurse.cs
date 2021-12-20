namespace HospitalApp.Models
{
    public class Nurse: Person
    {
        public int hospitalId { get; set; }

        public int wardNumber { get; set; }

        public Nurse(int _hospitalId, int _wardNumber)
        {
            hospitalId = _hospitalId;
            wardNumber = _wardNumber;
        }
    }
}

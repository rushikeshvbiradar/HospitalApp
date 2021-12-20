using HospitalApp.Interfaces;

namespace HospitalApp.Models
{
    public class Hospital : IAddress
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string street { get => street; set => street = value; }
        public string city { get => city; set => city = value; }
        public int pincode { get => pincode; set => pincode = value; }

        public Hospital(string _name) {
            id = Guid.NewGuid();
            name = _name;
        }
    }
}

using HospitalApp.Interfaces;

namespace HospitalApp.Models
{
    public class Person : IPerson, IAddress
    {
        public Guid id { get; set; }
        public string firstName { get => firstName; set => firstName = value; }
        public string lastName { get => lastName; set => lastName = value; }
        public int age { get => age; set => age = value; }
        public string street { get => street; set => street = value; }
        public string city { get => city; set => city = value; }
        public int pincode { get => pincode; set => pincode = value; }

        public Person() {
            id = Guid.NewGuid();
        }
    }
}

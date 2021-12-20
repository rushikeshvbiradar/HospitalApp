namespace HospitalApp.Interfaces
{
    public interface IAddress
    {
        string street { get; set; }

        string city { get; set; }
        
        int pincode { get; set; }
    }
}

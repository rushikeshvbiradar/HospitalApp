namespace HospitalApp.Models
{
    public class Hospital: BaseModel
    {
        public string? Name { get; set; }

        public Hospital() {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}

namespace HospitalApp.Models
{
    public class Person: BaseModel
    {
        public string? Name { get; set; }
        public int age { get; set; }

        public Person() {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}

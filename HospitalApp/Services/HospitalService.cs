using HospitalApp.Interfaces;
using HospitalApp.Models;

namespace HospitalApp.Services
{
    public class HospitalService : IServices<Hospital>
    {
        private List<Hospital> hospitals { get; set; }

        public HospitalService() {
            hospitals = new List<Hospital>();
        }

        public void Add(Hospital obj)
        {
            hospitals.Add(obj);
        }

        public void Delete(Guid id)
        {
            int i = hospitals.FindIndex(h => h.id == id);
            if (i > -1) {
                hospitals.RemoveAt(i);
            }
        }

        public void Edit(Hospital obj)
        {
            Hospital existingObject = Get(obj.id);
            if (existingObject != null)
            {
                // update
                existingObject = obj;
            }
            else {
                Add(obj);
            }
        }

        public Hospital? Get(Guid id)
        {
            return hospitals.FirstOrDefault(h => h.id == id);
        }

        public List<Hospital> GetAll() {
            return hospitals;
        }
    }
}

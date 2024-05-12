using Test.DAL.Entities.Base;

namespace Test.DAL.Entities
{
    public class Invasion : BaseEntity
    {
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
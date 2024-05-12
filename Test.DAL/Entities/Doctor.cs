using Test.DAL.Entities.Base;

namespace Test.DAL.Entities
{
    public class Doctor : Person
    {
        public ICollection<Invasion> Invasions { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
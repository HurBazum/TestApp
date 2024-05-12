using Test.DAL.Entities.Base;

namespace Test.DAL.Entities
{
    public class Patient : Person
    {
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Invasion> Invasions { get; set; }
    }
}
using Test.Interfaces;

namespace Test.DAL.Entities.Base
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
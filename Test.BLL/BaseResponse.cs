using Test.Interfaces;

namespace Test.BLL
{
    public class BaseResponse<TEntity> : IResponse<TEntity> where TEntity : class, IEntity, new()
    {
        public string Message { get; set; }
        public ICollection<TEntity> Results { get; set; }
    }
}

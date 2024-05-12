namespace Test.Interfaces
{
    public interface IEntityService<T> where T : class, IEntity, new()
    {
        public Task<IResponse<T>> GetAll();
        public Task<IResponse<T>> GetById(int id);
        public Task<IResponse<T>> Delete(int id);
        public Task<IResponse<T>> Update(T entity);
        public Task<IResponse<T>> Add(T entity);
    }
}
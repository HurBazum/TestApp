namespace Test.Interfaces
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        public Task<ICollection<T>> GetAll();
        public Task<T> GetById(int id);
        public Task Delete(int id);
        public Task Update(T entity);
        public Task Add(T entity);
    }
}
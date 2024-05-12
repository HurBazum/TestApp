namespace Test.Interfaces
{
    public interface IResponse<TEntity>
    {
        public string Message { get; set; }
        public ICollection<TEntity> Results { get; set; }
    }
}
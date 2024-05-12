using Microsoft.EntityFrameworkCore;
using Test.Interfaces;

namespace Test.DAL.Repositories.Base
{
    public class Repository<T>(TestContext context) : IRepository<T> where T : class, IEntity, new()
    {
        readonly TestContext _context = context;
        public async Task Add(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetById(int id) => await _context.Set<T>().AsNoTracking().Where(e => e.Id == id).FirstOrDefaultAsync().ConfigureAwait(false);

        public async Task Update(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

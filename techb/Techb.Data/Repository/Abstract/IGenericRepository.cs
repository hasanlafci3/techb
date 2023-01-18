using System.Linq.Expressions;

namespace Techb.Data.Repository.Abstract
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task<Entity> GetByIdAsync(int entityId);
        Task InsertAsync(Entity entity);
        void RemoveAsync(Entity entity);
        void Update(Entity entity);
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<IEnumerable<Entity>> FindAsync(Expression<Func<Entity, bool>> expression);
        IEnumerable<Entity> Where(System.Linq.Expressions.Expression<Func<Entity, bool>> where);
    }
}

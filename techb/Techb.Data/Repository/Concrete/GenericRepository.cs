﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Techb.Data.Context;
using Techb.Data.Repository.Abstract;

namespace Techb.Data.Repository.Concrete
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        protected readonly AppDbContext Context;
        private DbSet<Entity> entities;

        public GenericRepository(AppDbContext dbContext)
        {
            this.Context = dbContext;
            this.entities = Context.Set<Entity>();
        }


        public async Task<IEnumerable<Entity>> FindAsync(Expression<Func<Entity, bool>> expression)
        {
            return await entities.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await entities.AsNoTracking().ToListAsync();
        }

        public virtual async Task<Entity> GetByIdAsync(int entityId)
        {
            //return await entities.FindAsync(entityId);
            return await entities.Where(entity => EF.Property<int>(entity, "Id").Equals(entityId)).SingleOrDefaultAsync();
        }

        public async Task InsertAsync(Entity entity)
        {
            await entities.AddAsync(entity);
        }

        public void RemoveAsync(Entity entity)
        {
            entities.Remove(entity);
            //entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
        }

        public virtual IEnumerable<Entity> Where(System.Linq.Expressions.Expression<Func<Entity, bool>> where)
        {
            return entities.Where(where).AsQueryable();
        }

        public void Update(Entity entity)
        {
            entities.Update(entity);
        }
    }
}

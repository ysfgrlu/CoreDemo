using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KarateOrganization.Core
{
    public class EfBaseEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IBaseEntity, new() where TContext : DbContext, new()
    {
        public DbContext context;
        public EfBaseEntityRepositoryBase()
        {
             context = new TContext();
        }
        public void Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            //TODO  - Change "CreatedUserId" after user credentials added.
            entity.CreatedUserId = 1;
            entity.ModifiedUserId = null;
            entity.IsActive = true;
            entity.ModifiedDate = null;
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
        }

        public void Delete(TEntity entity)
        {
            entity.IsActive = false;
            entity.ModifiedDate = DateTime.Now;
            //TODO  - Change "ModifiedUserId" after user credentials added.
            entity.ModifiedUserId = 1;
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Modified;
            deletedEntity.Property(x => x.CreatedUserId).IsModified = false;
            deletedEntity.Property(x => x.CreatedDate).IsModified = false;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
                return context.Set<TEntity>().Where(x=>x.IsActive).SingleOrDefault(filter);
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
                return filter == null ? context.Set<TEntity>().Where(x=>x.IsActive) // if don't has a filter return all data
                    : context.Set<TEntity>().Where(x => x.IsActive).Where(filter); // else return data for filter
        }

        public bool SaveAll()
        {
                return context.SaveChanges() > 0;
        }

        public void Update(TEntity entity)
        {

            entity.ModifiedDate = DateTime.Now;
            //TODO  - Change "ModifiedUserId" after user credentials added.
            entity.ModifiedUserId = 1;
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            updatedEntity.Property(x => x.CreatedDate).IsModified = false;
            updatedEntity.Property(x => x.CreatedUserId).IsModified = false;
            updatedEntity.Property(x => x.IsActive).IsModified = false;
        }
        }
}
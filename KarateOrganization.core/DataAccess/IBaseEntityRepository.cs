using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace KarateOrganization.Core
{
    public interface IBaseEntityRepository<T> where T : class, IBaseEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveAll();
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETradeApp.DataAccess.Abstract;
using ETradeApp.Entities.Abstract;

namespace ETradeApp.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void AddProduct(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedentity = context.Entry(entity);
                addedentity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedentity = context.Entry(entity);
                deletedentity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> ListEntities(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void UpdateProduct(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedentity = context.Entry(entity);
                updatedentity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

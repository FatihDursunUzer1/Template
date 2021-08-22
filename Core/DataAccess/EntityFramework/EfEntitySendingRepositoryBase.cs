using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntitySendingRepositoryBase<TEntity, TContext> : IEntitySendingRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(int id)
        {
           
            //throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Set<TEntity>().Add(entity);
                context.SaveChanges();
                return addedEntity.Entity;
              }
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var deletedEntity = context.Set<TEntity>().Remove(entity);
                context.SaveChangesAsync();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var updatedData = context.Set<TEntity>().Update(entity);
                context.SaveChangesAsync();
            }
        }

        public void Update(int id)
        {
            //throw new NotImplementedException();
        }
    }
}

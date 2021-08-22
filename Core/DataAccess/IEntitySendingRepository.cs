using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Add,Update gibi methodların olacağı yer.
    public interface IEntitySendingRepository<T> where T : class, IEntity, new()
    {
        public void Add(int id);
        public T Add(T entity);
        public void Update(T entity);
        public void Update(int id);
        public void Delete(int id);
        public void Delete(T entity);
    }
}

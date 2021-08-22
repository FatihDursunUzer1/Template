using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Get methodlarının olacağı yer
    public interface IEntityFetchRepository<T> where T:class,IEntity,new()
    {
        public List<T> getAll();
        public T getById(int id);

    }
}

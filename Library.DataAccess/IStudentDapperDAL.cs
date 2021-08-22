using Core.DataAccess;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
   public interface IStudentDapperDAL:IEntityFetchRepository<Student>
    {
    }
}

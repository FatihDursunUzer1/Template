using Core.DataAccess;
using Core.DataAccess.Dapper;
using Core.DataAccess.EntityFramework;
using Dapper;
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.EntitiesDal
{
    public class StudentDAL : EfEntitySendingRepositoryBase<Student, LibraryContext>, IStudentDAL
    {
       
    }
}

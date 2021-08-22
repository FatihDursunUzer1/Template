using Core.DataAccess.Dapper;
using Library.Entities.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.EntitiesDal
{
    public class StudentDapperDAL : DapperEntityFetchRepositoryBase<Student>,IStudentDapperDAL
    {
        
       public StudentDapperDAL(IConfiguration configuration):base(configuration)
        {
           
        }
       
    }
}

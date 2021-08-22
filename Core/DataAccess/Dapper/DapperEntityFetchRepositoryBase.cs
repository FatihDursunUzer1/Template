using Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Core.DataAccess.Dapper
{
    public class DapperEntityFetchRepositoryBase<T> : IEntityFetchRepository<T> where T : class, IEntity, new()
    {
        private readonly IConfiguration _configuration;

        public DapperEntityFetchRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /*public DapperEntityFetchRepositoryBase()
        {

        } */
        public List<T> getAll()
        {
            using (var dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var className = "";
              if(typeof(T).Name=="Student")

                {
                    className = "ogrenci";
                }
                var sql = "Select * from "+className;
                dbConnection.Open();
                var students = dbConnection.Query<T>(sql);
                return students.ToList();
            }
        }

        public T getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

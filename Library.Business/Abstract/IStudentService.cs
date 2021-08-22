using Library.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IStudentService
    {
        public StudentDTO getById();
        public List<StudentDTO> getAll();
        public StudentDTO addStudent(StudentDTO student);
    }
}

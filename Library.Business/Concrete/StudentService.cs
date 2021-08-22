using AutoMapper;
using Library.Business.Abstract;
using Library.Business.DTOs;
using Library.DataAccess;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentDAL _studentDAL;
        private readonly IStudentDapperDAL _studentDapperDAL;
        public StudentService(IStudentDAL studentDAL, IStudentDapperDAL studentDapperDAL,IMapper mapper)
        {
            _studentDAL = studentDAL;
            _studentDapperDAL = studentDapperDAL;
            _mapper = mapper;

        }

        public StudentDTO addStudent(StudentDTO studentDTO)
        {
            throw new NotImplementedException();
        }

        public List<StudentDTO> getAll()
        {
            List<Student> students = _studentDapperDAL.getAll();
            var studentDtoList = _mapper.Map<List<Student>, List<StudentDTO>>(students);

            return studentDtoList;
        }

        public StudentDTO getById()
        {
            throw new NotImplementedException();
        }
    }
}

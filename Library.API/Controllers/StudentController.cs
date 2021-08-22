using Library.Business.Abstract;
using Library.Business.DTOs;
using Library.DataAccess;
using Library.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost]
        public StudentDTO Add(StudentDTO student)
        {
            var addedStudent=_studentService.addStudent(student);
            return addedStudent;
        }
        [HttpGet]
        public List<StudentDTO> getAll()
        {
            var students = _studentService.getAll();
            return students;
        }
    }
}

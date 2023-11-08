using StudentProjectAPI.ClientModels.Students;
using StudentProjectAPI.Exceptions;
using StudentProjectAPI.Interfaces.Services;
using StudentProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace StudentProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentService.GetStudents(out var totalCount);

            var responseModel = new ResponseModel<Student>
            {
                Data = students,
                TotalCount = totalCount
            };

            return Ok(responseModel);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var student = _studentService.GetStudentById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Add([FromBody] StudentRequestModel requestModel)
        {
            var student = new Student
            {
                Id = requestModel.Id,
                Name = requestModel.Name,
                Group = requestModel.Group,
                Institute = requestModel.Institute,
                Department = requestModel.Department
            };

            try
            {
                var storedStudent = _studentService.AddStudent(student);

                return Ok(storedStudent);
            }
            catch (BadOperationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] StudentRequestModel requestModel)
        {
            // Implementation
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // Implementation
            return Ok();
        }
    }
}
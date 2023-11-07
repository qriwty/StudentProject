using System.Collections.Generic;
using StudentProjectAPI.Interfaces.Repositories;
using StudentProjectAPI.Interfaces.Services;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public List<Student> GetStudents(out int totalCount)
        {
            totalCount = _studentRepository.GetStudentsTotalCount();

            return _studentRepository.GetStudents();
        }

        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
    }
}

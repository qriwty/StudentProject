using System.Collections.Generic;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Interfaces.Services
{
    public interface IStudentService
    {
        Student GetStudentById(int id);

        List<Student> GetStudents(out int totalCount);

        Student AddStudent(Student student);
    }
}

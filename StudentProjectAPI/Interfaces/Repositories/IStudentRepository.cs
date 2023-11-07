using System.Collections.Generic;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();

        int GetStudentsTotalCount();

        Student GetStudentById(int id);

        Student AddStudent(Student student);
    }
}

using System.Collections.Generic;
using StudentProjectAPI.Interfaces.Services;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Services
{
    public class FakeStudentService : IStudentService
    {
        public Student AddStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetStudents(out int totalCount)
        {
            totalCount = 1;

            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Fake Person",
                    Group = "UP-201",
                    Institute = "AIR",
                    Department = "AI"
                }
            };
        }
    }
}

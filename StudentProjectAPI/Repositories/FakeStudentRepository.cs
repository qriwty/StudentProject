using System.Collections.Generic;
using System.Linq;
using StudentProjectAPI.Interfaces.Repositories;
using StudentProjectAPI.Models;


namespace StudentProjectAPI.Repositories
{
    public class FakeStudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Fake Person 1",
                Group = "UP-201",
                Institute = "AIR",
                Department = "AI"
            },
            new Student
            {
                Id = 2,
                Name = "Fake Person 2",
                Group = "UP-202",
                Institute = "AIR",
                Department = "AI"
            },
            new Student
            {
                Id = 3,
                Name = "Fake Person 3",
                Group = "UP-203",
                Institute = "AIR",
                Department = "AI"
            },
            new Student
            {
                Id = 4,
                Name = "Fake Person 4",
                Group = "UP-204",
                Institute = "AIR",
                Department = "AI"
            }
        };

        public Student AddStudent(Student student)
        {
            student.Id = _students.Count + 1;

            _students.Add(student);

            return student;
        }

        public Student GetStudentById(int id)
        {
            return _students.SingleOrDefault(student => student.Id == id);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public int GetStudentsTotalCount()
        {
            return _students.Count;
        }
    }
}

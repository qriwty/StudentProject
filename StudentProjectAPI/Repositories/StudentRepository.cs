using System.Collections.Generic;
using System.Linq;
using StudentProjectAPI.Database;
using StudentProjectAPI.Interfaces.Repositories;
using StudentProjectAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace StudentProjectAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbSet<Student> _dbSet;
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Students;
        }

        public Student AddStudent(Student student)
        {
            _dbSet.Add(student);
            _dbContext.SaveChanges();

            return student;
        }

        public Student GetStudentById(int id)
        {
            return _dbSet.SingleOrDefault(student => student.Id == id);
            /*
             * SELECT * FROM [Students]
             * WHERE [Id] = @id;
             */
        }

        public List<Student> GetStudents()
        {
            return _dbSet.ToList();
            /*
            * SELECT * FROM [Students];
            */
        }

        public int GetStudentsTotalCount()
        {
            return _dbSet.Count();
            /*
            * SELECT COUNT(1) FROM [Students];
            */
        }
    }
}

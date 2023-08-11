using CQRS_And_MediatR_implementation.Data;
using CQRS_And_MediatR_implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_And_MediatR_implementation.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var result = _context.Students.Add(studentDetails);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var filteredData = _context.Students.Where(x => x.Id == Id).FirstOrDefault();
            _context.Students.Remove(filteredData);
            return await _context.SaveChangesAsync();
        }

        public async Task<StudentDetails> GetStudentByIdAsync(int Id)
        {
            return await _context.Students.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            _context.Students.Update(studentDetails);
            return await _context.SaveChangesAsync();
        }
    }
}

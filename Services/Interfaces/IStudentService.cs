using Student_Management_System.DTOs.Student;

namespace StudentManagementSystem.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllAsync();
        Task<StudentDto> GetByIdAsync(int id);
        Task<StudentDto> CreateAsync(CreateStudentDto dto);
        Task<StudentDto> UpdateAsync(int id, UpdateStudentDto dto);
        Task DeleteAsync(int id);
    }
}
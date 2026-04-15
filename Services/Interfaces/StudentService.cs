using AutoMapper;
using Student_Management_System.DTOs.Student;
using Student_Management_System.Models;
using StudentManagementSystem.Repositories.Interfaces;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            var students = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public async Task<StudentDto> GetByIdAsync(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            if (student is null)
                throw new KeyNotFoundException($"Student with Id {id} not found.");

            return _mapper.Map<StudentDto>(student);
        }

        public async Task<StudentDto> CreateAsync(CreateStudentDto dto)
        {
            var existingStudent = await _repository.GetByEmailAsync(dto.Email);
            if (existingStudent is not null)
                throw new ApplicationException("A student with this email already exists.");

            var student = _mapper.Map<Student>(dto);
            student.CreatedDate = DateTime.UtcNow;

            await _repository.AddAsync(student);
            await _repository.SaveChangesAsync();

            return _mapper.Map<StudentDto>(student);
        }

        public async Task<StudentDto> UpdateAsync(int id, UpdateStudentDto dto)
        {
            var student = await _repository.GetByIdAsync(id);
            if (student is null)
                throw new KeyNotFoundException($"Student with Id {id} not found.");

            var existingByEmail = await _repository.GetByEmailAsync(dto.Email);
            if (existingByEmail is not null && existingByEmail.Id != id)
                throw new ApplicationException("Another student with this email already exists.");

            student.Name = dto.Name;
            student.Email = dto.Email;
            student.Age = dto.Age;
            student.Course = dto.Course;

            _repository.Update(student);
            await _repository.SaveChangesAsync();

            return _mapper.Map<StudentDto>(student);
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _repository.GetByIdAsync(id);
            if (student is null)
                throw new KeyNotFoundException($"Student with Id {id} not found.");

            _repository.Delete(student);
            await _repository.SaveChangesAsync();
        }
    }
}
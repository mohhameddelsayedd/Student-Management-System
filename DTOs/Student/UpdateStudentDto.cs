using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.DTOs.Student
{
    public class UpdateStudentDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        [Range(1, 100)]
        public int Age { get; set; }

        [Required, MaxLength(100)]
        public string Course { get; set; } = string.Empty;
    }
}

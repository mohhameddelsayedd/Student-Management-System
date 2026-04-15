using Student_Management_System.Models;

namespace StudentManagementSystem.Services.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(ApplicationUser user, IList<string> roles);
    }
}
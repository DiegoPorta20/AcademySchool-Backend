using AcademySchool.Security.Domain.Models;

namespace AcademySchool.Security.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    string GenerateToken(User user);
    int? ValidateToken(string token);
}
using AcademySchool.Security.Domain.Models;
using AcademySchool.Security.Domain.Services.Communication;

namespace AcademySchool.Security.Domain.Services;

public interface IUserService
{
    Task<AuthenticateResponse> Authenticate(AuthenticateRequest request);
    Task<IEnumerable<User>> ListAsync();
    Task<User> GetByIdAsync(int id);

    Task<User> GetByEmailAsync(string email);
    Task RegisterAsync(RegisterRequest request);
    Task<User> UpdateAsync(int id, UpdateRequest request, byte[] file, string contentType,string extension, string container);
    Task DeleteAsync(int id);
}
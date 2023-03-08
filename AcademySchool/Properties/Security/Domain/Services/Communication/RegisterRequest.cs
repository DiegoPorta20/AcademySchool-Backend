using System.ComponentModel.DataAnnotations;

namespace AcademySchool.Security.Domain.Services.Communication;

public class RegisterRequest
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Image { get; set; }
    [Required]
    public string Phone { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}
namespace AcademySchool.Security.Domain.Services.Communication;

public class UpdateRequest
{
    public string Username { get; set; }
    public IFormFile Image { get; set; }
    public string Phone { get; set; }
}
namespace AcademySchool.Security.Domain.Services.Communication;

public class AuthenticateResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public string Phone { get; set; }
    public string Token { get; set; }
}
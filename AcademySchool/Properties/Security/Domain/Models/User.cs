using System.Text.Json.Serialization;

namespace AcademySchool.Security.Domain.Models;

public class User
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public string Phone { get; set; }


    [JsonIgnore]
    public string PasswordHash { get; set; }
    //public IList<Order> Orders { get; set; } = new List<Order>();
}
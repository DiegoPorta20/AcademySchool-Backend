using AcademySchool.Security.Domain.Models;
using AcademySchool.Security.Domain.Services.Communication;
using AcademySchool.Security.Resources;

namespace AcademySchool.Security.Mapping;

public class ModelToResourceProfile : AutoMapper.Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<User, AuthenticateResponse>();
        CreateMap<User, UserResource>();
        CreateMap<User, UpdateRequest>();
    }
}
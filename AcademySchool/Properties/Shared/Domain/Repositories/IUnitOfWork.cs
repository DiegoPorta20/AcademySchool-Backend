namespace AcademySchool.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}
using AcademySchool.Shared.Domain.Repositories;
using AcademySchool.Shared.Persistence.Contexts;

namespace AcademySchool.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }


    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}
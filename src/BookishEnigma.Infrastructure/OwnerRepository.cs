using BookishEnigma.Core.Contracts;
using BookishEnigma.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookishEnigma.Infrastructure;

public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
{
    public OwnerRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<Owner>> GetAllOwnersAsync()
    {
        return await FindAll()
           .OrderBy(ow => ow.Name)
           .ToListAsync();
    }
    public async Task<Owner> GetOwnerByIdAsync(Guid ownerId)
    {
        return await FindByCondition(owner => owner.Id.Equals(ownerId))
            .FirstOrDefaultAsync();
    }
    public async Task<Owner> GetOwnerWithDetailsAsync(Guid ownerId)
    {
        return await FindByCondition(owner => owner.Id.Equals(ownerId))
            .Include(ac => ac.Accounts)
            .FirstOrDefaultAsync();
    }

    public void CreateOwner(Owner owner)
    {
        Create(owner);
    }

    public void UpdateOwner(Owner owner)
    {
        Update(owner);
    }

    public void DeleteOwner(Owner owner)
    {
        Delete(owner);
    }
}
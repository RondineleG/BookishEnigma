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

    public IEnumerable<Owner> GetAllOwners()
    {
        return FindAll()
            .OrderBy(ow => ow.Name)
            .ToList();
    }

    public Owner GetOwnerById(Guid ownerId)
    {
        return FindByCondition(owner => owner.Id.Equals(ownerId))
                .FirstOrDefault();
    }

    public Owner GetOwnerWithDetails(Guid ownerId)
    {
        return FindByCondition(owner => owner.Id.Equals(ownerId))
            .Include(ac => ac.Accounts)
            .FirstOrDefault();
    }
}
using BookishEnigma.Core.Entities;

namespace BookishEnigma.Core.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAllOwners();
    Owner GetOwnerById(Guid ownerId);
}

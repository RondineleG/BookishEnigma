using BookishEnigma.Core.Entities;

namespace BookishEnigma.Core.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAllOwners();
    Owner GetOwnerById(Guid ownerId);

    Owner GetOwnerWithDetails(Guid ownerId);

    void CreateOwner(Owner owner);

    void UpdateOwner(Owner owner);

    void DeleteOwner(Owner owner);

}

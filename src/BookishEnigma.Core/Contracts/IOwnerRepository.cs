using BookishEnigma.Core.Entities;

namespace BookishEnigma.Core.Contracts;

public interface IOwnerRepository
{
    Task<IEnumerable<Owner>> GetAllOwnersAsync();
    Task<Owner> GetOwnerByIdAsync(Guid ownerId);
    Task<Owner> GetOwnerWithDetailsAsync(Guid ownerId);
    void CreateOwner(Owner owner);

    void UpdateOwner(Owner owner);

    void DeleteOwner(Owner owner);

}

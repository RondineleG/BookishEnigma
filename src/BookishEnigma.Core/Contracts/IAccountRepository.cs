using BookishEnigma.Core.Entities;

namespace BookishEnigma.Core.Contracts;

public interface IAccountRepository
{

    IEnumerable<Account> AccountsByOwner(Guid ownerId);

}

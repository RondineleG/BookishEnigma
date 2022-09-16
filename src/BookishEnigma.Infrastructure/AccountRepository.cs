using BookishEnigma.Core.Contracts;
using BookishEnigma.Core.Entities;

namespace BookishEnigma.Infrastructure;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public IEnumerable<Account> AccountsByOwner(Guid ownerId)
    {
        return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
    }
}
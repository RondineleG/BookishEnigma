using BookishEnigma.Core.Contracts;
using BookishEnigma.Core.Entities;

namespace BookishEnigma.Infrastructure;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}
using BookishEnigma.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookishEnigma.Infrastructure;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options) { }

    public DbSet<Owner>? Owners { get; set; }
    public DbSet<Account>? Accounts { get; set; }
}

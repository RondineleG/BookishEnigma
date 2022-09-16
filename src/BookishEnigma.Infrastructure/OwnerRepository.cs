﻿using BookishEnigma.Core.Contracts;
using BookishEnigma.Core.Entities;

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
}
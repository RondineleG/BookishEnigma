using AutoMapper;
using BookishEnigma.Core.Dtos;
using BookishEnigma.Core.Entities;

namespace BookishEnigma.Api.Mapping;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDto>();

        CreateMap<Account, AccountDto>();
    }
}

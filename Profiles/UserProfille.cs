using AutoMapper;
using UsersApi.Data.Dtos;
using UsersApi.Models;

namespace UsersApi.Profiles;

public class UserProfille : Profile
{
    public UserProfille()
    {
        CreateMap<CreateUserDto, User>();
    }
}

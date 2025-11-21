using Microsoft.AspNetCore.Identity;

namespace UsersApi.Models;

public class User : IdentityUser
{
    public DateTime DateOfBirth { get; set; }
    public User() : base() { }
}

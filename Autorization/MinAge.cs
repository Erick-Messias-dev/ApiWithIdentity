using Microsoft.AspNetCore.Authorization;

namespace UsersApi.Autorization;

public class MinAge : IAuthorizationRequirement
{
    public MinAge(int age)
    {
        Age = age;
    }

    public int Age { get; set; }
}

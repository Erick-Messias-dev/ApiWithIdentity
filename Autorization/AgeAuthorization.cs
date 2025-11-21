using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsersApi.Autorization;

public class AgeAuthorization : AuthorizationHandler<MinAge>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinAge requirement)
    {
        var dateOfBirthClaim = context.User.FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);

        if (dateOfBirthClaim is null)
        {
            return Task.CompletedTask;
        }

        var dateOfBirth = Convert.ToDateTime(dateOfBirthClaim.Value);

        var ageUser = DateTime.Today.Year - dateOfBirth.Year;

        if (dateOfBirth > DateTime.Today.AddYears(-ageUser))
            ageUser--;

        if (ageUser >= requirement.Age) context.Succeed(requirement);

        return Task.CompletedTask;
    }
}

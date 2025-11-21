
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Data.Dtos;

namespace UsersApi.Controllers;

[ApiController]
[Route("[]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastrarUsuario(CreateUserDto dto)
    {
        throw new NotImplementedException();
    }
}

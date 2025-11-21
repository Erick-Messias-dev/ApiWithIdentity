
using AutoMapper;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsersApi.Data.Dtos;
using UsersApi.Models;

namespace UsersApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IMapper _mapper;
    private UserManager<User> _userMenager;

    public UserController(IMapper mapper, UserManager<User> userMenager)
    {
        _mapper = mapper;
        _userMenager = userMenager;
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarUsuario(CreateUserDto dto)
    {
        User user = _mapper.Map<User>(dto);

        IdentityResult result = await _userMenager.CreateAsync(user, dto.Password);

        if (result.Succeeded) return Ok("Usuário cadastrado");

        throw new ApplicationException("Falha ao cadastrar usuario!");
    }
}

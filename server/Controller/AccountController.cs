using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using server.DTOs;
using server.Entity;
using server.Service;

namespace server.Controller
{
    public class AccountController(UserManager<User> userManager, TokenService token) : BaseController
    {

        [HttpPost("LoginUser")]
        public async Task<ActionResult<User>> Login(LoginDto loginDto)
        {
            var user = await userManager.FindByNameAsync(loginDto.UserName);
            var userPassword = await userManager.CheckPasswordAsync(user, loginDto.Password);
            if (user == null || !userPassword) return Unauthorized(new ProblemDetails { Title = "Either email or password is invalid. Please try again." });
            return Ok(new UserDto
            {
                Email = user.Email,
                UserName = user.UserName,
                Token = await token.CreateToken(user),
            });
        }

        [HttpPost("RegisterUser")]
        public async Task<ActionResult<UserDto>> Login(RegisterDto registerDto)
        {
            var newUser = new User
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
            };
            var result = await userManager.CreateAsync(newUser, registerDto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return ValidationProblem();
            }
            await userManager.AddToRoleAsync(newUser, "Member");
            return Ok("User registered successfully. Please Login.");
        }

        [Authorize]
        [HttpGet("GetUser")]
        public async Task<ActionResult<UserDto>> GetUser()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return ValidationProblem();
            var userToken = await token.CreateToken(user);
            return Ok(new UserDto
            {
                Email = user.Email,
                UserName = user.UserName,
                Token = userToken,
            });
        }
    }
}
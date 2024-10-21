using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.DTOs;
using server.Entity;
using server.Extensions;
using server.Service;

namespace server.Controller
{
    public class AccountController(UserManager<User> userManager, TokenService token, StoreContext _context) : BaseController
    {

        [HttpPost("LoginUser")]
        public async Task<ActionResult<User>> Login(LoginDto loginDto)
        {
            var user = await userManager.FindByNameAsync(loginDto.UserName);
            var userPassword = await userManager.CheckPasswordAsync(user, loginDto.Password);
            if (user == null || !userPassword) return Unauthorized(new ProblemDetails { Title = "Either email or password is invalid. Please try again." });

            var userCart = await RetrieveCart(loginDto.UserName);
            var anonCart = await RetrieveCart(Request.Cookies["buyerId"]);
            if (anonCart != null)
            {
                if (userCart != null) _context.Carts.Remove(userCart);
                anonCart.BuyerId = user.UserName;
                Response.Cookies.Delete("buyerId");
                await _context.SaveChangesAsync();
            }
            return Ok(new UserDto
            {
                Email = user.Email,
                UserName = user.UserName,
                Token = await token.CreateToken(user),
                Cart = anonCart != null ? anonCart.MapCartToDto() : userCart?.MapCartToDto()
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
            var cart = await RetrieveCart(User.Identity.Name);
            return Ok(new UserDto
            {
                Email = user.Email,
                UserName = user.UserName,
                Token = userToken,
                Cart = cart.MapCartToDto()
            });
        }
        private async Task<Cart> RetrieveCart(string buyerId)
        {
            if (string.IsNullOrEmpty(buyerId))
            {
                Response.Cookies.Delete("buyerId");
                return null;
            }
            return await _context.Carts.Include(i => i.Items).ThenInclude(p => p.Product).FirstOrDefaultAsync(b => b.BuyerId == buyerId);
        }
    }
}
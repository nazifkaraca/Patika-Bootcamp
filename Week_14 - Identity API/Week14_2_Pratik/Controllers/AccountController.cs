using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Week14_2_Pratik.ViewModel;

namespace Week14_2_Pratik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Account create end-point
        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount(CreateAccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { 
                    errors = ModelState.Values
                                       .SelectMany(a => a.Errors)
                                       .Select(e => e.ErrorMessage) 
                });
            }

            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(new { message = "Account created." });
            }

            return BadRequest(result.Errors.Select(a => a.Description));
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    errors = ModelState.Values
                                       .SelectMany(a => a.Errors)
                                       .Select(e => e.ErrorMessage)
                });
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (result.Succeeded)
            {
                return Ok(new { message = "Login successful." });
            }
            else
            {
                return Unauthorized(new { message = "Email or password wrong." });
            }
        }

        // Get users
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userManager.Users.Select(a => new 
            {   a.Id, 
                a.UserName, 
                a.Email, 
                a.PhoneNumber 
            })
                .ToListAsync();
                
            return Ok(users);
        }
    }
}

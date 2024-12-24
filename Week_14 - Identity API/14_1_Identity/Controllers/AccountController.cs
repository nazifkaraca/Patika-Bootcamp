using _14_1_Identity.Model;
using _14_1_Identity.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _14_1_Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager; // Sign In and Register operations
        private readonly RoleManager<IdentityRole> _roleManager; // Role configuration

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        // Sign Up
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
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

                return BadRequest(new { errors = result.Errors.Select(e => e.Description) });
            }

            return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
        }


        // Sign In
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return Ok(new { message = "Login successful." });
                }
                else
                {
                    return Unauthorized(new { message = "Email or password wrong." });
                }
            }

            return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
        }


        // Role configuration
        [HttpPost("createrole")]
        public async Task<IActionResult> CreateRole([FromBody] string roleName)
        {
            if (!string.IsNullOrWhiteSpace(roleName))
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(roleName));

                if (result.Succeeded)
                {
                    return Ok(new { message = "Role successfully created." });
                }
                else
                {
                    return BadRequest(new { errors = result.Errors.Select(e => e.Description) });
                }
            }

            return BadRequest(new { message = "Role name cannot be null." });
        }

        // Get all roles
        [HttpGet("roles")]
        public IActionResult GetRoles()
        {
            var roles = _roleManager.Roles.ToList();

            return Ok(roles);
        }

        // Role assignment to users
        [HttpPost("addtorole")]
        public async Task<IActionResult> AddToRole(AddToRoleModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
                return NotFound(new { message = "User is not found." });

            if (!await _roleManager.RoleExistsAsync(model.RoleName))
                return NotFound(new { message = "Role is not found." });

            var result = await _userManager.AddToRoleAsync(user, model.RoleName);

            if (result.Succeeded) 
            {
                return Ok(new { message = "Role added." });
            }
            else
            {
                return BadRequest(new { errors = result.Errors.Select(e => e.Description) });
            }
        }

        // Get roles of the user
        [HttpGet("userroles/{userId}")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound(new { message = "No such user found." });
            }

            var roles = await _userManager.GetRolesAsync(user);
            
            return Ok(roles);
        }
    }
}

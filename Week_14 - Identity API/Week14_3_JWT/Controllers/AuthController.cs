using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week14_3_JWT.Data.Context;
using Week14_3_JWT.Data.Dto;
using Week14_3_JWT.Data.Entity;


namespace Week14_3_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtContext _jwtContext;
        private readonly IConfiguration _configuration;
        public AuthController(JwtContext jwtContext, IConfiguration configuration)
        {
            _jwtContext = jwtContext;
            _configuration = configuration;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> CreateAccount(SignUpDto newAccount)
        {
            // Check if email already exists
            var existingAccount = await _jwtContext.Users.FirstOrDefaultAsync(a => 
                                                            a.Email == newAccount.Email);

            if (existingAccount != null) return BadRequest(new { message = "E-mail already exists." });

            // Password hashing
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(newAccount.Password);

            // Create a new user
            var account = new User
            {
                Email = newAccount.Email,
                Password = hashedPassword
            };

            // Save async
            await _jwtContext.Users.AddAsync(account);
            await _jwtContext.SaveChangesAsync();

            return Ok(new { email = account.Email, message = "Account has been created." });
        }

        //[Authorize]
        [HttpPost("login")]
        public async Task<IActionResult> Login(SignInDto loginAccount)
        {
            var existingAccount = await _jwtContext.Users.FirstOrDefaultAsync(a =>
                                                            a.Email == loginAccount.Email);

            // Check password correctness and account existance
            if (existingAccount == null || !BCrypt.Net.BCrypt.Verify(loginAccount.Password, existingAccount!.Password))
            {
                return Unauthorized(new { message = "Invalid email or password." }); 
            }

            // Create JWT token
            var token = JwtHelper.GenerateJwtToken(
                eMail: loginAccount.Email,
                key: _configuration["Jwt:Key"],
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                expiryMinutes: 30
                );

            return Ok(new { message = "Login successful.", token = token });
        }
    }
}

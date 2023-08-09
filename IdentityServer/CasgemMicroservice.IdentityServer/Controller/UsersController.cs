using CasgemMicroservice.IdentityServer.Dtos;
using CasgemMicroservice.IdentityServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using System.Linq;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace CasgemMicroservice.IdentityServer.Controller
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SingUp(SignUpDto signupDto)
        {
            var user = new ApplicationUser
            {
                UserName = signupDto.Username,
                Email = signupDto.Email,
                City = signupDto.City,
                NameSurname=signupDto.NameSurname,

            };
            var result = await _userManager.CreateAsync(user, signupDto.Password);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult>GetUser()
        {
            var values = User.Claims.FirstOrDefault(x=>x.Type == JwtRegisteredClaimNames.Sub);
            var user = await _userManager.FindByIdAsync(values.Value);
            return Ok(new
            {
                Id=user.Id,
                Username = user.UserName,
                Email = user.Email,
                City = user.City,
            });
        }
    }
}

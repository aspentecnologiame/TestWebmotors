using MarcosCosta.Api.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MarcosCosta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IConfiguration _config;

        public IdentityController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("GetToken")]
        [AllowAnonymous]
        public IActionResult GetToken()
        {
            var jwtBearerToken = new JwtBearerToken(_config);
            return Ok(jwtBearerToken.GenerateToken());
        }
    }
}

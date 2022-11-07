using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.DTO;
using Services;

namespace WebAPI.Controllers
{
    [Route("api")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly SecurityHelper _securityHelper;
        private readonly IUserService _userService;
        public TokenController(IConfiguration configuration,IUserService userService, SecurityHelper securityHelper)
        {
            _securityHelper = securityHelper;
            _configuration = configuration;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("token")]
        public IActionResult Post([FromBody]LoginDTO loginModel)
        {
            if (ModelState.IsValid)
            {
                Models.User User = _userService.UserLogin(loginModel.UserName, _securityHelper.Md5Encryption(loginModel.Password));
                if (User != null)
                {
                    var claims = new[]
                    {
                        new Claim("RoleId", User.RoleID.ToString()),
                        new Claim("UserId", User.UserID.ToString()),
                        new Claim("CompanyId", "77")
                    };
                    int tokenExpiration;
                    int.TryParse(_configuration["TokenExpiration"], out tokenExpiration);

                    JwtSecurityToken token = new JwtSecurityToken
                    (
                        issuer: _configuration["Issuer"],
                        audience: _configuration["Audience"],
                        claims: claims,
                        expires: DateTime.UtcNow.AddDays(tokenExpiration),
                        notBefore: DateTime.UtcNow,
                        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])),
                             SecurityAlgorithms.HmacSha256)
                    );

                    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

                }
                else
                {
                    return Unauthorized();
                }


            }

            return BadRequest();
        }

    }
}
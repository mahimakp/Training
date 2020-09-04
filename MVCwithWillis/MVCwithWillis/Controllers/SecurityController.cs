using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PatientLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCwithWillis.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SecurityController : ControllerBase
    {
        // GET: api/<SecurityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/<SecurityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SecurityController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel userinfo)
        {
            IActionResult response = Unauthorized();

            //Validate the User Credentials    
             
            if (userinfo.username == "Mahima" && userinfo.password == "Password")
            {
               
                var token = GenerateJSONWebToken(userinfo);
                return Ok(token);
            }

            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized);
            }

        }

        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MahimaMahimaMahima"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim("Issuer", "Mahima"),
                new Claim("Admin", "true"),
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.username)
            };

            var token = new JwtSecurityToken("Mahima",
                "Mahima",
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // PUT api/<SecurityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SecurityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

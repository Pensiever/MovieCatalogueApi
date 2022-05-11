using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalogueApi.Models;
using MovieCatalogueApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieCatalogueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ITokenService _tokenService;

        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("auth")]
        public IActionResult Auth([FromBody] LoginInfo model)
        {
            ConnectedUser user;
            try
            {
                user = _tokenService.Authenticate(model.Email, model.Password);
            }
            catch (Exception e)
            {
                return BadRequest("Email ou password incorrect");
            }


            if (user == null)
            {
                return BadRequest(new { message = "Utilisateur inexistant !" });
            }

            return Ok(user);
        }

    }
}
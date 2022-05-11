using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Model.Models;
using Model.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieCatalogueApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_movieService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize("User")]
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            return Ok(_movieService.GetOne(Id));
        }

        [Authorize("Admin")]
        [HttpPost]
        public IActionResult Post([FromBody] NewMovie m)
        {
            try
            {
                int test = _movieService.Create(m);
                return Ok(test);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [Authorize("Admin")]
        [HttpPut]
        public IActionResult Put([FromBody] NewMovie m)
        {
            try
            {
                _movieService.Update(m);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize("Admin")]
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _movieService.Delete(Id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
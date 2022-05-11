using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using Model.Models;
using Model.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieCatalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService<Comment> _service;
        public CommentController(ICommentService<Comment> service)
        {
            _service = service;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetByMovieId(id));
        }

        [HttpPost]
        public IActionResult Post(Comment c)
        {
            _service.Insert(c);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _service.Delete(Id);
            return Ok();
        }
    }
}
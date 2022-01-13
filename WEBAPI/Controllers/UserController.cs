using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("test")]
        public IActionResult GetAll(User user)
        {
            var result = _userService.GetClaims(user);
            
            return Ok(result);
           
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _userService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var test = _userService.GetById(user.Id);
            user.PasswordHash = test.Data.PasswordHash;
            user.PasswordSalt = test.Data.PasswordSalt;
            user.Status = test.Data.Status;
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

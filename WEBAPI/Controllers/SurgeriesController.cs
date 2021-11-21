using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgeriesController : Controller
    {
        ISurgeriesService _surgeriesService;

        public SurgeriesController(ISurgeriesService surgeriesService)
        {
            _surgeriesService = surgeriesService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _surgeriesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

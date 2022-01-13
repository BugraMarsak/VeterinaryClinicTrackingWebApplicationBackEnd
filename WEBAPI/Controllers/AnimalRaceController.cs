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
    public class AnimalRaceController : Controller
    {
        IAnimalRaceService _animalRaceService;

        public AnimalRaceController(IAnimalRaceService animalRaceService)
        {
            _animalRaceService = animalRaceService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _animalRaceService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

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
    public class AnimalInformationController : Controller
    {
        IAnimalInformationService _animalInformationService;

        public AnimalInformationController(IAnimalInformationService animalInformationService)
        {
            _animalInformationService = animalInformationService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _animalInformationService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetOrdersByUserId(int Id)
        {
            var result = _animalInformationService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }

    
}

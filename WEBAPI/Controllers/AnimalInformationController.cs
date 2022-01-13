using Business.Abstract;
using Entities.Concrete;
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
        public IActionResult GetById(int Id)
        {
            var result = _animalInformationService.GetByAnimalId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetByUserId")]
        public IActionResult GetByUserId(int Id)
        {
            var result = _animalInformationService.GetByUserId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add(AnimalInformation animalInformation)
        {
            var userExists = _animalInformationService.UserExist(animalInformation.AnimalId,animalInformation.AnimalKind);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }
            var result = _animalInformationService.Add(animalInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(AnimalInformation animalInformation)
        {
            var result = _animalInformationService.Delete(animalInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(AnimalInformation animalInformation)
        {
            var result = _animalInformationService.Update(animalInformation);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }

    
}

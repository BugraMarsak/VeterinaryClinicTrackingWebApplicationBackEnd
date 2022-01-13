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
    public class VaccinationCardController : Controller
    {
        IVaccinationCardService _vaccinationCardService;

        public VaccinationCardController(IVaccinationCardService vaccinationCardService)
        {
            _vaccinationCardService = vaccinationCardService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _vaccinationCardService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _vaccinationCardService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByVacId")]
        public IActionResult GetByVacId(int Id)
        {
            var result = _vaccinationCardService.GetByVacId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(VaccinationCard vaccinationCard)
        {
            var result = _vaccinationCardService.Add(vaccinationCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(VaccinationCard vaccinationCard)
        {
            var result = _vaccinationCardService.Delete(vaccinationCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(VaccinationCard vaccinationCard)
        {
            var result = _vaccinationCardService.Update(vaccinationCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

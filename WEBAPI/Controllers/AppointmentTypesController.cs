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
    public class AppointmentTypesController : Controller
    {
        IAppointmentTypesService _appointmentTypesService;

        public AppointmentTypesController(IAppointmentTypesService appointmentTypesService)
        {
            _appointmentTypesService = appointmentTypesService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _appointmentTypesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _appointmentTypesService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

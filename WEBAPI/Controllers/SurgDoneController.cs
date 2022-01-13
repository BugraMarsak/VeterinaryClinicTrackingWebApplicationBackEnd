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
    public class SurgDoneController : Controller
    {
        ISurgDoneService _surgDoneService;

        public SurgDoneController(ISurgDoneService surgDoneService)
        {
            _surgDoneService = surgDoneService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _surgDoneService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add(SurgDone surgDone)
        {
            var result = _surgDoneService.Add(surgDone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SurgDone surgDone)
        {
            var result = _surgDoneService.Delete(surgDone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(SurgDone surgDone)
        {
            var result = _surgDoneService.Update(surgDone);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _surgDoneService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

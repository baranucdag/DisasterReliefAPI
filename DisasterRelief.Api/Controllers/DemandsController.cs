using DisasterRelief.Bussiness.Abstract;
using DisasterRelief.DataAccess.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DisasterRelief.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandsController : ControllerBase
    {
        private readonly IDemandService _demandService;

        public DemandsController(IDemandService demandService)
        {
            _demandService = demandService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _demandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByUserById")]
        public IActionResult GetByUserById(int id)
        {
            var result = _demandService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(Demand demand)
        {
            var result = _demandService.Add(demand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Demand demand)
        {
            var result = _demandService.Update(demand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Demand demand)
        {
            var result = _demandService.Delete(demand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

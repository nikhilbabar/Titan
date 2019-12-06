using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Titan.Model;
using Titan.Service.Datum;

namespace Titan.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatumController : ControllerBase
    {
        private readonly IDatumService _service;
        public DatumController(IDatumService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<DatumModel>> GetAsync(int id)
        {
            var result = await _service.GetAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<DatumModel>>> GetAsync()
        {
            var result = await _service.GetAsync();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
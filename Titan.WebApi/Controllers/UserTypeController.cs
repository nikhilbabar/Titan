using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Titan.Model;
using Titan.Service.Interface;

namespace Titan.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly IUserTypeService _service;
        public UserTypeController(IUserTypeService service)
        {
            _service = service;
        }

        // GET: api/UserType
        [HttpGet]
        public async Task<ActionResult<List<UserTypeModel>>> GetAsync()
        {
            var result = await _service.GetAsync();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/UserType/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<UserTypeModel>> GetAsync(byte id)
        {
            var result = await _service.GetAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/UserType
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UserType/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

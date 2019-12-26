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
    public class UserTypeController : BaseController
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
        
    }
}

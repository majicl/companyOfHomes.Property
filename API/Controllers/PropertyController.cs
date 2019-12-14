using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Properties;
using System.Net;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IMediator _mediator { get; }

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PropertyDto), (int)HttpStatusCode.Created)]
        public async Task<ActionResult> Get(int id)
        {
            var prop = await _mediator.Send(new Details.Query { Id = id });
            return Ok(prop);
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Post([FromBody]Create.Command command)
        {
            return await _mediator.Send(command);
        }
    }
}

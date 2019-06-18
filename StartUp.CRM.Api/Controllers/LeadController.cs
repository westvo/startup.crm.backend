using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartUp.CRM.Model.Entities.Leads;
using StartUp.CRM.UnitOfWork.Collections;
using StartUp.CRM.Service.Shared;
using StartUp.CRM.UnitOfWork.Collections;

namespace StartUp.CRM.Api.Controllers
{
    [Route("api/lead")]
    [ApiController]
    public class LeadController : ControllerBase
    {

        ILeadService _leadService;

        public LeadController(ILeadService leadService)
        {
            _leadService = leadService;
        }

        // GET: api/Lead
        [HttpGet]
        public async Task<IPagedList<Lead>> Get()
        {
            var leads = await _leadService.GetAll();
            return leads;
        }

        // GET: api/Lead/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lead
        [HttpPost]
        public Lead Post([FromBody] Lead lead)
        {
            var l = _leadService.Create(lead);
            return l;
        }

        // PUT: api/Lead/5
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

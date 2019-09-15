using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VcareNow.EntityLayer.Data;

namespace VcareNowService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private DataContext _dataContext { get; }

        public PatientController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/Patient
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _dataContext.Values.ToListAsync();
            return Ok(values);
        }

        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetValues(int id)
        {
            var value = await _dataContext.Values.FirstOrDefaultAsync(x=> x.Id == id);
            return Ok(value);
        }

        // POST: api/Patient
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Patient/5
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

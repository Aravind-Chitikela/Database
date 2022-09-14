using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EFDemo.Repositories;
using EFDemo.Models;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        IVisitorRepository visitorRepository;
        public VisitorController(IVisitorRepository repo)
        {
            visitorRepository = repo;
        }

        // GET: api/<VisitorController>
        [HttpGet]
        public IEnumerable<Visitor> Get()
        {
            return visitorRepository.GetAllVisitors();
        }

        // GET api/<VisitorController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Visitor v = visitorRepository.GetAllVisitor(id);
            if (v == null)
                return NoContent();
            return new OkObjectResult(v);
        }

        // POST api/<VisitorController>
        [HttpPost]
        public void Post([FromBody] Visitor value)
        {
            visitorRepository.AddVisitor(value);
        }

        // PUT api/<VisitorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Visitor value)
        {
            var result = visitorRepository.UpdateVisitor(id, value);
            if (result == false)
                return NoContent();
            return Ok();

        }

        // DELETE api/<VisitorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = visitorRepository.DeleteVisitor(id);
            return Ok();
        }
    }
}

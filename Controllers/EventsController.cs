using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RivkiToledano02._11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        static DataContext context = new DataContext();

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(context.Events);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id >= context.Events.Count)
                return NotFound();

            return Ok(context.Events[id].Title);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Event value)
        {
            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            context.Events.Add(new Event { Id = Event.Count, Title = value.Title, Start = value.Start });

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event value)
        {
            if (id >= context.Events.Count)
                return NotFound();

            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            var e = context.Events.Find(e => e.Id == id);
            e.Title = value.Title;
            e.Start = value.Start;

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= context.Events.Count)
                return NotFound();

            var e = context.Events.Find(e => e.Id == id);
            context.Events.Remove(e);

            return Ok();
        }
    }
}
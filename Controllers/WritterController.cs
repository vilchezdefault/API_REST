using Microsoft.AspNetCore.Mvc;
using API_rest.Data;

using API_rest.services;

namespace API_rest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WritterController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<clWritter>> GetWriters()
        {
            return Ok (WriterDataStore.Current.Writers);
        }


        [HttpGet("(writerId)")]
        public ActionResult<clWritter> GetWriter(int writerId)
        {
            var writer = WriterDataStore.Current.Writers.FirstOrDefault(x=> x.IdWriter_prop == writerId);
            if (writer == null)
            
                return NotFound("Writer not found. :( )");

            return Ok(writer);
            
        }

        [HttpPost]
        public ActionResult<PostInsertWriter> PostWriter(PostInsertWriter postInsertWriter)
        {
            var maxWriterId = WriterDataStore.Current.Writers.Max(x => x.IdWriter_prop);

            var newWriter = new clWritter(){
                
                IdWriter_prop  = maxWriterId + 1,
                Nickname_prop = postInsertWriter.Nickname_prop,
                Style_prop = postInsertWriter.Style_prop,
                Nationality_prop = postInsertWriter.Nationality_prop,
                Crew_prop = postInsertWriter.Crew_prop
            };


            WriterDataStore.Current.Writers.Add(newWriter);

            return CreatedAtAction(nameof(GetWriter),
            new {writerId = newWriter.IdWriter_prop},
            newWriter
            );

        }

    }
}

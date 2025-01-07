using Microsoft.Data.SqlClient;  // Asegúrate de estar usando Microsoft.Data.SqlClient
using Microsoft.AspNetCore.Mvc;
using API_rest.Data;
using System.Data;
using System.Collections.Generic;
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



    }
}

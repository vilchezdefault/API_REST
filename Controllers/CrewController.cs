using API_rest.Data;
using API_rest.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API_rest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrewController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ClCrew>> GetCrews()
        {
            return Ok (CrewDataStore.Current.Crews);

        }

        [HttpGet("(crewId)")]
        public ActionResult<ClCrew> GetCrew(int crewId)
        {
            var crew = CrewDataStore.Current.Crews.FirstOrDefault(x=> x.IdCrew_prop == crewId);
            if (crew == null)
            {
                return NotFound("Crew not found. :()");

            }
              return Ok(crew);

        }




    }
}
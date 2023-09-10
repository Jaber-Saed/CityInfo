using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
             new List<object> {
                new {id = 1, Name = "Nwq York City"},
                new {id = 2, Name = "Antwerp"}
             });
        }
    }
}

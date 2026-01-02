using API.Contracts.Locatie;
using Domain.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("locatie")]
    [ApiController]
    public class LocatieController(ILocatieService service, ILoggingService loggingService) : ControllerBase
    {
        [HttpPost]
        public ActionResult<LocatieResponseContract> PostLocatie([FromBody] LocatieRequestContract locatie)
        {
            var response = service.CreateLocatie(locatie);
            loggingService.log(locatie, "Post", 0, true);
            return Ok(response);
        }
    }
}

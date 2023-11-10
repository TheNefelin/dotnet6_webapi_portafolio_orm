using db_portafolio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_webapi_portafolio_orm.Controllers
{
    [Route("links")]
    [ApiController]
    public class PFLinksController : ControllerBase
    {
        private PortafolioContext _portafolioContext;

        public PFLinksController(PortafolioContext portafolioContext)
        {
            _portafolioContext = portafolioContext;
        }

        [HttpGet]
        [Route("/link")]
        public IEnumerable<dynamic> Get()
        {
            return _portafolioContext.PF_Link.ToList();
        }
    }
}

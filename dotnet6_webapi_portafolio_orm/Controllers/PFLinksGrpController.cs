using db_portafolio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_webapi_portafolio_orm.Controllers
{
    [Route("links_grp")]
    [ApiController]
    public class PFLinksGrpController : ControllerBase
    {
        private PortafolioContext _portafolioContext;

        public PFLinksGrpController(PortafolioContext portafolioContext)
        {
            _portafolioContext = portafolioContext;
        }

        [HttpGet]
        [Route("/link_grp")]
        public IEnumerable<dynamic> Get()
        {
           return _portafolioContext.PF_Link_Grp.ToList();
        }
    }
}

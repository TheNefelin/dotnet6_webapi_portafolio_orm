using db_portafolio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_webapi_portafolio_orm.Controllers
{
    [Route("portafolio_data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private PortafolioContext _portafolioContext;

        public DataController(PortafolioContext portafolioContext)
        {
            _portafolioContext = portafolioContext;
        }

        [HttpGet]
        [Route("/link_grp")]
        public IEnumerable<dynamic> Get_Link_Grp()
        {
            return _portafolioContext.PF_Link_Grp.ToList();
        }

        [HttpGet]
        [Route("/link")]
        public IEnumerable<dynamic> Get_Link()
        {
            return _portafolioContext.PF_Link.ToList();
        }
    }
}

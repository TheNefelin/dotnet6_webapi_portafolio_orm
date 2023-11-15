using db_portafolio;
using dotnet6_webapi_portafolio_orm.Connection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet6_webapi_portafolio_orm.Controllers
{
    [Route("portafolio_data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private PortafolioContext _portafolioContext;
        private readonly ConexionDBContext _context;
        
        public DataController(PortafolioContext portafolioContext, ConexionDBContext context)
        {
            _portafolioContext = portafolioContext;
            _context = context;
        }

        [HttpGet]
        [Route("link_grp")]
        public IEnumerable<dynamic> Get_Link_Grp()
        {
            return _portafolioContext.PF_Link_Grp.ToList();
        }

        [HttpGet]
        [Route("link")]
        public IEnumerable<dynamic> Get_Link()
        {
            return _portafolioContext.PF_Link.ToList();
        }

        [HttpGet]
        [Route("web_link_grp")]
        public async Task<IEnumerable<dynamic>> WebLinksGroup(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Links_Group_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("web_link")]
        public async Task<IEnumerable<dynamic>> WebLinks(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Links_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}

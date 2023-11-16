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

        //[HttpGet]
        //[Route("link_grp")]
        //public IEnumerable<dynamic> Get_Link_Grp()
        //{
        //    return _portafolioContext.PF_Link_Grp.ToList();
        //}

        //[HttpGet]
        //[Route("link")]
        //public IEnumerable<dynamic> Get_Link()
        //{
        //    return _portafolioContext.PF_Link.ToList();
        //}

        [HttpGet]
        [Route("link_grp")]
        public async Task<IEnumerable<dynamic>> PFLinkGrp(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFlinkgrp(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("link")]
        public async Task<IEnumerable<dynamic>> PFLink(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFlink(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("youtube")]
        public async Task<IEnumerable<dynamic>> PFYoutube(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFyoutube(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("project")]
        public async Task<IEnumerable<dynamic>> PFProject(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFproject(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("source")]
        public async Task<IEnumerable<dynamic>> PFSource(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFsource(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("language")]
        public async Task<IEnumerable<dynamic>> PFLanguage(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFlanguage(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("technology")]
        public async Task<IEnumerable<dynamic>> PFtechnology(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PFtechnology(
                conexion,
                default,
                cancelarToken);

            return r;
        }

    }
}

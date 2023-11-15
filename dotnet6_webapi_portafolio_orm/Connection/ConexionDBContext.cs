using Dapper;
using db_portafolio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace dotnet6_webapi_portafolio_orm.Connection
{
    public class ConexionDBContext
    {
        private readonly string _RutaDeConexion;

        public ConexionDBContext(String RutaDeConexion)
        {
            _RutaDeConexion = RutaDeConexion;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_RutaDeConexion);

        //-- Links Grupo List ---------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_Group_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_mae_links_grp_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Links List ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_mae_links_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }
    }
}

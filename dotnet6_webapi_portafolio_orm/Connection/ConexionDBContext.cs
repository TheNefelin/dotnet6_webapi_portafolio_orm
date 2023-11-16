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

        //-- Links Grupo --------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFlinkgrp(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT * FROM pf_link_grp",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Links --------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFlink(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT* FROM pf_link",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

        //-- Youtube ------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFyoutube(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT * FROM pf_youtube",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

        //-- Project ------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFproject(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT * FROM pf_project",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

        //-- Source -------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFsource(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT a.*, b.id_project FROM pf_pro_source a INNER JOIN pf_pro_sour b ON a.id = b.id_source",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

        //-- Language -----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFlanguage(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT a.*, b.id_project FROM pf_pro_language a INNER JOIN pf_pro_lang b ON a.id = b.id_language",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

        //-- Technology ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PFtechnology(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"SELECT a.*, b.id_project FROM pf_pro_technology a INNER JOIN pf_pro_tech b ON a.id = b.id_technology",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));


            return r;
        }

    }
}

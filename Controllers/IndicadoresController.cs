using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;


namespace APIIndicadores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadoresController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Indicador> Get(
            [FromServices]IConfiguration config)
        {
            using (SqlConnection conexao =
            new SqlConnection(config.GetConnectionString("BaseIndicadores")))
            {
                return conexao.Query<Indicador>("SELECT * FROM dbo.Indicadores");
            }
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace docSpider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public PdfController(IConfiguration configuration) {
            _configuration = configuration;
        }

        public JsonResult Get()
        {
            string query = @" 
                select * 
                from Pdf
            ";

            DataTable table = new DataTable();
            string sqlDataSoucer = _configuration.GetConnectionString("docSpiderAppCon");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSoucer))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }

            }
            return new JsonResult(table);
        }
    }
}

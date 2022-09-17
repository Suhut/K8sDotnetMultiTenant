using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AccountApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestConnDbController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public TestConnDbController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost(Name = "ConnDb")]
        public async Task<string> ConnDbAsync()
        {
            var connString = _configuration.GetConnectionString("DefaultConnection");
            string result = "Belum Open";
            try
            { 
                var conn = new SqlConnection(connString);
                await conn.OpenAsync();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    result= "Sudah Open";
                }
                
            }
            catch (Exception ex)
            { 
                return $"{result} ___ {connString} ___ {ex.Message} ";
            }
            return $"{result}"; 
        }
    }
}
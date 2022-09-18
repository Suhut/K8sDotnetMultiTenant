using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace TenantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestPingController : ControllerBase
    { 

        [HttpGet(Name = "TestPing")]
        public async Task<string> TestPingAsync()
        {   
            return $"Masuk Mas __ {Environment.GetEnvironmentVariable("APP_NAME")}"; 
        }
    }
}
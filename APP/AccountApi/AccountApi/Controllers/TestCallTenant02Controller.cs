using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AccountApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestCallTenant02Controller : ControllerBase
    {


        [HttpPost(Name = "TestCallTenant02")]
        public async Task<string> TestCallTenant02Async()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://myapp-tenant02-api-service.myapp-tenant02.svc/TestPing");
                return $"{result}";
            }

        }

    }
}
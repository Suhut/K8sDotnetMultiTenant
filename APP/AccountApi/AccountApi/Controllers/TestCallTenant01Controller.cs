using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AccountApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestCallTenant01Controller : ControllerBase
    {


        [HttpPost(Name = "TestCallTenant01")]
        public async Task<string> TestCallTenant01Async()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://myapp-tenant01-api-service.myapp-tenant01.svc/TestPing");
                return $"{result}";
            }

        }

    }
}
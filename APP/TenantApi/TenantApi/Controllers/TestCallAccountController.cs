using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace TenantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestCallAccountController : ControllerBase
    {


        [HttpPost(Name = "TestCallTenant01")]
        public async Task<string> TestCallTenant01Async()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://myapp-account-api-service.myapp-account.svc/TestPing");
                return $"{result}";
            }

        }

    }
}
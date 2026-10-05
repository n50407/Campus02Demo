using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Campus02Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {

        [HttpGet]
        public void Demo()
        {

        }
    }
}

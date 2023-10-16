using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace One.Controllers;
[Route("api/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]   
    public string Hello()
        => "Hello from one";
}

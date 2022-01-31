namespace eCommerceServer.Features
{
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
    }
}

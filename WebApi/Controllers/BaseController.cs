using DAL.Extentions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Authorize]
    [EnableCors("AllowAllOrigins")]
    [Produces("application/json")]
    public class BaseController : Controller
    {
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = User.Claims.Select(c => new { c.Type, c.Value });
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}

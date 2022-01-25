using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StateLessApp.Controllers
{
    public class MainController : ControllerBase
    {
        private readonly IConfiguration _config;

        public MainController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("stateless-operation")]
        public IActionResult DoStatelessOperation()
        {
            var nodeId = _config["NodeId"];

            return Ok(nodeId);
        }
    }
}

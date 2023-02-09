using Microsoft.AspNetCore.Mvc;

namespace event_domain_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SportsController : ControllerBase
{
    private readonly ILogger<SportsController> _logger;

    public SportsController(ILogger<SportsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSports")]
    public string Get()
    {
        return "Sports Controller";
    }

    [HttpPost(Name = "PostSports")]
    public string Post()
    {
        return "Sports Controller";
    }
}
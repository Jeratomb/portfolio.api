using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace portfolio.api.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors]
public class ProjectController : ControllerBase
{
    private readonly ILogger<ProjectController> _logger;

    public ProjectController(ILogger<ProjectController> logger)
    {
        _logger = logger;
    }

    [Produces("application/json")]
    [HttpGet(Name = "GetProjects")]
    [EnableCors]
    public IEnumerable<MyProject> Get()
    {
        StringValues originValues;
        if (Request.Headers.Keys.Contains("Origin"))
        {
            Request.Headers.TryGetValue("Origin", out originValues);
            _logger.Log(LogLevel.Information, "origin: " + originValues);
            Console.WriteLine("origin: " + originValues);
        }
        var resutls = Enumerable.Range(1, 15).Select(index => new MyProject
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-" + index,
            Description = "Test-Project-Description",
            CreationDate = DateTime.UtcNow,
            LastUpdateDate = DateTime.UtcNow.AddDays(index)
        })
                .ToList();
        return resutls;
    }
}

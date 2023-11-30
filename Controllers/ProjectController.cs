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
    public IEnumerable<Project> Get()
    {
        StringValues originValues;
        if (Request.Headers.Keys.Contains("Origin"))
        {
            Request.Headers.TryGetValue("Origin", out originValues);
            _logger.Log(LogLevel.Information, "origin: " + originValues);
            Console.WriteLine("origin: " + originValues);
        }

        var knowledges = new Knowledges();
        Random rnd = new Random();
        knowledges._knowledges.RemoveRange(0, rnd.Next(0, 8));


        var resutls = Enumerable.Range(1, 15).Select(index => new Project
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-" + index,
            Description = "This is a Test Description \nThis is a Test Description\nThis is a Test Description ",
            UsedSkills = knowledges._knowledges,
            CreationDate = DateTime.UtcNow,
            LastUpdateDate = DateTime.UtcNow.AddDays(index)
        })
                .ToList();

        return resutls;
    }
}

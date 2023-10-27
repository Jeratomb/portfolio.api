using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

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

    [HttpGet(Name = "GetProjects")]
    public IEnumerable<Project> Get()
    {
        _logger.Log(LogLevel.Information, "Get call");
        var knowledges = new Knowledges();
        Random rnd = new Random();
        knowledges._knowledges.RemoveRange(0, rnd.Next(0,8));

        return Enumerable.Range(1, 15).Select(index => new Project
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-"+index ,
            Description = "Test-Project-Description",
            UsedSkills = knowledges._knowledges,
            CreationDate = DateTime.UtcNow,
            LastUpdateDate =  DateTime.UtcNow.AddDays(index)
        })
        .ToArray();
   
    }
}

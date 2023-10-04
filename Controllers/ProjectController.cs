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
    public IEnumerable<MyProject> Get()
    {
        _logger.Log(LogLevel.Information, "Get call");
        return Enumerable.Range(1, 15).Select(index => new MyProject
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-"+index ,
            Description = "Test-Project-Description",
            CreationDate = DateTime.UtcNow,
            LastUpdateDate =  DateTime.UtcNow.AddDays(index)
        })
        .ToArray();
   
    }
}

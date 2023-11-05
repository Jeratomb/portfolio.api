using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using portfolio.api.Persistence.Context;

namespace portfolio.api.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors]
public class ProjectController : ControllerBase
{
    private readonly ILogger<ProjectController> _logger;
    private PortfolioDbContext _dbContext;

    public ProjectController(ILogger<ProjectController> logger, PortfolioDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [Produces("application/json")]
    [HttpGet(Name = "GetProjects")]
    [EnableCors]
    public IEnumerable<ProjectDto> Get()
    {

        var projects = _dbContext.GetProjectQuery(CancellationToken.None, true);
        var knowledges = _dbContext.GetKnowldgeQuery(CancellationToken.None, true);
        _dbContext.GetProjectWithKnowledges(CancellationToken.None);

        var dto = projects.Select(x => new ProjectDto() { Id = x.Id, Name = x.Name, Description = x.Description, Created = x.Created, Modified = x.Modified });
        return dto;
        StringValues originValues;
        if (Request.Headers.Keys.Contains("Origin"))
        {
            Request.Headers.TryGetValue("Origin", out originValues);
            _logger.Log(LogLevel.Information, "origin: " + originValues);
            Console.WriteLine("origin: " + originValues);
        }

        var KnowledgeList = new KnowledgeList();
        Random rnd = new Random();
        KnowledgeList._knowledges.RemoveRange(0, rnd.Next(0, 8));


        var resutls = Enumerable.Range(1, 15).Select(index => new ProjectDto
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-" + index,
            Description = "Test-Project-Description",
            UsedSkills = KnowledgeList._knowledges,
            Created = DateTime.UtcNow,
            Modified = DateTime.UtcNow.AddDays(index)
        })
                .ToList();

        return resutls;
    }
}

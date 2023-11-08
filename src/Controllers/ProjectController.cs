using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using portfolio.api.Persistence.Context;
using portfolio.api.Persistence.Entities;
using portfolio.api.Services;

namespace portfolio.api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[EnableCors]
public class ProjectController : ControllerBase
{
    private readonly ILogger<ProjectController> _logger;
    private readonly IProjectService _projectService;
    private PortfolioDbContext _dbContext;

    public ProjectController(ILogger<ProjectController> logger, IProjectService projectService)
    {
        _logger = logger;
        _projectService = projectService;
    }

    [Produces("application/json")]
    [HttpGet(Name = "GetProjects")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProjectDto>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [EnableCors]
    public async Task<IActionResult> Get()
    {
        var projects = await _projectService.GetProjectList(CancellationToken.None);

        return projects == null ? NotFound() : Ok(projects);
    }

    [Produces("application/json")]
    [HttpGet("Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProjectDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [EnableCors]
    public async Task<IActionResult> Get(Guid Id)
    {
        var project = await _projectService.GetProjectById(Id, CancellationToken.None);

        return project == null ? NotFound() : Ok(project);
    }

    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProjectDto))]
    [HttpPost]
    public async Task<ActionResult<Project>> Post(ProjectDto projectDto)
    {
        return Ok(await _projectService.CreateProject(projectDto, CancellationToken.None));
    }

}

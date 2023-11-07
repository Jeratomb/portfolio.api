using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using portfolio.api.Persistence.Context;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProjectDto>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [EnableCors]
    public IEnumerable<ProjectDto> Get()
    {
        var projects = _dbContext.GetProjectQuery(CancellationToken.None, true);
        var results = from p in projects
                      select new ProjectDto()
                      {
                          Id = p.Id,
                          Name = p.Name,
                          Description = p.Description,
                          Created = p.Created,
                          UsedSkills = (from k in p.Knowledges
                                        select new KnowledgeDto()
                                        {
                                            Id = k.Id,
                                            Name = k.Name
                                        }).ToList(),
                          Modified = p.Modified

                      };

        return results;
    }

    [Produces("application/json")]
    [HttpGet("Id")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProjectDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [EnableCors]
    public IActionResult Get(Guid Id)
    {
        var project = _dbContext.GetProject(Id, CancellationToken.None, true);

        var result = project.Select(p => new ProjectDto()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Created = p.Created,
            UsedSkills = (from k in p.Knowledges
                          select new KnowledgeDto()
                          {
                              Id = k.Id,
                              Name = k.Name
                          }).ToList(),
            Modified = p.Modified

        });

        return project.Count() == 0 ? NotFound() : Ok(result);
    }

    [Produces("application/json")]
    [HttpPost]
    public async Task<ActionResult<Project>> Post(ProjectDto projectDto)
    {

        IList<Knowledge> knowledges = new List<Knowledge>();
        foreach (KnowledgeDto knowledgeDto in projectDto.UsedSkills)
        {
            if (_dbContext.Knowledges.Find(knowledgeDto.Id) == null)
            {
                var category = _dbContext.KnowledgeCategories.Find(knowledgeDto.KnowledgeCategoryId);


                knowledges.Add(new Knowledge()
                {
                    Id = knowledgeDto.Id,
                    Name = knowledgeDto.Name,
                    KnowledgeCategoryId = knowledgeDto.KnowledgeCategoryId,
                    KnowledgeCategory = category == null ? new KnowledgeCategory() { Id = knowledgeDto.KnowledgeCategoryId, Name = knowledgeDto.KnowledgeCategory } : category,
                });

            }
        };

        _dbContext.Knowledges.AddRange(knowledges);

        _dbContext.Projects.Add(new Project()
        {
            Name = projectDto.Name,
            Description = projectDto.Description,
            Knowledges = knowledges
        });
        await _dbContext.SaveChangesAsync();

        return Ok(projectDto);
    }

}

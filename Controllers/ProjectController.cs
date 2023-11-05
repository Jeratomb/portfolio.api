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

        var results = Enumerable.Range(1, 15).Select(index => new Project
        {
            Id = Guid.NewGuid(),
            Name = "Test-Project-" + index,
            Description = "Test-Project-Description",
            UsedSkills = GetRandomSkills(knowledges._knowledges, rnd), // Verwenden Sie die Methode GetRandomSkills
            CreationDate = DateTime.UtcNow,
            LastUpdateDate = DateTime.UtcNow.AddDays(index)
        })
        .ToList();

        return results;
    }

    private List<Knowledge> GetRandomSkills(List<Knowledge> knowledges, Random rnd)
    {
        int numSkills = rnd.Next(1, knowledges.Count + 2);
        List<Knowledge> randomSkills = knowledges.OrderBy(x => rnd.Next()).Take(numSkills).ToList();

        return randomSkills;
    }
    // private readonly IHttpClientFactory _httpClientFactory;

    // public ProjectController(IHttpClientFactory httpClientFactory)
    // {
    //     _httpClientFactory = httpClientFactory;
    // }

    // [HttpGet(Name = "GetProjects")]
    // public async Task<IActionResult> Get()
    // {

    //     var client = _httpClientFactory.CreateClient();

    //     var githubApiUrl = "https://api.github.com/users/Jeratomb";


    //     HttpResponseMessage response = await client.GetAsync(githubApiUrl);

    //     if (response.IsSuccessStatusCode)
    //     {
    //         string content = await response.Content.ReadAsStringAsync();

    //         return Ok(content);
    //     }
    //     else
    //     {

    //         return StatusCode((int)response.StatusCode, "Fehler bei der Anfrage an die GitHub-API.");
    //     }
    // }
}

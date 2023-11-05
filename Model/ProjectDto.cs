namespace portfolio.api;

public class ProjectDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<KnowledgeDto> UsedSkills { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Modified { get; set; }
}

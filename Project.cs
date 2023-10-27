namespace portfolio.api;

public class Project
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Knowledge> UsedSkills {get; set;}

    public DateTime CreationDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}

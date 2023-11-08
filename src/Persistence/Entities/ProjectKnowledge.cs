namespace portfolio.api.Persistence.Entities
{
    public class ProjectSkill
    {
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }

        public Guid KnowledgeId { get; set; }
    }
}
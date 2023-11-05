using System.ComponentModel.DataAnnotations;

namespace portfolio.api.Persistence.Entities
{
    public class Project: IGuidIdentifier, IAuditEntity
    {
        public Guid Id { get; set; }
        [Required]
        public Guid KnowledgeId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Knowledge> Knowledges { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
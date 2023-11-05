using System.ComponentModel.DataAnnotations;

namespace portfolio.api.Persistence.Entities
{
    public class KnowledgeCategory : IGuidIdentifier, IAuditEntity
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Knowledge> Knowledges { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
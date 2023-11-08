using System.ComponentModel.DataAnnotations;

namespace portfolio.api.Persistence.Entities
{
    public class Knowledge : IGuidIdentifier, IAuditEntity
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
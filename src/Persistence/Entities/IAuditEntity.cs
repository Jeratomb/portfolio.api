using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.api.Persistence.Entities
{
    public interface IAuditEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
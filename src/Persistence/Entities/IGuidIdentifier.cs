using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.api.Persistence.Entities
{
    public interface IGuidIdentifier
    {
        Guid Id { get; set; }
    }
}
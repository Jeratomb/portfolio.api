using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.api.Persistence.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Range(1, 10)]
        public int Assessment { get; set; }
    }
}
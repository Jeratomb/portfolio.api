using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using portfolio.api.Persistence.Context;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Services
{
    public class KnowledgeService
    {
        private readonly PortfolioDbContext _dbContext;

        public KnowledgeService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<object> CreateKnowledge(KnowledgeDto knowledgeDto, CancellationToken cancellationToken = default)
        {
            //Get Category
            var category = await _dbContext.KnowledgeCategories.AsNoTracking().Where(x => x.Id == knowledgeDto.KnowledgeCategoryId).FirstOrDefaultAsync();
            //Set Category to Default
            if (category == null)
            {
                category = await _dbContext.KnowledgeCategories.AsNoTracking().Where(x => x.Name == "Default").FirstOrDefaultAsync();
                if (category == null)
                {
                    return new Exception("Unable to create KnowledgeCategory");
                }
            }

            try
            {
                //Create Knowledge entity
                var Knowledge = new Knowledge()
                {
                    Id = Guid.NewGuid(),
                    Name = knowledgeDto.Name,
                    KnowledgeCategoryId = category!.Id,
                    KnowledgeCategory = category,
                    Created = DateTime.UtcNow,
                    Modified = DateTime.UtcNow

                };

                // Add Knowledge entity
                await _dbContext.Knowledges.AddAsync(Knowledge);
                await _dbContext.SaveChangesAsync();
                return Knowledge.Id;
            }
            catch (System.Exception e)
            {
                return new Exception("Unable to create Knowledge", e.InnerException);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.api.Persistence.Context;
using portfolio.api.Persistence.Entities;

namespace portfolio.api.Services
{
    public class ProjectService : IProjectService
    {
        private readonly PortfolioDbContext _dbContext;

        public ProjectService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // public async Task<object> CreateKnowledge(KnowledgeDto knowledgeDto, CancellationToken cancellationToken = default)
        // {
        //     // //Get Category
        //     // var category = await _dbContext.KnowledgeCategories.AsNoTracking().Where(x => x.Id == knowledgeDto.KnowledgeCategoryId).FirstOrDefaultAsync();
        //     // //Set Category to Default
        //     // if (category == null)
        //     // {
        //     //     category = await _dbContext.KnowledgeCategories.AsNoTracking().Where(x => x.Name == "Default").FirstOrDefaultAsync();
        //     //     if (category == null)
        //     //     {
        //     //         return new Exception("Unable to create KnowledgeCategory");
        //     //     }
        //     // }

        //     try
        //     {
        //         //Create Knowledge entity
        //         var Knowledge = new Knowledge()
        //         {
        //             Id = Guid.NewGuid(),
        //             Name = knowledgeDto.Name,
        //             Created = DateTime.UtcNow,
        //             Modified = DateTime.UtcNow

        //         };

        //         // Add Knowledge entity
        //         await _dbContext.Knowledges.AddAsync(Knowledge);
        //         await _dbContext.SaveChangesAsync();
        //         return Knowledge.Id;
        //     }
        //     catch (System.Exception e)
        //     {
        //         return new Exception("Unable to create Knowledge", e.InnerException);
        //     }
        // }
        public async Task<ProjectDto> CreateProject(ProjectDto projectDto, CancellationToken cancellationToken = default)
        {
            IList<Knowledge> knowledges = new List<Knowledge>();
            foreach (KnowledgeDto knowledgeDto in projectDto.UsedSkills)
            {
                var knowledge = _dbContext.Knowledges.Where(x => x.Name.ToLower().Trim() == knowledgeDto.Name.ToLower().Trim()).FirstOrDefault();

                if (knowledge == null)
                    _dbContext.Knowledges.Add(new Knowledge() { Name = knowledgeDto.Name });
                else
                    knowledges.Add(knowledge);
            };

            

            _dbContext.Projects.Add(new Project()
            {
                Name = projectDto.Name,
                Description = projectDto.Description,
                Knowledges = knowledges
            });
            await _dbContext.SaveChangesAsync();

            return projectDto;
        }

        public async Task<ProjectDto> GetProjectById(Guid Id, CancellationToken cancellationToken = default)
        {
            var project = _dbContext.GetProject(Id, CancellationToken.None, true);

            var result = project.Select(p => new ProjectDto()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Created = p.Created,
                UsedSkills = (from k in p.Knowledges
                              select new KnowledgeDto()
                              {
                                  Id = k.Id,
                                  Name = k.Name
                              }).ToList(),
                Modified = p.Modified

            }).FirstOrDefault();
            return result;
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectList(CancellationToken cancellationToken = default)
        {
            var projects = _dbContext.GetProjectQuery(CancellationToken.None, true);
            var results = from p in projects
                          select new ProjectDto()
                          {
                              Id = p.Id,
                              Name = p.Name,
                              Description = p.Description,
                              Created = p.Created,
                              UsedSkills = (from k in p.Knowledges
                                            select new KnowledgeDto()
                                            {
                                                Id = k.Id,
                                                Name = k.Name
                                            }).ToList(),
                              Modified = p.Modified

                          };
            return results;
        }
    }
}
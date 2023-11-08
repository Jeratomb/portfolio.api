using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.api.Services
{
    public interface IProjectService
    {
        Task<ProjectDto> CreateProject(ProjectDto projectDto, CancellationToken cancellationToken = default);
        Task<ProjectDto> GetProjectById(Guid Id, CancellationToken cancellationToken = default);
        Task<IEnumerable<ProjectDto>> GetProjectList(CancellationToken cancellationToken = default);
    }
}
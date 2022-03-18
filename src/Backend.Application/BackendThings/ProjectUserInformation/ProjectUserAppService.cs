using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Backend.BackendThings.ProjectUserInformation.Dto;
using Backend.EntityModels.ProjectUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.ProjectUserInformation
{
    [AbpAuthorize]
    public class ProjectUserAppService : AsyncCrudAppService<ProjectUser, Dto_projectuser, int, PagedResultRequestDto, Dto_projectuser, Dto_projectuser>
    {
        public ProjectUserAppService(IRepository<ProjectUser, int> repository) : base(repository)
        {
        }
    }
}

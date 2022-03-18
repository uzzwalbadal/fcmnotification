using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Backend.BackendThings.DepartmentInformations.Dto;
using Backend.EntityModels.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.DepartmentInformations
{
    [AbpAuthorize]
    public class DepartmentAppService : AsyncCrudAppService<Department, Dto_Department, int, PagedResultRequestDto, Dto_Department, Dto_Department>
    {
        public DepartmentAppService(IRepository<Department, int> repository) : base(repository)
        {
        }
    }
}

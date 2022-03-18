using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Backend.EntityModels.ProjectUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.ProjectUserInformation.Dto
{
    [AutoMap(typeof(ProjectUser))]
    public class Dto_projectuser : EntityDto<int>
    {
        public string DeviceId { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}

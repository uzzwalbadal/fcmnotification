using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Backend.EntityModels.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.DepartmentInformations.Dto
{
    [AutoMap(typeof(Department))]
   public class Dto_Department : EntityDto<int>
    {
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public DateTime OpeningHours { get; set; }
    }
}

using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.EntityModels.ProjectUser
{
    [Table("Project_User")]
    public class ProjectUser : FullAuditedEntity<int>
    {
        public string DeviceId { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}

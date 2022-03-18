using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.EntityModels.Department
{
    [Table("Department")]
    public class Department : FullAuditedEntity<int>
    {
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public DateTime OpeningHours { get; set; }
        

    }
}

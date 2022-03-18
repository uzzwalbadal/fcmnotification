using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.EntityModels.Tokens
{
    [Table("TOken")]
   public class Token : FullAuditedEntity<int>
    {
    }
}

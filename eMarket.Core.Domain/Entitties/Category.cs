using eMarket.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Domain.Entitties
{
    public class Category : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //navigation property
        public ICollection<Article> Articles { get; set; }
    }
}

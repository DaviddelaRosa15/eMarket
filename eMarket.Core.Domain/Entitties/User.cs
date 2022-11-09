using eMarket.Core.Domain.Common;
using System.Collections.Generic;

namespace eMarket.Core.Domain.Entitties
{
    public class User : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //navigation property
        public ICollection<Article> Articles { get; set; }
    }
}
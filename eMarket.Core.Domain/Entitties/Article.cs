using eMarket.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.Core.Domain.Entitties
{
    public class Article : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrlOne { get; set; }
        public string ImageUrlTwo { get; set; }
        public string ImageUrlThree { get; set; }
        public string ImageUrlFour { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        //Navigation Property
        public Category Category { get; set; }

        public int UserId { get; set; }
        //Navigation Property
        public User User { get; set; }
    }
}

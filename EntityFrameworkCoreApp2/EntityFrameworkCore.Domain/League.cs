using EntityFrameworkCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class League : BaseDomainObject
    { 
        public string Name { get; set; }

        public List<Team> Teams { get; set; }
    }
}

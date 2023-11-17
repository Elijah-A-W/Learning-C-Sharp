using EntityFrameworkCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Coach : BaseDomainObject
    {
        public string Name { get; set; }    

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}

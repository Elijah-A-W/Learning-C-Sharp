using EntityFrameworkCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Team : BaseDomainObject
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }
            
        public virtual League League { get; set; }  

        public virtual Coach Coach { get; set; }

        //Accessing the list of both Home and Away matches
        public virtual List<Match> HomeMatches { get; set; }

        public virtual List<Match> AwayMatches { get; set; }
    }
}

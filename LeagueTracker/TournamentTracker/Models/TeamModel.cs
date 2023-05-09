using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    internal class TeamModel
    {
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();

        public string TeamName { get; set; }
    }
}

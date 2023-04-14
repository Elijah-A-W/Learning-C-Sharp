using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class TournamentModel
    {
        /// <summary>
        /// The name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// The required fee they need to register with
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The team being entered or added 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The prizes to be won by the team
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The team round they belong to.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();  
    }
}

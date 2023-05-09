using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    /// <summary>
    /// Representsthe tournament with all the rounds, matchups, prizes and outcomes
    /// </summary>
    internal class TournamentModel
    {
        /// <summary>
        /// The name given to a particular tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The amount of money each team needs to 
        /// register with
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of all the teams entered/registered 
        /// in the tournament 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The list of available prizes for the
        /// different positions won
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The match up per round
        /// </summary>
        public List<List<MatchupModel>> Round =  new List<List<MatchupModel>>();    
    }
}

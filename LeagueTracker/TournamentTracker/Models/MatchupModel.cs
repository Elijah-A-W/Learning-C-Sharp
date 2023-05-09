using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    internal class MatchupModel
    {
        /// The set of teams involves in this match
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// The winner of the match 
        public TeamModel Winner { get; set; }

        /// The round this match is part of
        public int MatchupRound { get; set; }

    }
}

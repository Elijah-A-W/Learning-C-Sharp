using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TournamentTracker
{
    internal class MatchupEntryModel
    {
        /// Represents a team in the matchup
        public TeamModel TeamCompeting { get; set; }

        /// Represent the score for the Team
        public double Score { get; set; }

        /// Represents the matchup the team came from
        public MatchupModel ParentMatchup { get; set; }
    }
}

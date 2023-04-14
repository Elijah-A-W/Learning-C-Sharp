using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class PrizeModel
    {   
        /// <summary>
        /// The position number of the team
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the position obtained [ WInner / 2ndRunnersUp / 3rdRunnersUp]
        /// </summary>
        public string PlaceName { get; set; }   

        /// <summary>
        /// The amount that has been won in cash
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The prize percentage that has been obtained
        /// </summary>
        public double PrizePercentage { get; set; } 
    }
}

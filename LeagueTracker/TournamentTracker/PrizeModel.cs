using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class PrizeModel
    {
        /// <summary>
        ///  The prize model  with its unique ID
        /// </summary>
        public int Id { get; set; }

        /// The position number of the team
        public int PlaceNumber { get; set; }

        /// The name of the position obtained [ Winner / 2ndRunnersUp / 3rdRunnersUp]
        public string? PlaceName { get; set; }

        /// The amount that has been won in cash
        public decimal PrizeAmount { get; set; }

        /// The Prize Percentage Obtained 
        public double PrizePercentage { get; set; }
    }
}
